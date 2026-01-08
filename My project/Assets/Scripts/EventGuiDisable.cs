using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EventGuiDisable : MonoBehaviour {
	public GameObject Enable_Disable;
    int hasbeenactivated;

    //public void not_Enable() {
    //	if (PlayerPrefs.GetInt ("Disable") == 1) 
    //		{
    //			Destroy (Enable_Disable);
    //		}
    //	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            Enable_Disable.SetActive(true);
            //hasbeenactivated = 1;
        }
    }
        private void OnCollisionExit2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Border"))
        {
            //Enable_Disable.SetActive(true);
        }
    }
    //	public void SaveLevel(int id)
    //	{
    //		PlayerPrefs.SetInt ("level", id);
    //	}
}