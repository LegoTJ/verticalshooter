using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public int health;
    public int isActive;
    public HealthManager healthManager;
    public Transform player;
    private Rigidbody2D rb;
    public float speed;
    public float lifeTime;
    public float distance;
    public Vector2 target;
    public LayerMask whatIsSolid;
    // Start is called before the first frame update
    void Start()
    {
        health = healthManager.health;
        isActive = 1;
    }

    // Update is called once per frame
    void Update()
    {
        health = healthManager.health;
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsSolid);
        if (isActive == 1 && health == 1)
        {
            //hitInfo.collider.GetComponent<HealthManager>().HurtPlayer(-1);
            isActive = 2;
        } else if (health == 2) {

        }
        else if (health == 1)
        {
            health = 2;
            isActive = 0;
            gameObject.SetActive(false);
        }
    }
    public void powerActive()
    {
        isActive = 1;
    }
}
