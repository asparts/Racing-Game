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

    private void OnTriggerEnter(Collider other)
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

        LapTimeManager.milliSeconds = 0;
        LapTimeManager.seconds = 0;
        LapTimeManager.minutes = 0;

        LapHalfTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}
