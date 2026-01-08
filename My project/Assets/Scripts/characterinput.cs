using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class characterinput : MonoBehaviour
{
    public TextMeshProUGUI Digits1;
    //public TextMeshProUGUI Digit2;
    //public TextMeshProUGUI Digit3;
    public string Digit1;
    public string Digit2;
    public string Digit3;
    public string Digit4;
    public int ActiveDigit;
    public int DigitValue1;
    public int DigitValue2;
    public int DigitValue3;
    public GameObject menu;
    public GameObject name1;
    public GameObject name2;
    public GameObject name3;
    public GameObject name4;
    public GameObject name5;
    public GameObject name6;
    public GameObject name7;
    public GameObject name8;
    public GameObject name9;
    public GameObject name10;
    private readonly string[] letterList = { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "?", "!", ".", "-" };
// Start is called before the first frame update
void Start()
    {
        ActiveDigit = 0;
        DigitValue1 = 1;
        DigitValue2 = 1;
        DigitValue3 = 1;
        Digit1 = letterList[DigitValue1];
        Digit2 = letterList[DigitValue2];
        Digit3 = letterList[DigitValue3];
    }

    // Update is called once per frame
    void Update()
    {
    
        Digits1.text = Digit1.ToString() + Digit2.ToString() + Digit3.ToString();
        if (Input.GetKeyDown(KeyCode.UpArrow))
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
            if (ActiveDigit > 4) ActiveDigit = 4;
            Debug.Log($"Active Digit: {ActiveDigit}");
        }
        if (ActiveDigit == 4)
        {
            Debug.Log("Active Digit Statement Worked");
            if (name1.activeSelf)
            {
                PlayerPrefs.SetInt("D1DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D1DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D1DigitValue3", DigitValue3);
                menu.SetActive(true);
                name1.SetActive(false);
                Debug.Log("Active Check Worked");
            }
            if (name2.activeSelf)
            {
                PlayerPrefs.SetInt("D2DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D2DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D2DigitValue3", DigitValue3);
                menu.SetActive(true);
                name2.SetActive(false);
            }
            if (name3.activeSelf)
            {
                PlayerPrefs.SetInt("D3DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D3DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D3DigitValue3", DigitValue3);
                menu.SetActive(true);
                name3.SetActive(false);
            }
            if (name4.activeSelf)
            {
                PlayerPrefs.SetInt("D4DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D4DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D4DigitValue3", DigitValue3);
                menu.SetActive(true);
                name4.SetActive(false);
            }
            if (name5.activeSelf)
            {
                PlayerPrefs.SetInt("D5DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D5DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D5DigitValue3", DigitValue3);
                menu.SetActive(true);
                name5.SetActive(false);
            }
            if (name6.activeSelf)
            {
                PlayerPrefs.SetInt("D6DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D6DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D6DigitValue3", DigitValue3);
                menu.SetActive(true);
                name6.SetActive(false);
            }
            if (name7.activeSelf)
            {
                PlayerPrefs.SetInt("D7DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D7DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D7DigitValue3", DigitValue3);
                menu.SetActive(true);
                name7.SetActive(false);
            }
            if (name8.activeSelf)
            {
                PlayerPrefs.SetInt("D8DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D8DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D8DigitValue3", DigitValue3);
                menu.SetActive(true);
                name8.SetActive(false);
            }
            if (name9.activeSelf)
            {
                PlayerPrefs.SetInt("D9DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D9DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D9DigitValue3", DigitValue3);
                menu.SetActive(true);
                name9.SetActive(false);
            }
            if (name10.activeSelf)
            {
                PlayerPrefs.SetInt("D10DigitValue1", DigitValue1);
                PlayerPrefs.SetInt("D10DigitValue2", DigitValue2);
                PlayerPrefs.SetInt("D10DigitValue3", DigitValue3);
                menu.SetActive(true);
                name10.SetActive(false);
            }
        }

    }
    private void SyncDigitValues()
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
    }
    private void UpdateAllDigits()
    {
        Digit1 = letterList[DigitValue1];
        Digit2 = letterList[DigitValue2];
        Digit3 = letterList[DigitValue3];
    }
    private int GetCurrentDigitValue()
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
        if(ActiveDigit <0 || ActiveDigit > 4)
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

        }
    }
}
