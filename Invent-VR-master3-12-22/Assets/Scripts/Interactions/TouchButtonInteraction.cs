using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class TouchButtonInteraction : MonoBehaviour
{
    [SerializeField] Transform downTransform;
    [SerializeField] Transform buttonMesh;
    [SerializeField] UnityEvent buttonDown;
    public AudioSource speaker;
    public AudioSource speaker1;
    private Vector3 originalPosition;
    //public GameObject explosion;
    public Material sky;
    public Material sky1;


    private void Start()
    {
        originalPosition = this.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            buttonMesh.position = downTransform.position;

            buttonDown.Invoke();

            if (RenderSettings.skybox == sky)
            {
                speaker.Play();
                RenderSettings.skybox = sky1;
            }

            else
            {
                speaker1.Play();
                RenderSettings.skybox = sky;
            }




            //var explodeInstance = Instantiate(explosion, new Vector3((float).7, (float).3, (float)13.5), Quaternion.identity);

            //Destroy(explodeInstance, 2);



        }

        //Destroy(explosion, 2);
    }





    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            buttonMesh.position = originalPosition;
        }
    }







    //public void SpeakerTallOn(AudioSource speaker)
    //{
    //    //speaker.enabled = !speaker.enabled;
    //    speaker.Play();
    //}


}
