using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpotlight : MonoBehaviour
{
    public new GameObject light;


    private void Start()
    {
        light.GetComponent<Light>().enabled = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            light.GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            light.GetComponent<Light>().enabled = false;
        }
    }
}


  
