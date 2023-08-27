using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(FinishCredits());
    }
    IEnumerator FinishCredits()
    {
        yield return new WaitForSeconds(16);
        SceneManager.LoadScene(0);
    }
}
