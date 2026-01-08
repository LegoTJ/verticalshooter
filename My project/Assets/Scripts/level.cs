using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    public HealthManager healthManager;
    public GameObject Level1;
    public GameObject Level2; 
    public GameObject Level3; 
    public GameObject Level4; 
    public GameObject Level5;
    public int Level;
    public int RandomNumber;
    // Start is called before the first frame update
    void Start()
    {
        if(healthManager == null)
        {
            healthManager = GameObject.Find("Player").GetComponent<HealthManager>();
            if(healthManager == null)
            {
                
            }
        }
        Level = PlayerPrefs.GetInt("Level");
    }

    // Update is called once per frame
    void Update()
    {
        if(healthManager.life == 0)
        {
            Level = 0;
        }
        if (Level == 0 && healthManager.complete == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Level1.SetActive(false);
                Level2.SetActive(true);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                healthManager.complete = false;
                Level = Level + 1;
            }
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
        }
        if (Level == 1 && healthManager.complete == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(true);
                Level4.SetActive(false);
                Level5.SetActive(false);
                healthManager.complete = false;
                Level = Level + 1;
            }
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
        }
        if (Level == 2 && healthManager.complete == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(true);
                Level5.SetActive(false);
                healthManager.complete = false;
                Level = Level + 1;
            }
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(true);
            Level4.SetActive(false);
            Level5.SetActive(false);
        }
        if (Level == 3 && healthManager.complete == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(true);
                healthManager.complete = false;
                Level = Level + 1;
            }
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(true);
            Level5.SetActive(false);
        }
        if (Level == 4 && healthManager.complete == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Level = Level + 1;
                healthManager.complete = false;
            }
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(true);
        }
        if(Level >= 5 && healthManager.complete == true)
        {
            if (RandomNumber == 0)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Level = Level + 1;
                    healthManager.complete = false;
                }
                Level2.SetActive(true);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
            }
            else if (RandomNumber == 1)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Level = Level + 1;
                    healthManager.complete = false;
                }
                Level2.SetActive(false);
                Level3.SetActive(true);
                Level4.SetActive(false);
                Level5.SetActive(false);
            }
            else if (RandomNumber == 2)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Level = Level + 1;
                    healthManager.complete = false;
                }
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(true);
                Level5.SetActive(false);
            }
            else
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Level = Level + 1;
                    healthManager.complete = false;
                }
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(true);
            }
        }
    }
}
