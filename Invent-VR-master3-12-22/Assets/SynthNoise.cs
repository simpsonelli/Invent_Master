using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynthNoise : MonoBehaviour
{
    public AudioSource TriggerSource;
    public AudioClip TriggerClip1;
    public new GameObject light;


    // Start is called before the first frame update
    void Start()
    {
        TriggerSource.clip = TriggerClip1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TriggerSource.Play();
            light.GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            TriggerSource.Stop();
            light.GetComponent<Light>().enabled = false;
        }
    }
}


