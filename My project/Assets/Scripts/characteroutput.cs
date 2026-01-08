using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class characteroutput : MonoBehaviour
{
    public TextMeshProUGUI Digits1;
    public TextMeshProUGUI Digits2;
    public TextMeshProUGUI Digits3;
    public TextMeshProUGUI Digits4;
    public TextMeshProUGUI Digits5;
    public TextMeshProUGUI Digits6;
    public TextMeshProUGUI Digits7;
    public TextMeshProUGUI Digits8;
    public TextMeshProUGUI Digits9;
    public TextMeshProUGUI Digits10;
    //public TextMeshProUGUI Digit2;
    //public TextMeshProUGUI Digit3;
    public string Digit1;
    public string Digit2;
    public string Digit3;
    public string Digit4;
    public string Digit5;
    public string Digit6;
    public string Digit7;
    public string Digit8;
    public string Digit9;
    public string Digit10;
    public string Digit11;
    public string Digit12;
    public string Digit13;
    public string Digit14;
    public string Digit15;
    public string Digit16;
    public string Digit17;
    public string Digit18;
    public string Digit19;
    public string Digit20;
    public string Digit21;
    public string Digit22;
    public string Digit23;
    public string Digit24;
    public string Digit25;
    public string Digit26;
    public string Digit27;
    public string Digit28;
    public string Digit29;
    public string Digit30;


    public int ActiveDigit;
    public int D1DigitValue1;
    public int D1DigitValue2;
    public int D1DigitValue3; 
    public int D2DigitValue1;
    public int D2DigitValue2;
    public int D2DigitValue3;
    public int D3DigitValue1;
    public int D3DigitValue2;
    public int D3DigitValue3;
    public int D4DigitValue1;
    public int D4DigitValue2;
    public int D4DigitValue3; 
    public int D5DigitValue1;
    public int D5DigitValue2;
    public int D5DigitValue3;
    public int D6DigitValue1;
    public int D6DigitValue2;
    public int D6DigitValue3;
    public int D7DigitValue1;
    public int D7DigitValue2;
    public int D7DigitValue3; 
    public int D8DigitValue1;
    public int D8DigitValue2;
    public int D8DigitValue3;
    public int D9DigitValue1;
    public int D9DigitValue2;
    public int D9DigitValue3;
    public int D10DigitValue1;
    public int D10DigitValue2;
    public int D10DigitValue3;

    private readonly string[] letterList = { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "?", "!", ".", "-" };
    // Start is called before the first frame update
    void Start()
    {
        ActiveDigit = 0;
        D1DigitValue1 = PlayerPrefs.GetInt("D1DigitValue1");
        D1DigitValue2 = PlayerPrefs.GetInt("D1DigitValue2");
        D1DigitValue3 = PlayerPrefs.GetInt("D1DigitValue3");
        D2DigitValue1 = PlayerPrefs.GetInt("D2DigitValue1");
        D2DigitValue2 = PlayerPrefs.GetInt("D2DigitValue2");
        D2DigitValue3 = PlayerPrefs.GetInt("D2DigitValue3");
        D3DigitValue1 = PlayerPrefs.GetInt("D3DigitValue1");
        D3DigitValue2 = PlayerPrefs.GetInt("D3DigitValue2");
        D3DigitValue3 = PlayerPrefs.GetInt("D3DigitValue3");
        D4DigitValue1 = PlayerPrefs.GetInt("D4DigitValue1");
        D4DigitValue2 = PlayerPrefs.GetInt("D4DigitValue2");
        D4DigitValue3 = PlayerPrefs.GetInt("D4DigitValue3");
        D5DigitValue1 = PlayerPrefs.GetInt("D5DigitValue1");
        D5DigitValue2 = PlayerPrefs.GetInt("D5DigitValue2");
        D5DigitValue3 = PlayerPrefs.GetInt("D5DigitValue3");
        D6DigitValue1 = PlayerPrefs.GetInt("D6DigitValue1");
        D6DigitValue2 = PlayerPrefs.GetInt("D6DigitValue2");
        D6DigitValue3 = PlayerPrefs.GetInt("D6DigitValue3");
        D7DigitValue1 = PlayerPrefs.GetInt("D7DigitValue1");
        D7DigitValue2 = PlayerPrefs.GetInt("D7DigitValue2");
        D7DigitValue3 = PlayerPrefs.GetInt("D7DigitValue3");
        D8DigitValue1 = PlayerPrefs.GetInt("D8DigitValue1");
        D8DigitValue2 = PlayerPrefs.GetInt("D8DigitValue2");
        D8DigitValue3 = PlayerPrefs.GetInt("D8DigitValue3");
        D9DigitValue1 = PlayerPrefs.GetInt("D9DigitValue1");
        D9DigitValue2 = PlayerPrefs.GetInt("D9DigitValue2");
        D9DigitValue3 = PlayerPrefs.GetInt("D9DigitValue3");
        D10DigitValue1 = PlayerPrefs.GetInt("D10DigitValue1");
        D10DigitValue2 = PlayerPrefs.GetInt("D10DigitValue2");
        D10DigitValue3 = PlayerPrefs.GetInt("D10DigitValue3");
        Digit1 = letterList[D1DigitValue1];
        Digit2 = letterList[D1DigitValue2];
        Digit3 = letterList[D1DigitValue3];
        Digit4 = letterList[D2DigitValue1];
        Digit5 = letterList[D2DigitValue2];
        Digit6 = letterList[D2DigitValue3];
        Digit7 = letterList[D3DigitValue1];
        Digit8 = letterList[D3DigitValue2];
        Digit9 = letterList[D3DigitValue3];
        Digit10 = letterList[D4DigitValue1];
        Digit11 = letterList[D4DigitValue2];
        Digit12 = letterList[D4DigitValue3];
        Digit13 = letterList[D5DigitValue1];
        Digit14 = letterList[D5DigitValue2];
        Digit15 = letterList[D5DigitValue3];
        Digit16 = letterList[D6DigitValue1];
        Digit17 = letterList[D6DigitValue2];
        Digit18 = letterList[D6DigitValue3];
        Digit19 = letterList[D7DigitValue1];
        Digit20 = letterList[D7DigitValue2];
        Digit21 = letterList[D7DigitValue3];
        Digit22 = letterList[D8DigitValue1];
        Digit23 = letterList[D8DigitValue2];
        Digit24 = letterList[D8DigitValue3];
        Digit25 = letterList[D9DigitValue1];
        Digit26 = letterList[D9DigitValue2];
        Digit27 = letterList[D9DigitValue3];
        Digit28 = letterList[D10DigitValue1];
        Digit29 = letterList[D10DigitValue2];
        Digit30 = letterList[D10DigitValue3];
    }

    // Update is called once per frame
    void Update()
    {
        D1DigitValue1 = PlayerPrefs.GetInt("D1DigitValue1");
        D1DigitValue2 = PlayerPrefs.GetInt("D1DigitValue2");
        D1DigitValue3 = PlayerPrefs.GetInt("D1DigitValue3");
        D2DigitValue1 = PlayerPrefs.GetInt("D2DigitValue1");
        D2DigitValue2 = PlayerPrefs.GetInt("D2DigitValue2");
        D2DigitValue3 = PlayerPrefs.GetInt("D2DigitValue3");
        D3DigitValue1 = PlayerPrefs.GetInt("D3DigitValue1");
        D3DigitValue2 = PlayerPrefs.GetInt("D3DigitValue2");
        D3DigitValue3 = PlayerPrefs.GetInt("D3DigitValue3");
        D4DigitValue1 = PlayerPrefs.GetInt("D4DigitValue1");
        D4DigitValue2 = PlayerPrefs.GetInt("D4DigitValue2");
        D4DigitValue3 = PlayerPrefs.GetInt("D4DigitValue3");
        D5DigitValue1 = PlayerPrefs.GetInt("D5DigitValue1");
        D5DigitValue2 = PlayerPrefs.GetInt("D5DigitValue2");
        D5DigitValue3 = PlayerPrefs.GetInt("D5DigitValue3");
        D6DigitValue1 = PlayerPrefs.GetInt("D6DigitValue1");
        D6DigitValue2 = PlayerPrefs.GetInt("D6DigitValue2");
        D6DigitValue3 = PlayerPrefs.GetInt("D6DigitValue3");
        D7DigitValue1 = PlayerPrefs.GetInt("D7DigitValue1");
        D7DigitValue2 = PlayerPrefs.GetInt("D7DigitValue2");
        D7DigitValue3 = PlayerPrefs.GetInt("D7DigitValue3");
        D8DigitValue1 = PlayerPrefs.GetInt("D8DigitValue1");
        D8DigitValue2 = PlayerPrefs.GetInt("D8DigitValue2");
        D8DigitValue3 = PlayerPrefs.GetInt("D8DigitValue3");
        D9DigitValue1 = PlayerPrefs.GetInt("D9DigitValue1");
        D9DigitValue2 = PlayerPrefs.GetInt("D9DigitValue2");
        D9DigitValue3 = PlayerPrefs.GetInt("D9DigitValue3");
        D10DigitValue1 = PlayerPrefs.GetInt("D10DigitValue1");
        D10DigitValue2 = PlayerPrefs.GetInt("D10DigitValue2");
        D10DigitValue3 = PlayerPrefs.GetInt("D10DigitValue3");
        Digit1 = letterList[D1DigitValue1];
        Digit2 = letterList[D1DigitValue2];
        Digit3 = letterList[D1DigitValue3];
        Digit4 = letterList[D2DigitValue1];
        Digit5 = letterList[D2DigitValue2];
        Digit6 = letterList[D2DigitValue3];
        Digit7 = letterList[D3DigitValue1];
        Digit8 = letterList[D3DigitValue2];
        Digit9 = letterList[D3DigitValue3];
        Digit10 = letterList[D4DigitValue1];
        Digit11 = letterList[D4DigitValue2];
        Digit12 = letterList[D4DigitValue3];
        Digit13 = letterList[D5DigitValue1];
        Digit14 = letterList[D5DigitValue2];
        Digit15 = letterList[D5DigitValue3];
        Digit16 = letterList[D6DigitValue1];
        Digit17 = letterList[D6DigitValue2];
        Digit18 = letterList[D6DigitValue3];
        Digit19 = letterList[D7DigitValue1];
        Digit20 = letterList[D7DigitValue2];
        Digit21 = letterList[D7DigitValue3];
        Digit22 = letterList[D8DigitValue1];
        Digit23 = letterList[D8DigitValue2];
        Digit24 = letterList[D8DigitValue3];
        Digit25 = letterList[D9DigitValue1];
        Digit26 = letterList[D9DigitValue2];
        Digit27 = letterList[D9DigitValue3];
        Digit28 = letterList[D10DigitValue1];
        Digit29 = letterList[D10DigitValue2];
        Digit30 = letterList[D10DigitValue3];
        Digits1.text = Digit1.ToString() + Digit2.ToString() + Digit3.ToString();
        Digits2.text = Digit4.ToString() + Digit5.ToString() + Digit6.ToString();
        Digits3.text = Digit7.ToString() + Digit8.ToString() + Digit9.ToString();
        Digits4.text = Digit10.ToString() + Digit11.ToString() + Digit12.ToString();
        Digits5.text = Digit13.ToString() + Digit14.ToString() + Digit15.ToString();
        Digits6.text = Digit16.ToString() + Digit17.ToString() + Digit18.ToString();
        Digits7.text = Digit19.ToString() + Digit20.ToString() + Digit21.ToString();
        Digits8.text = Digit22.ToString() + Digit23.ToString() + Digit24.ToString();
        Digits9.text = Digit25.ToString() + Digit26.ToString() + Digit27.ToString();
        Digits10.text = Digit28.ToString() + Digit29.ToString() + Digit30.ToString();
    /*    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpdateDigitValue(1);
            UpdateActiveDigit();
                //Debug.Log($"Digit Value: {DigitValue} ({letterList[DigitValue -1]})");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            UpdateDigitValue(-1);
            UpdateActiveDigit();
            // Debug.Log($"Digit Value: {DigitValue} ({letterList[DigitValue -1]})");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActiveDigit--;
            if (ActiveDigit < 0) ActiveDigit = 0;
            Debug.Log($"Active Digit: {ActiveDigit}");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActiveDigit++;
            if (ActiveDigit > 3) ActiveDigit = 3;
            Debug.Log($"Active Digit: {ActiveDigit}");
        }*/


    }
    /*private void SyncDigitValues()
    {
        DigitValue1 = GetIndexFromValue(Digit1);
        DigitValue2 = GetIndexFromValue(Digit2);
        DigitValue3 = GetIndexFromValue(Digit3);
    }

    private int GetIndexFromValue(string val)
    {
        int index = System.Array.IndexOf(letterList, val);
        if(index >= 0)
        {
            return index;
        }else
        {
            return 1;
        }
    }*/
    /*private void UpdateAllDigits()
    {
        Digit1 = letterList[D1DigitValue1];
        Digit2 = letterList[D1DigitValue2];
        Digit3 = letterList[D1DigitValue3];
        Digit4 = letterList[D2DigitValue1];
        Digit5 = letterList[D2DigitValue2];
        Digit6 = letterList[D2DigitValue3];
        Digit7 = letterList[D3DigitValue1];
        Digit8 = letterList[D3DigitValue2];
        Digit9 = letterList[D3DigitValue3];
        Digit10 = letterList[D4DigitValue1];
        Digit11 = letterList[D4DigitValue2];
        Digit12 = letterList[D4DigitValue3];
        Digit13 = letterList[D5DigitValue1];
        Digit14 = letterList[D5DigitValue2];
        Digit15 = letterList[D5DigitValue3];
        Digit16 = letterList[D6DigitValue1];
        Digit17 = letterList[D6DigitValue2];
        Digit18 = letterList[D6DigitValue3];
        Digit19 = letterList[D7DigitValue1];
        Digit20 = letterList[D7DigitValue2];
        Digit21 = letterList[D7DigitValue3];
        Digit22 = letterList[D8DigitValue1];
        Digit23 = letterList[D8DigitValue2];
        Digit24 = letterList[D8DigitValue3];
        Digit25 = letterList[D9DigitValue1];
        Digit26 = letterList[D9DigitValue2];
        Digit27 = letterList[D9DigitValue3];
        Digit28 = letterList[D10DigitValue1];
        Digit29 = letterList[D10DigitValue2];
        Digit30 = letterList[D10DigitValue3];
    }*/
    /*private int GetCurrentDigitValue()
    {
        switch (ActiveDigit)
        {
            case 0: return DigitValue1;
            case 1: return DigitValue2;
            case 2: return DigitValue3;
            case 3: return 0;
            default: Debug.LogError("Invalid Active Digit"); return 0;
        }
    }
    private void UpdateDigitValue(int direction)
    {
        if (ActiveDigit > 2) return;
        int newValue;
        switch (ActiveDigit)
        {
            case 0: newValue = DigitValue1 + direction; DigitValue1 = newValue > 40 ? 0 : newValue < 0 ? 40 : newValue; break;
            case 1: newValue = DigitValue2 + direction; DigitValue2 = newValue > 40 ? 0 : newValue < 0 ? 40 : newValue; break;
            case 2: newValue = DigitValue3 + direction; DigitValue3 = newValue > 40 ? 0 : newValue < 0 ? 40 : newValue; break;
            default: Debug.LogError("Invalid Active Digit"); return;
        }
    }
    void UpdateActiveDigit()
    {
        if(ActiveDigit <0 || ActiveDigit > 3)
        {
            Debug.LogError($"Invalid ActiveDigit: {ActiveDigit}.Length Must be 1, 2, or 3.");
                return;
        }
        int currentValue = GetCurrentDigitValue();

        if (currentValue < 0 || currentValue > 40)
        {
            Debug.LogError($"Invalid ActiveDigit: {ActiveDigit}.Length Must be 1 and 36.");
            return;
        }

        string newValue = letterList[currentValue];

        switch (ActiveDigit)
        {
            case 0:
                Digit1 = newValue;
                break;
            case 1:
                Digit2 = newValue;
                break;
            case 2:
                Digit3 = newValue;
                break;

        } */

}
