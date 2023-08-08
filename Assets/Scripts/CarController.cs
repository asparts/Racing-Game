using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float enginePower = 150.0f;
    public float power = 0.0f;
    public float brake = 0.0f;
    public float steer = 0.0f;
    public float maxSteer = 80.0f;
    public WheelCollider Wheel_LF;
    public WheelCollider Wheel_RF;
    public WheelCollider Wheel_LR;
    public WheelCollider Wheel_RR;
    public static bool CanControl = false;

    //AI Variables
    public GameObject AiCar01;

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, -0.5f, 0.3f);
    }

    void Update()
    {
        if (!CanControl)
        {
            brake = GetComponent<Rigidbody>().mass * 10.0f;
            Wheel_LR.motorTorque = 0.0f;
            Wheel_RR.motorTorque = 0.0f;
            Wheel_LF.brakeTorque = brake;
            Wheel_RF.brakeTorque = brake;
            Wheel_LR.brakeTorque = brake;
            Wheel_RR.brakeTorque = brake;
        }

        if (CanControl)
        {
            //Activating AI Car control as well
            AiCar01.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl>().enabled = true;

            if (Input.GetKey(KeyCode.W))
            {
                power = enginePower * Time.deltaTime * 650.0f;

                Wheel_LR.motorTorque = power;
                Wheel_RR.motorTorque = power;
                Wheel_LF.brakeTorque = 0;
                Wheel_RF.brakeTorque = 0;
                Wheel_LR.brakeTorque = 0;
                Wheel_RR.brakeTorque = 0;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                power = -enginePower * Time.deltaTime * 650.0f;
                Wheel_LR.motorTorque = power;
                Wheel_RR.motorTorque = power;
                Wheel_LF.brakeTorque = 0;
                Wheel_RF.brakeTorque = 0;
                Wheel_LR.brakeTorque = 0;
                Wheel_RR.brakeTorque = 0;
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                brake = GetComponent<Rigidbody>().mass * 15.0f;
                Wheel_LF.brakeTorque = brake;
                Wheel_RF.brakeTorque = brake;
                Wheel_LR.brakeTorque = brake;
                Wheel_RR.brakeTorque = brake;
                Wheel_LR.motorTorque = 0.0f;
                Wheel_RR.motorTorque = 0.0f;
            }
            //else if (Input.GetKey(KeyCode.A))
            //{
            //    Wheel_LF.steerAngle = -maxSteer;
            //}
            //else if (Input.GetKey(KeyCode.D))
            //{
            //    Wheel_RF.steerAngle = maxSteer;
            //}
            else
            {
                Debug.Log("ELSE!");
                brake = GetComponent<Rigidbody>().mass * 2.0f;
                Wheel_LF.brakeTorque = brake;
                Wheel_RF.brakeTorque = brake;
                Wheel_LR.brakeTorque = brake;
                Wheel_RR.brakeTorque = brake;
                Wheel_LR.motorTorque = 0.0f;
                Wheel_RR.motorTorque = 0.0f;
                Wheel_LF.motorTorque = 0.0f;
                Wheel_RF.motorTorque = 0.0f;
                power = 0;
            }
            
            ////brake = Input.GetKey(KeyCode.Space) ? GetComponent<Rigidbody>().mass * 10.0f : 0.0f;
            steer = Input.GetAxisRaw("Horizontal") * maxSteer;
            Wheel_LF.steerAngle = steer;
            Wheel_RF.steerAngle = steer;


            //if (brake > 0.0)
            //{
            //    Wheel_LF.brakeTorque = brake;
            //    Wheel_RF.brakeTorque = brake;
            //    Wheel_LR.brakeTorque = brake;
            //    Wheel_RR.brakeTorque = brake;
            //    Wheel_LR.motorTorque = 0.0f;
            //    Wheel_RR.motorTorque = 0.0f;
            //}
            //else
            //{
            //    Wheel_LF.brakeTorque = 0;
            //    Wheel_RF.brakeTorque = 0;
            //    Wheel_LR.brakeTorque = 0;
            //    Wheel_RR.brakeTorque = 0;
            //    Wheel_LR.motorTorque = power;
            //    Wheel_RR.motorTorque = power;
            //}
        }
    }
}
