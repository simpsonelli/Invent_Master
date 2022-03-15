using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private Light myLight;
    public string buttonName;
    public AudioSource switchSound;
    


    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.enabled = false;
    }

    void Update()
    {
            if (Input.GetButtonDown(buttonName))
            {
                myLight.enabled = !myLight.enabled;
                switchSound.Play();
            }
    }
}

