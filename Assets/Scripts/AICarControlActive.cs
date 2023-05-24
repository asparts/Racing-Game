using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarControlActive : MonoBehaviour
{
    public GameObject AiCarControl;
    public GameObject AiCar01;
    
    void Start()
    {
        AiCar01.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl>().enabled = true;
    }
}
