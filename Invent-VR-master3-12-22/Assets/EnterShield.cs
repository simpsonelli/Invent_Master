using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterShield : MonoBehaviour
{

    public GameObject shieldBlue;
    public GameObject title;
    public AudioSource shieldSound;
    private CubeDrop cubeDrop;
    [SerializeField] GameObject logoCube;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cubeDrop = logoCube.GetComponent<CubeDrop>();
            cubeDrop.StartScript();
            shieldSound.Play();
            Destroy(shieldBlue);
            Destroy(title);
        }
    }

}
