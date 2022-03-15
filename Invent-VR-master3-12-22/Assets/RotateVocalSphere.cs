using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVocalSphere : MonoBehaviour
{
    public GameObject vocalSphere;
    public Material sphereMat;
    void Update()
    {
        vocalSphere.transform.Rotate(0, 10 * Time.deltaTime, 0, Space.Self);  
    }
}
