using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCamera;
    public GameObject DistantCamera;
    public GameObject FirstPersonCamera;
    public GameObject RearCamera;


    public int CameraMode = 0;

    void Update()
    {
        if (Input.GetButtonDown("CameraViewmode"))
        {
            CameraMode++;
            if (CameraMode == 3)
            {
                CameraMode = 0;
            }

            Debug.Log("camera mode: " + CameraMode);
            StartCoroutine(ModeChange());
            
        }
    }
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CameraMode == 0)
        {
            NormalCamera.SetActive(true);
            RearCamera.SetActive(false);
        }
        if (CameraMode == 1)
        {
            Debug.Log("test");
            DistantCamera.SetActive(true);
            NormalCamera.SetActive(false);
        }
        if (CameraMode == 2)
        {
            FirstPersonCamera.SetActive(true);
            DistantCamera.SetActive(false);
        }
        if (CameraMode == 3)
        {
            RearCamera.SetActive(true);
            FirstPersonCamera.SetActive(false);
        }

    }
}
