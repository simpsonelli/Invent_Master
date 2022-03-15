using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Lever : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onTriggerEntered;

    public GameObject objToSpawn;

    public AudioSource leverSlide;

    public Vector3 spawnBrush;

    private bool hasSpawned = false;

   



    private void OnTriggerEnter(Collider other)
        {
        if (other.tag == "Lever")
        {
            if (hasSpawned == false)
            {
                onTriggerEntered.Invoke();
                Spawn();
                leverSlide.Play();
                hasSpawned = true;
               // other.GetComponent<Haptic>().Vibrate(0.5f, .5f);

            }

            if (hasSpawned == true)
            {
                leverSlide.Play();
            }

        }
              
        }

    void Spawn()
    {
        Instantiate(objToSpawn, spawnBrush, Quaternion.Euler(0, 180 ,90));
    }


}
