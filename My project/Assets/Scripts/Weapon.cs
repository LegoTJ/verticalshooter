using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weapon : MonoBehaviour
{
    public GameObject projectile;
    public GameObject projectile2;
    public Transform shotPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public int health;
    public HealthManager healthManager;
    //public AudioSource Sfx;
    private void Update()
    {
        health = healthManager.health;
        if (health == 1)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //Sfx.Play();
                if (timeBtwShots <= 0)
                {

                    Instantiate(projectile, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
                else
                {
                    timeBtwShots -= Time.deltaTime;
                }
                //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
            }
        }else if(health == 2)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //Sfx.Play();
                if (timeBtwShots <= 0)
                {

                    Instantiate(projectile2, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
                }
                else
                {
                    timeBtwShots -= Time.deltaTime;
                }
                //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
            }
        }
        /*if (Input.GetMouseButtonDown(0))
        {
            if (timeBtwShots <= 0)
            {

                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }*/
    }
}