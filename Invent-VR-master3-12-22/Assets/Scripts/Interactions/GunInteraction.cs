using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunInteraction : MonoBehaviour
{
    [SerializeField] GameObject prefabBullet;
    [SerializeField] float shootForce;
    [SerializeField] Transform spawn;
    public AudioSource bulletSound;
    
   

   
    void TriggerDown()
    {
        GameObject go = Instantiate(prefabBullet, spawn.position, spawn.rotation);
        go.GetComponent<Rigidbody>().AddForce(shootForce * spawn.forward);
        Destroy(go, 5);
        bulletSound.Play();
    }
}
