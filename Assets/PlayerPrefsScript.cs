using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerPrefsScript : MonoBehaviour
{



    public TextMeshProUGUI textValue;



//--------------------------------------------------------------------------

    //Save Data

    public void SaveData100()
    {
        PlayerPrefs.SetInt("HighScore", 100);
    }



    public void SaveData200()
    {
        PlayerPrefs.SetInt("HighScore", 200);
    }



    public void SaveData300()
    {
        PlayerPrefs.SetInt("HighScore", 300);
    }



    
//--------------------------------------------------------------------------

    //Load Data


    public void Update()
    {
        textValue.text = PlayerPrefs.GetInt("HighScore").ToString();
    }


//--------------------------------------------------------------------------

    //Delete Data

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }

}
