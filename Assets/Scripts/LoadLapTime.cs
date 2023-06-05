using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float MilliSecCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliSecDisplay;

    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliSecCount = PlayerPrefs.GetFloat("MilliSecSave");

        MinDisplay.GetComponent<Text>().text = "" + MinCount + ".";
        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";
        MilliSecDisplay.GetComponent<Text>().text = "" + MilliSecCount;
    }

    
}
