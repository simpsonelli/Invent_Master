using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongAudio : MonoBehaviour
{
    public AudioSource drumsMain;
    public AudioClip drumsMainClip;
    public AudioSource vocalSource;
    public AudioClip vocalClip;
    

    private void Start()
    {
        drumsMain.clip = drumsMainClip;
        vocalSource.clip = vocalClip;
    }

    //private void Update()
    //{
    //    drumsMain.Play();
    //    vocalSource.Play();
    //}
}
