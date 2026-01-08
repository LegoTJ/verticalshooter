using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public HealthManager playerhealth;
    public EnemyHealth enemyhealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerhealth.health == 0)
        {
            enemyhealth.enemyHealth = enemyhealth.enemyMaxHealth;
        }
    }
}
