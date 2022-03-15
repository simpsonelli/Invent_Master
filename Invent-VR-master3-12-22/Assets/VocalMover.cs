using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VocalMover : MonoBehaviour
{
    public GameObject vocalSphere;
    [SerializeField] float minRange;
    [SerializeField] float maxRange;
    [SerializeField] float vector3Y;

    private void Update()
    {
        RandomVocal();
    }

    void RandomVocal()
    {
        transform.position = new Vector3(Random.Range(-minRange, maxRange), vector3Y, Random.Range(-minRange, maxRange));
    }

}
