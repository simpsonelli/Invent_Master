using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour
{
    public GameObject[] speakers;
    public AudioSource[] speakerAudio;
    public AudioSource[] rhodes;
    public AudioSource portalSound;

    private bool isCalled = false;


    public void OnTriggerEnter(Collider other)
    {
        if (isCalled == false && other.CompareTag("Player"))
        {
            
            portalSound.Play();
            StartCoroutine(DelayAudioLoad());
            IEnumerator DelayAudioLoad()
            {
                yield return new WaitForSeconds(1.5f);
                PlayAll();
                isCalled = true;
            }
        }
        else if (isCalled == true && other.CompareTag("Player"))
        {
            StopAll();
            portalSound.Play();
            StartCoroutine(DelayAudioLoad());
            IEnumerator DelayAudioLoad()
            {
                yield return new WaitForSeconds(1.5f);
                rhodes[0].Play();
                rhodes[1].Play();
                rhodes[2].Play();
                rhodes[3].Play();
                isCalled = false;
            }
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
