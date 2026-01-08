using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highscores : MonoBehaviour
{
    public static int highScores1;
    public TextMeshProUGUI highscore1;
    public TextMeshProUGUI name1;
    public static int highScores2;
    public TextMeshProUGUI highscore2;
    public TextMeshProUGUI name2;
    public static int highScores3;
    public TextMeshProUGUI highscore3;
    public TextMeshProUGUI name3;
    public static int highScores4;
    public TextMeshProUGUI highscore4;
    public TextMeshProUGUI name4;
    public static int highScores5;
    public TextMeshProUGUI highscore5;
    public TextMeshProUGUI name5;
    public static int highScores6;
    public TextMeshProUGUI highscore6;
    public TextMeshProUGUI name6;
    public static int highScores7;
    public TextMeshProUGUI highscore7;
    public TextMeshProUGUI name7;
    public static int highScores8;
    public TextMeshProUGUI highscore8;
    public TextMeshProUGUI name8;
    public static int highScores9;
    public TextMeshProUGUI highscore9;
    public TextMeshProUGUI name9;
    public static int highScores10;
    public TextMeshProUGUI highscore10;
    public TextMeshProUGUI name10;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreManager.Score;
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

    // Update is called once per frame
    void Update()
    {
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
        highscore1.text = highScores1.ToString();
        highscore2.text = highScores2.ToString();
        highscore3.text = highScores3.ToString();
        highscore4.text = highScores4.ToString();
        highscore5.text = highScores5.ToString();
        highscore6.text = highScores6.ToString();
        highscore7.text = highScores7.ToString();
        highscore8.text = highScores8.ToString(); 
        highscore9.text = highScores9.ToString();
        highscore10.text = highScores10.ToString();


    }
}
