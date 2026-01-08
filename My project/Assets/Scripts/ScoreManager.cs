using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static int highScores;
    public static int highScores1;
    public static int highScores2;
    public static int highScores3;
    public static int highScores4;
    public static int highScores5;
    public static int highScores6;
    public static int highScores7;
    public static int highScores8;
    public static int highScores9;
    public static int highScores10;
    public static bool GameOver;
    public GameObject Menu;
    public TextMeshProUGUI scored;
    public TextMeshProUGUI highScore;
    public GameObject Typeface1;
    public GameObject Typeface2;
    public GameObject Typeface3;
    public GameObject Typeface4;
    public GameObject Typeface5;
    public GameObject Typeface6;
    public GameObject Typeface7;
    public GameObject Typeface8;
    public GameObject Typeface9;
    public GameObject Typeface10;
    void Start()
    {
        //text = GetComponent<TextMeshProUGUI>();
        score = 0;
		highScores = PlayerPrefs.GetInt("highScore1");
        /*if (highScores <= 0)
        {
            highScores = 10000;
        }*/
        highScores1 = PlayerPrefs.GetInt("highScore1");
        highScores2 = PlayerPrefs.GetInt("highScore2");
        highScores3 = PlayerPrefs.GetInt("highScore3");
        highScores4 = PlayerPrefs.GetInt("highScore4");
        highScores5 = PlayerPrefs.GetInt("highScore5");
        highScores6 = PlayerPrefs.GetInt("highScore6");
        highScores7 = PlayerPrefs.GetInt("highScore7");
        highScores8 = PlayerPrefs.GetInt("highScore8");
        highScores9 = PlayerPrefs.GetInt("highScore9");
        highScores10 = PlayerPrefs.GetInt("highScore10");
    }

    void Update()
    {
        highScores = PlayerPrefs.GetInt("highScore1");
        highScores1 = PlayerPrefs.GetInt("highScore1");
        highScores2 = PlayerPrefs.GetInt("highScore2");
        highScores3 = PlayerPrefs.GetInt("highScore3");
        highScores4 = PlayerPrefs.GetInt("highScore4");
        highScores5 = PlayerPrefs.GetInt("highScore5");
        highScores6 = PlayerPrefs.GetInt("highScore6");
        highScores7 = PlayerPrefs.GetInt("highScore7");
        highScores8 = PlayerPrefs.GetInt("highScore8");
        highScores9 = PlayerPrefs.GetInt("highScore9");
        highScores10 = PlayerPrefs.GetInt("highScore10");
        if (GameOver == true)
        {
            Menu.SetActive(true);
        }
        if (score < 999990)
        {
            scored.text = score.ToString();
        }
        if (score < 999990 && score >= 0 && highScores <= score)
        {
            highScore.text = "" + score.ToString();
        }

        if (score >= 999990)
        {
            scored.text = "999990";
        }
        /*if (score < 999990 && score <= highScores)
        {
            //highScore.text = "10000";
            highScore.text = "" + highScores.ToString();
        }*/
        if (score < 999990 && score >= 0 && score <= highScores)
        {
            highScore.text = "" + highScores.ToString();
        }
        if(GameOver == true && highScores1 <= score)
        {
            /*highScores9 = highScores10;
            highScores8 = highScores9;
            highScores7 = highScores8;
            highScores6 = highScores7;
            highScores5 = highScores6;
            highScores4 = highScores5;
            highScores3 = highScores4;
            highScores2 = highScores3;
            highScores1 = highScores2;*/
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", highScores6);
            PlayerPrefs.SetInt("highScore6", highScores5);
            PlayerPrefs.SetInt("highScore5", highScores4);
            PlayerPrefs.SetInt("highScore4", highScores3);
            PlayerPrefs.SetInt("highScore3", highScores2);
            PlayerPrefs.SetInt("highScore2", highScores1);
            PlayerPrefs.SetInt("highScore1", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            PlayerPrefs.SetInt("D7DigitValue1", PlayerPrefs.GetInt("D6DigitValue1"));
            PlayerPrefs.SetInt("D7DigitValue2", PlayerPrefs.GetInt("D6DigitValue2"));
            PlayerPrefs.SetInt("D7DigitValue3", PlayerPrefs.GetInt("D6DigitValue3"));
            PlayerPrefs.SetInt("D6DigitValue1", PlayerPrefs.GetInt("D5DigitValue1"));
            PlayerPrefs.SetInt("D6DigitValue2", PlayerPrefs.GetInt("D5DigitValue2"));
            PlayerPrefs.SetInt("D6DigitValue3", PlayerPrefs.GetInt("D5DigitValue3"));
            PlayerPrefs.SetInt("D5DigitValue1", PlayerPrefs.GetInt("D4DigitValue1"));
            PlayerPrefs.SetInt("D5DigitValue2", PlayerPrefs.GetInt("D4DigitValue2"));
            PlayerPrefs.SetInt("D5DigitValue3", PlayerPrefs.GetInt("D4DigitValue3"));
            PlayerPrefs.SetInt("D4DigitValue1", PlayerPrefs.GetInt("D3DigitValue1"));
            PlayerPrefs.SetInt("D4DigitValue2", PlayerPrefs.GetInt("D3DigitValue2"));
            PlayerPrefs.SetInt("D4DigitValue3", PlayerPrefs.GetInt("D3DigitValue3"));
            PlayerPrefs.SetInt("D3DigitValue1", PlayerPrefs.GetInt("D2DigitValue1"));
            PlayerPrefs.SetInt("D3DigitValue2", PlayerPrefs.GetInt("D2DigitValue2"));
            PlayerPrefs.SetInt("D3DigitValue3", PlayerPrefs.GetInt("D2DigitValue3"));
            PlayerPrefs.SetInt("D2DigitValue1", PlayerPrefs.GetInt("D1DigitValue1"));
            PlayerPrefs.SetInt("D2DigitValue2", PlayerPrefs.GetInt("D1DigitValue2"));
            PlayerPrefs.SetInt("D2DigitValue3", PlayerPrefs.GetInt("D1DigitValue3"));

            Typeface1.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores2 <= score) {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", highScores6);
            PlayerPrefs.SetInt("highScore6", highScores5);
            PlayerPrefs.SetInt("highScore5", highScores4);
            PlayerPrefs.SetInt("highScore4", highScores3);
            PlayerPrefs.SetInt("highScore3", highScores2);
            PlayerPrefs.SetInt("highScore2", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            PlayerPrefs.SetInt("D7DigitValue1", PlayerPrefs.GetInt("D6DigitValue1"));
            PlayerPrefs.SetInt("D7DigitValue2", PlayerPrefs.GetInt("D6DigitValue2"));
            PlayerPrefs.SetInt("D7DigitValue3", PlayerPrefs.GetInt("D6DigitValue3"));
            PlayerPrefs.SetInt("D6DigitValue1", PlayerPrefs.GetInt("D5DigitValue1"));
            PlayerPrefs.SetInt("D6DigitValue2", PlayerPrefs.GetInt("D5DigitValue2"));
            PlayerPrefs.SetInt("D6DigitValue3", PlayerPrefs.GetInt("D5DigitValue3"));
            PlayerPrefs.SetInt("D5DigitValue1", PlayerPrefs.GetInt("D4DigitValue1"));
            PlayerPrefs.SetInt("D5DigitValue2", PlayerPrefs.GetInt("D4DigitValue2"));
            PlayerPrefs.SetInt("D5DigitValue3", PlayerPrefs.GetInt("D4DigitValue3"));
            PlayerPrefs.SetInt("D4DigitValue1", PlayerPrefs.GetInt("D3DigitValue1"));
            PlayerPrefs.SetInt("D4DigitValue2", PlayerPrefs.GetInt("D3DigitValue2"));
            PlayerPrefs.SetInt("D4DigitValue3", PlayerPrefs.GetInt("D3DigitValue3"));
            PlayerPrefs.SetInt("D3DigitValue1", PlayerPrefs.GetInt("D2DigitValue1"));
            PlayerPrefs.SetInt("D3DigitValue2", PlayerPrefs.GetInt("D2DigitValue2"));
            PlayerPrefs.SetInt("D3DigitValue3", PlayerPrefs.GetInt("D2DigitValue3"));
            Typeface2.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores3 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", highScores6);
            PlayerPrefs.SetInt("highScore6", highScores5);
            PlayerPrefs.SetInt("highScore5", highScores4);
            PlayerPrefs.SetInt("highScore4", highScores3);
            PlayerPrefs.SetInt("highScore3", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            PlayerPrefs.SetInt("D7DigitValue1", PlayerPrefs.GetInt("D6DigitValue1"));
            PlayerPrefs.SetInt("D7DigitValue2", PlayerPrefs.GetInt("D6DigitValue2"));
            PlayerPrefs.SetInt("D7DigitValue3", PlayerPrefs.GetInt("D6DigitValue3"));
            PlayerPrefs.SetInt("D6DigitValue1", PlayerPrefs.GetInt("D5DigitValue1"));
            PlayerPrefs.SetInt("D6DigitValue2", PlayerPrefs.GetInt("D5DigitValue2"));
            PlayerPrefs.SetInt("D6DigitValue3", PlayerPrefs.GetInt("D5DigitValue3"));
            PlayerPrefs.SetInt("D5DigitValue1", PlayerPrefs.GetInt("D4DigitValue1"));
            PlayerPrefs.SetInt("D5DigitValue2", PlayerPrefs.GetInt("D4DigitValue2"));
            PlayerPrefs.SetInt("D5DigitValue3", PlayerPrefs.GetInt("D4DigitValue3"));
            PlayerPrefs.SetInt("D4DigitValue1", PlayerPrefs.GetInt("D3DigitValue1"));
            PlayerPrefs.SetInt("D4DigitValue2", PlayerPrefs.GetInt("D3DigitValue2"));
            PlayerPrefs.SetInt("D4DigitValue3", PlayerPrefs.GetInt("D3DigitValue3"));
            Typeface3.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores4 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", highScores6);
            PlayerPrefs.SetInt("highScore6", highScores5);
            PlayerPrefs.SetInt("highScore5", highScores4);
            PlayerPrefs.SetInt("highScore4", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            PlayerPrefs.SetInt("D7DigitValue1", PlayerPrefs.GetInt("D6DigitValue1"));
            PlayerPrefs.SetInt("D7DigitValue2", PlayerPrefs.GetInt("D6DigitValue2"));
            PlayerPrefs.SetInt("D7DigitValue3", PlayerPrefs.GetInt("D6DigitValue3"));
            PlayerPrefs.SetInt("D6DigitValue1", PlayerPrefs.GetInt("D5DigitValue1"));
            PlayerPrefs.SetInt("D6DigitValue2", PlayerPrefs.GetInt("D5DigitValue2"));
            PlayerPrefs.SetInt("D6DigitValue3", PlayerPrefs.GetInt("D5DigitValue3"));
            PlayerPrefs.SetInt("D5DigitValue1", PlayerPrefs.GetInt("D4DigitValue1"));
            PlayerPrefs.SetInt("D5DigitValue2", PlayerPrefs.GetInt("D4DigitValue2"));
            PlayerPrefs.SetInt("D5DigitValue3", PlayerPrefs.GetInt("D4DigitValue3"));
            Typeface4.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores5 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", highScores6);
            PlayerPrefs.SetInt("highScore6", highScores5);
            PlayerPrefs.SetInt("highScore5", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            PlayerPrefs.SetInt("D7DigitValue1", PlayerPrefs.GetInt("D6DigitValue1"));
            PlayerPrefs.SetInt("D7DigitValue2", PlayerPrefs.GetInt("D6DigitValue2"));
            PlayerPrefs.SetInt("D7DigitValue3", PlayerPrefs.GetInt("D6DigitValue3"));
            PlayerPrefs.SetInt("D6DigitValue1", PlayerPrefs.GetInt("D5DigitValue1"));
            PlayerPrefs.SetInt("D6DigitValue2", PlayerPrefs.GetInt("D5DigitValue2"));
            PlayerPrefs.SetInt("D6DigitValue3", PlayerPrefs.GetInt("D5DigitValue3"));
            Typeface5.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores6 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", highScores6);
            PlayerPrefs.SetInt("highScore6", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            PlayerPrefs.SetInt("D7DigitValue1", PlayerPrefs.GetInt("D6DigitValue1"));
            PlayerPrefs.SetInt("D7DigitValue2", PlayerPrefs.GetInt("D6DigitValue2"));
            PlayerPrefs.SetInt("D7DigitValue3", PlayerPrefs.GetInt("D6DigitValue3"));
            Typeface6.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores7 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", highScores7);
            PlayerPrefs.SetInt("highScore7", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            PlayerPrefs.SetInt("D8DigitValue1", PlayerPrefs.GetInt("D7DigitValue1"));
            PlayerPrefs.SetInt("D8DigitValue2", PlayerPrefs.GetInt("D7DigitValue2"));
            PlayerPrefs.SetInt("D8DigitValue3", PlayerPrefs.GetInt("D7DigitValue3"));
            Typeface7.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores8 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", highScores8);
            PlayerPrefs.SetInt("highScore8", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            PlayerPrefs.SetInt("D9DigitValue1", PlayerPrefs.GetInt("D8DigitValue1"));
            PlayerPrefs.SetInt("D9DigitValue2", PlayerPrefs.GetInt("D8DigitValue2"));
            PlayerPrefs.SetInt("D9DigitValue3", PlayerPrefs.GetInt("D8DigitValue3"));
            Typeface8.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores9 <= score)
        {
            PlayerPrefs.SetInt("highScore10", highScores9);
            PlayerPrefs.SetInt("highScore9", score);
            PlayerPrefs.SetInt("D10DigitValue1", PlayerPrefs.GetInt("D9DigitValue1"));
            PlayerPrefs.SetInt("D10DigitValue2", PlayerPrefs.GetInt("D9DigitValue2"));
            PlayerPrefs.SetInt("D10DigitValue3", PlayerPrefs.GetInt("D9DigitValue3"));
            Typeface9.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores10 <= score)
        {
            PlayerPrefs.SetInt("highScore10", score);
            Typeface10.SetActive(true);
            GameOver = false;
        }
        else if (GameOver == true && highScores10 >= score)
        {
            GameOver = false;
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
		//PlayerPrefs.SetInt ("CurrentScore", score);
    }
	public static void SubtractPoints(int pointsToSubtract)
	{
		score -= pointsToSubtract;
		//PlayerPrefs.SetInt ("CurrentScore", score);
	}
    public static void Reset()
    {
        score = 0;
		//PlayerPrefs.SetInt ("CurrentScore", score);
    }
}