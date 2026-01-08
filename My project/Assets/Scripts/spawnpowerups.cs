using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpowerups : MonoBehaviour
{
    public EnemyHealth health;
    public GameObject PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health.enemyHealth <= 0)
        {
            PowerUp.SetActive(true);
        }
    }
}
