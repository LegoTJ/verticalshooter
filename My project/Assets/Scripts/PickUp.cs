using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    public float speed;
    public float lifeTime;
    public float distance;
    public Vector2 target;
    public LayerMask whatIsSolid;
    public GameObject Powers;
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

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("isonface2");
            Powers.SetActive(true);
            other.GetComponent<Collider2D>().GetComponent<HealthManager>().HurtPlayer(-1);
            gameObject.SetActive(false);
        }
    }
}
