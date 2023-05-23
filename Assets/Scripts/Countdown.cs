using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CountdownTime;
    public GameObject LapTimer;
    public AudioSource CountdownAudio;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownStart());
    }
    IEnumerator CountdownStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountdownTime.GetComponent<Text>().text = "3";
        CountdownAudio.Play();
        CountdownTime.SetActive(true);
        yield return new WaitForSeconds(1);
        CountdownTime.SetActive(false);
        CountdownTime.GetComponent<Text>().text = "2";
        CountdownAudio.Play();
        CountdownTime.SetActive(true);
        yield return new WaitForSeconds(1);
        CountdownTime.SetActive(false);
        CountdownTime.GetComponent<Text>().text = "1";
        CountdownAudio.Play();
        CountdownTime.SetActive(true);
        yield return new WaitForSeconds(1);
        CountdownTime.SetActive(false);
        CountdownAudio.Play();
        LapTimer.SetActive(true);
        CarController.CanControl = true;
    }
}
