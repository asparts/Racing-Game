using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{

    public GameObject lapCompleteTrigger;
    public GameObject halfPointTrigger;

    private void OnTriggerEnter()
    {
        lapCompleteTrigger.SetActive(true);
        halfPointTrigger.SetActive(false);
    }
}
