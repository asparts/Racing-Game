using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }
    public void TrackSelection()
    {
        SceneManager.LoadScene(2);
    }
    public void Track01()
    {
        SceneManager.LoadScene(3);
    }
    public void Track02()
    {
        SceneManager.LoadScene(4);
    }
    public void Credits()
    {
        SceneManager.LoadScene(5);
    }

}
