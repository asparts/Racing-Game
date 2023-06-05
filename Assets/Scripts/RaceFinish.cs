using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish : MonoBehaviour
{
    public GameObject PlayerCar;
    public GameObject FinishCamera;
    public GameObject ViewModes;

    void OnTriggerEnter(Collider other)
    {
        //PlayerCar.SetActive(false);
        //RaceFinishTrigger.SetActive(false);
            Debug.Log("RACE FINISHED!");
            CarController.CanControl = false;
            FinishCamera.SetActive(true);
            ViewModes.SetActive(false);
    }
}
