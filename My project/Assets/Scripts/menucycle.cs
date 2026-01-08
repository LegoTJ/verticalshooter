using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucycle : MonoBehaviour
{
    public GameObject Titlescreen;
    public GameObject Highscores;
    public GameObject Gameplay1;
    public GameObject Gameplay2;
    public GameObject Gameplay3;
    public GameObject Gameplay4;
    public GameObject Gameplay5;
    public int GameplayLoop;
    public float GameplayTime;
    public float InGameplayTime;
    public float Countdown = 5f;
    public float InCountdown = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Cycle());
        if (GameplayLoop == 0 && Countdown == 0f)
        {
            Titlescreen.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Highscores.SetActive(false);
            StartCoroutine(InCycle());

            GameplayLoop = 1;
        }
        else if (GameplayLoop == 1 && Countdown == 0f)
        {
            Gameplay1.SetActive(true);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 2;
        }
        else if (GameplayLoop == 2 && Countdown == 0f)
        {
            Highscores.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            GameplayLoop = 3;
        }
        else if (GameplayLoop == 3 && Countdown == 0f)
        {
            Titlescreen.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 4;
        }
        else if (GameplayLoop == 4 && Countdown == 0f)
        {
            Gameplay2.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 5;
        }
        else if (GameplayLoop == 5 && Countdown == 0f)
        {
            Highscores.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            GameplayLoop = 6;
        }
        else if (GameplayLoop == 6 && Countdown == 0f)
        {
            Titlescreen.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 7;
        }
        else if (GameplayLoop == 7 && Countdown == 0f)
        {
            Gameplay3.SetActive(true);
            Gameplay2.SetActive(false);
            Gameplay1.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 8;
        }
        else if (GameplayLoop == 8 && Countdown == 0f)
        {
            Highscores.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            GameplayLoop = 9;
        }
        else if (GameplayLoop == 9 && Countdown == 0f)
        {
            Titlescreen.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 10;
        }
        else if (GameplayLoop == 10 && Countdown == 0f)
        {
            Gameplay4.SetActive(true);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay1.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 11;
        }
        else if (GameplayLoop == 11 && Countdown == 0f)
        {
            Highscores.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            GameplayLoop = 12;
        }
        else if (GameplayLoop == 12 && Countdown == 0f)
        {
            Titlescreen.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 13;
        }
        else if (GameplayLoop == 13 && Countdown == 0f)
        {
            Gameplay5.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Titlescreen.SetActive(false);
            Highscores.SetActive(false);
            GameplayLoop = 14;
        }
        else if (GameplayLoop == 14 && Countdown == 0f)
        {
            Highscores.SetActive(true);
            Gameplay1.SetActive(false);
            Gameplay2.SetActive(false);
            Gameplay3.SetActive(false);
            Gameplay4.SetActive(false);
            Gameplay5.SetActive(false);
            Titlescreen.SetActive(false);
            GameplayLoop = 0;
        }
    }
    private IEnumerator Cycle()
    {
        yield return new WaitForSeconds(Countdown);
        Debug.Log("Countdown is 0");
            InCountdown = InGameplayTime;

    }
    private IEnumerator InCycle()
    {
        yield return new WaitForSeconds(InCountdown);
        Debug.Log("InCountdown is 0");
            Countdown = GameplayTime;
            StartCoroutine(Cycle());
    }
}
