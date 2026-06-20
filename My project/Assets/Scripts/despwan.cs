using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despwan : MonoBehaviour
{
    public float distance;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        if (boxCollider == null)
        {
            return;
        }

        if (!boxCollider.isTrigger)
        {
            boxCollider.isTrigger = true;
        }
        if (!enabled)
        {
            enabled = true;
            Debug.LogWarning($"respawn script on {gameObject.name} was disabled; re-enabled.");
        }
        DisableEnemiesInArea();
    }
    private void Update()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        if (boxCollider == null)
        {
            return;
        }

        if (!boxCollider.isTrigger)
        {
            boxCollider.isTrigger = true;
        }
        if (!enabled)
        {
            enabled = true;
            Debug.LogWarning($"respawn script on {gameObject.name} was disabled; re-enabled.");
        }
        DisableEnemiesInArea();
    }
    public void onEnable()
    {
        DisableEnemiesInArea();
    }
    private void DisableEnemiesInArea()
    {
        if (boxCollider == null)
        {
            return;
        }
        Collider2D[] colliders = Physics2D.OverlapBoxAll(boxCollider.bounds.center, boxCollider.bounds.size, 0f, LayerMask.GetMask("Enemy"));
        Collider2D[] colliderse = Physics2D.OverlapBoxAll(boxCollider.bounds.center, boxCollider.bounds.size, 0f, LayerMask.GetMask("explode"));
        foreach (Collider2D collider in colliders)
        {
            // Persistent enemies (e.g. Galaga-style planes) manage their own
            // lifetime and must not be wiped by the area clearer.
            if (collider.CompareTag("Enemy") && collider.GetComponentInParent<EnemyPlaneMovement>() == null)
            {
                collider.gameObject.SetActive(false);
            }
        }
        foreach (Collider2D collider in colliderse)
        {
            if (collider.CompareTag("explode"))
            {
                collider.gameObject.SetActive(false);
            }
        }
    }
    private void OnDrawGizmo()
    {
        if (boxCollider != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(boxCollider.bounds.center, boxCollider.bounds.size);
        }
        // Sfx.Play();
        //Destroy(gameObject);
    }
}

