using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar_01Track : MonoBehaviour
{

    public GameObject TheMarker;
    [SerializeField] public GameObject[] WayPoints = new GameObject[39];
    public int MarkTracker = 0;

    private void Start()
    {
        //Debug.Log("test");
    }
    // Update is called once per frame
    void Update()
    {
        // if(MarkTracker == 0)
        //TheMarker.transform.position = WayPoints[0].transform.position;
        // if (MarkTracker == 1)
        //     TheMarker.transform.position = WayPoints[1].transform.position;
        // if (MarkTracker == 2)
        //     TheMarker.transform.position = WayPoints[2].transform.position;
        TheMarker.transform.position = WayPoints[MarkTracker].transform.position;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        Debug.Log("ontriggerenter");
        if (other.gameObject.tag == "AICar_01")
        {
        Debug.Log("collision");
        this.GetComponent<BoxCollider>().enabled = false;
        MarkTracker += 1;
        }
        if (MarkTracker == WayPoints.Length)
        {
            MarkTracker = 0;
        }
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }
    //IEnumerator OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("oncollisionenter");
    //    //if (other.gameObject.tag == "AICar_01")
    //    //{
    //    this.GetComponent<BoxCollider>().enabled = false;
    //    MarkTracker += 1;
    //    //}
    //    if (MarkTracker == WayPoints.Length)
    //    {
    //        MarkTracker = 0;
    //    }
    //    yield return new WaitForSeconds(1);
    //    this.GetComponent<BoxCollider>().enabled = true;
    //}

}
