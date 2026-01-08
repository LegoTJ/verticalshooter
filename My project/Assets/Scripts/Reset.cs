using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{

    public Button Resting;
    public bool ResetGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ResetGame == true)
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
