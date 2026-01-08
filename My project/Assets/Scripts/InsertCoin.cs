using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class InsertCoin : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public int coins;
    public GameObject insertcoins;
    public GameObject startgame;
    public int requiredcoinstoplay;
    public GameObject newgame;
    public GameObject menu;
    public GameObject titlescreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = coins.ToString();
        if (Input.GetKeyDown(KeyCode.C))
        {
            coins = coins + 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coins >= requiredcoinstoplay)
            {
                coins = coins - requiredcoinstoplay;
                newgame.SetActive(true);
                titlescreen.SetActive(false);
                menu.SetActive(false);
            }
        }
        if(coins  >= requiredcoinstoplay)
        {
            startgame.SetActive(true);
            insertcoins.SetActive(false);
        } else
        {
            startgame.SetActive(false);
            insertcoins.SetActive(true);
        }
    }
}
