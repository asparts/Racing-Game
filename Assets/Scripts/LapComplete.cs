using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject LapHalfTrig;

    public GameObject BestMinuteBox;
    public GameObject BestSecondBox;
    public GameObject BestMilliSecondBox;

    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public GameObject RaceFinish;
    public int laps = 0;
    public int maxLaps = 2;

    public float RawTime;

    private void Update()
    {
        if (laps == maxLaps)
        {
            RaceFinish.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        laps++;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime <= this.RawTime)
        {
            if (LapTimeManager.seconds <= 9)
            {
                BestSecondBox.GetComponent<Text>().text = "0" + LapTimeManager.seconds + "";
            }
            else
            {
                BestSecondBox.GetComponent<Text>().text = LapTimeManager.seconds + "";
            }
            if (LapTimeManager.minutes <= 9)
            {
                BestMinuteBox.GetComponent<Text>().text = "0" + LapTimeManager.minutes + ".";
            }
            else
            {
                BestMinuteBox.GetComponent<Text>().text = LapTimeManager.minutes + ".";
            }

            BestMilliSecondBox.GetComponent<Text>().text = "." + LapTimeManager.milliSeconds.ToString("F0");
        }
        PlayerPrefs.SetInt("MinSave", LapTimeManager.minutes);
        PlayerPrefs.SetInt("SecSave", LapTimeManager.seconds);
        PlayerPrefs.SetFloat("MilliSecSave", LapTimeManager.milliSeconds);
        PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

        LapTimeManager.milliSeconds = 0;
        LapTimeManager.seconds = 0;
        LapTimeManager.minutes = 0;
        LapTimeManager.RawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + laps;

        LapHalfTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}
