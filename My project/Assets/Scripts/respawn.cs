using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public float lifeTime = 5f;
    public float distance;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        if(boxCollider == null)
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
        StartCoroutine(DisableAfterDelay());
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
        StartCoroutine(DisableAfterDelay());
    }
    public void onEnable()
    {
        DisableEnemiesInArea();
        StartCoroutine(DisableAfterDelay());
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
            if (collider.CompareTag("Enemy"))
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
    private IEnumerator DisableAfterDelay()
    {
        yield return new WaitForSeconds(lifeTime);
        gameObject.SetActive(false);
    }
    private void OnDrawGizmo()
    {
        if(boxCollider != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(boxCollider.bounds.center, boxCollider.bounds.size);
        }
        // Sfx.Play();
        //Destroy(gameObject);
    }
}
