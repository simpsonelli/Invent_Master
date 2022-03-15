using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong1 : MonoBehaviour
{
    public List<AudioSource> musicSpheres = new List<AudioSource>();

    public void GetAudioSpheres()
    {
        for (int i = 0; i < transform.childCount; i ++)
        {
            musicSpheres.Add(transform.GetChild(i).GetComponent<AudioSource>());
        }
    }

    private void Start()
    {
        GetAudioSpheres();
    }

    public void PlayMusicSpheres()
    {
        foreach (AudioSource audio in musicSpheres)
        {
            audio.Play();
        }
    }
}
