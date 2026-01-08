using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int enemyHealth;
    public int enemyMaxHealth;
	public int pointsOnDeath;
    public GameObject enemy;
    public AudioSource Sfx;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (enemyHealth <= 0)
        {
            Sfx.Play();
            ScoreManager.AddPoints(pointsOnDeath);
            //Destroy(enemy);
            enemy.SetActive(false);
            enemyHealth = enemyMaxHealth;
        }
        else if (enemyHealth == enemyMaxHealth)
        {
            enemy.SetActive(true);
        }
    }

    public void GiveDamage(int damageToGive)
    {
        enemyHealth -= damageToGive;
    }
    public void GiveDamageNoPoints(int damageToGive)
    {
        enemyHealth -= damageToGive;
        pointsOnDeath = 0;
    }
}
