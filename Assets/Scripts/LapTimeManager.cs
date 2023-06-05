using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{

    public static int minutes;
    public static int seconds;
    public static float milliSeconds;
    public static string milliSecondsDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliSecondBox;

    public static float RawTime;

    // Update is called once per frame
    void Update()
    {
        milliSeconds += Time.deltaTime * 10;
        RawTime += Time.deltaTime;
        milliSecondsDisplay = milliSeconds.ToString("F0");
        MilliSecondBox.GetComponent<Text>().text = "" + milliSecondsDisplay;

        if (milliSeconds > 9)
        {
            milliSeconds = 0;
            seconds++;
        }

        if (seconds <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + seconds + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = seconds + ".";
        }
        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }
        if (minutes <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + minutes + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = minutes + ":";
        }
       }
}
