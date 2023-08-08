using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void TrackSelection()
    {
        SceneManager.LoadScene(1);
    }
    public void Track01()
    {
        SceneManager.LoadScene(2);
    }

}
