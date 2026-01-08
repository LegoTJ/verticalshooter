using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    public static int level;
    public AudioSource Sfx;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        level = PlayerPrefs.GetInt("CurrentLevel");
        Sfx.Play();
    }
    private void Update()
    {
        level = PlayerPrefs.GetInt("CurrentLevel");

            //damage = 1;

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsSolid);
        if(hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<EnemyHealth>().GiveDamage(damage);
                Debug.Log("damaged");
                //hitInfo.collider.GetComponent<EnemyHealth>().TakeDamage(damage);
                /* }else if (hitInfo.collider.CompareTag("Player"))
                 {
                     Debug.Log("DAMAGED");
                     hitInfo.collider.GetComponent<Health>().TakeDamage(damage);
                 */
            }
            DestroyProjectile();
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);

    }

    void DestroyProjectile()
    {
       // Sfx.Play();
        Destroy(gameObject);
    }
}