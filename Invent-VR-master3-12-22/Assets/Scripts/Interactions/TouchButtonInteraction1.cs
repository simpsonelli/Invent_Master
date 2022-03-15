using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class TouchButtonInteraction1 : MonoBehaviour
{

     
    [SerializeField] Transform downTransform;
    [SerializeField] Transform buttonMesh;
    [SerializeField] UnityEvent buttonDown;
    public GameObject[] speakers;
    public AudioSource[] speakerAudio;
    public AudioSource speaker1;
    public GameObject sphere;
    public VideoPlayer videoPlayer;
    private Vector3 originalPosition;


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
            PlayAll();
            videoPlayer = sphere.GetComponent<VideoPlayer>();
            videoPlayer.Stop();
            videoPlayer.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            buttonMesh.position = originalPosition;
        }
    }
    public void PlayAll()
    {
        foreach (GameObject go in this.speakers)
            go.GetComponent<AudioSource>().Play();
    }

    public void StopAll()
    {
        foreach (GameObject go in this.speakers)
            go.GetComponent<AudioSource>().Stop();
    }
}
