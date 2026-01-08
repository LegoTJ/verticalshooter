using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public Vector2 target;
    //public Vector2 targetnew;
    public int damage;
    public LayerMask whatIsSolid;
    public Transform player;
    public static int level;
    public bool movable;
    private Rigidbody2D rb;
    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        level = PlayerPrefs.GetInt("CurrentLevel");
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            rb = GetComponent<Rigidbody2D>();
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        else
        {
                return;
        }
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        float rot = Mathf.Atan2(-direction.x, -direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot -10);
        Invoke("DestroyProjectile", lifeTime);
        
    }
    private void Update()
    {
        level = PlayerPrefs.GetInt("CurrentLevel");

        damage = 1;
        if (player == null)
        {
            return;
        }
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Player"))
            {
                hitInfo.collider.GetComponent<HealthManager>().HurtPlayer(damage);
                //hitInfo.collider.GetComponent<EnemyHealth>().TakeDamage(damage);
                /* }else if (hitInfo.collider.CompareTag("Player"))
                 {
                     Debug.Log("DAMAGED");
                     hitInfo.collider.GetComponent<Health>().TakeDamage(damage);
                 */
            }
            DestroyProjectile();
        }
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
        //transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    void DestroyProjectile()
    {
        // Sfx.Play();
        Destroy(gameObject);
    }
}


