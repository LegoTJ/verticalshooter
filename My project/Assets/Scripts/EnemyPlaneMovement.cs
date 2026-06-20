using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1945-style attack run for an enemy plane.
// The plane sits dormant in the scrolling map (holding fire) until it enters the
// camera. It then flies a ONE-SHOT scripted path, anchored to where it entered,
// that sweeps/dives and descends off the bottom of the screen while shooting.
// Once the run finishes it despawns (deactivates). You fly past it as it goes.
// Patterns are based on the player's sketches.
public class EnemyPlaneMovement : MonoBehaviour
{
    public enum Pattern { SwoopDive, Loop, StraightDive, PerimeterSweep }

    [Header("Pattern")]
    public Pattern pattern = Pattern.SwoopDive;
    public bool mirror = false;        // flip the path horizontally (e.g. lean the other way)
    public bool loopPattern = false;   // 1945-style is one-shot; enable to repeat the run

    [Header("Speed / Feel")]
    public float speed = 6f;           // world units per second along the path
    public bool faceDirection = false; // rotate sprite to face travel direction (banking)
    public float facingOffset = -90f;  // sprite "nose" points +Y by default

    [Header("Activation")]
    public bool activateWhenVisible = true; // stay dormant until it enters the camera
    public float viewMargin = 0.05f;        // viewport slack for the "visible" test

    [Header("Setup")]
    public bool detachFromParent = true; // fly independently of the level scroll once active
    public float restartDelay = 0.6f;    // pause before repeating (only if loopPattern)

    private Camera cam;
    private Vector3 entryPos;

    void OnEnable()
    {
        cam = Camera.main;
        if (cam == null) cam = FindObjectOfType<Camera>();
        StopAllCoroutines();
        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
        yield return null; // let transforms/camera settle one frame
        if (cam == null) yield break;

        // Dormant: scroll with the map, hold fire, until seen by the camera.
        SetWeaponsEnabled(false);
        if (activateWhenVisible)
        {
            while (!IsVisibleInCamera())
                yield return null;
        }
        SetWeaponsEnabled(true);

        // Break away from the scrolling level and fly the run in world space.
        if (detachFromParent && transform.parent != null)
            transform.SetParent(null, true);

        do
        {
            entryPos = transform.position;            // anchor the run where it currently is
            List<Vector3> path = BuildPath();
            yield return StartCoroutine(Follow(path));
            if (loopPattern && restartDelay > 0f)
                yield return new WaitForSeconds(restartDelay);
        }
        while (loopPattern && isActiveAndEnabled);

        gameObject.SetActive(false); // one-shot: gone once the run completes
    }

    // True once the plane's position is inside the camera's view (with a margin).
    bool IsVisibleInCamera()
    {
        Vector3 vp = cam.WorldToViewportPoint(transform.position);
        return vp.z > 0f
            && vp.x >= -viewMargin && vp.x <= 1f + viewMargin
            && vp.y >= -viewMargin && vp.y <= 1f + viewMargin;
    }

    // Hold or release fire on every EnemyWeapon in the plane (Gun, etc.).
    void SetWeaponsEnabled(bool on)
    {
        foreach (var w in GetComponentsInChildren<EnemyWeapon>(true))
            w.enabled = on;
    }

    // World point = entry position + an offset (in world units). dx flips when mirrored.
    Vector3 Off(float dx, float dy)
    {
        return entryPos + new Vector3(mirror ? -dx : dx, dy, 0f);
    }

    List<Vector3> BuildPath()
    {
        var p = new List<Vector3>();
        switch (pattern)
        {
            // Every path trends downward from the entry point and exits the bottom.
            case Pattern.SwoopDive: // S-curve weave while descending
                p.Add(Off(0f, 0f));
                p.Add(Off(3.5f, -3f));
                p.Add(Off(-2f, -7f));
                p.Add(Off(2.5f, -11f));
                p.Add(Off(-1f, -16f));
                p.Add(Off(0f, -22f));
                break;
            case Pattern.Loop: // loop-the-loop, then continue down
                p.Add(Off(0f, 0f));
                p.Add(Off(0f, -2f));
                {
                    float cx = 0f, cy = -4.2f, r = 2.2f;
                    for (int i = 0; i <= 8; i++)
                    {
                        float a = Mathf.PI * 0.5f - i * (2f * Mathf.PI / 8f);
                        p.Add(Off(cx + r * Mathf.Cos(a), cy + r * Mathf.Sin(a)));
                    }
                }
                p.Add(Off(0f, -8f));
                p.Add(Off(0f, -22f));
                break;
            case Pattern.StraightDive: // straight down its lane
                p.Add(Off(0f, 0f));
                p.Add(Off(0f, -8f));
                p.Add(Off(0f, -22f));
                break;
            case Pattern.PerimeterSweep: // slide to the side, then dive down the edge
                p.Add(Off(0f, 0f));
                p.Add(Off(5f, -2f));
                p.Add(Off(5f, -12f));
                p.Add(Off(3f, -22f));
                break;
        }
        return p;
    }

    // Follow control points with a Catmull-Rom spline at (roughly) constant speed.
    IEnumerator Follow(List<Vector3> pts)
    {
        if (pts.Count < 2) yield break;

        var poly = new List<Vector3>();
        var c = new List<Vector3>();
        c.Add(pts[0]);
        c.AddRange(pts);
        c.Add(pts[pts.Count - 1]);
        for (int seg = 0; seg < c.Count - 3; seg++)
        {
            Vector3 p0 = c[seg], p1 = c[seg + 1], p2 = c[seg + 2], p3 = c[seg + 3];
            int steps = Mathf.Max(2, Mathf.CeilToInt(Vector3.Distance(p1, p2) / 0.2f));
            for (int i = 0; i < steps; i++)
                poly.Add(CatmullRom(p0, p1, p2, p3, i / (float)steps));
        }
        poly.Add(pts[pts.Count - 1]);

        transform.position = poly[0];
        int idx = 1;
        while (idx < poly.Count)
        {
            Vector3 target = poly[idx];
            Vector3 np = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            Face(transform.position, np);
            transform.position = np;
            if ((target - transform.position).sqrMagnitude < 0.0009f) idx++;
            yield return null;
        }
    }

    void Face(Vector3 from, Vector3 to)
    {
        if (!faceDirection) return;
        Vector3 d = to - from;
        if (d.sqrMagnitude < 1e-6f) return;
        float ang = Mathf.Atan2(d.y, d.x) * Mathf.Rad2Deg + facingOffset;
        transform.rotation = Quaternion.Euler(0f, 0f, ang);
    }

    static Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        float t2 = t * t, t3 = t2 * t;
        return 0.5f * ((2f * p1)
            + (-p0 + p2) * t
            + (2f * p0 - 5f * p1 + 4f * p2 - p3) * t2
            + (-p0 + 3f * p1 - 3f * p2 + p3) * t3);
    }
}
