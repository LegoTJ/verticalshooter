using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : MonoBehaviour
{
    public HealthManager healthManager;
    public Transform player;
    private Rigidbody2D rb;
    public int life;
    public float speed;
    public float lifeTime;
    public float distance;
    public Vector2 target;
    public LayerMask whatIsSolid;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            rb = GetComponent<Rigidbody2D>();
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsSolid);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
                other.GetComponent<Collider2D>().GetComponent<HealthManager>().GiveLife(life);
                Debug.Log("damaged");
                gameObject.SetActive(false);
        }
    }
}
