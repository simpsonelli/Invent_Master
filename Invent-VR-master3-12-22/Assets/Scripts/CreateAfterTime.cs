using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAfterTime : MonoBehaviour
{
    public float time;
    public GameObject spherePrefab;
    public Vector3 min;
    public Vector3 max;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateMusicSphere", time);
    }

    public void CreateMusicSphere()
    {
        Vector3 randomPosition = new Vector3(Random.Range(min.x, max.x), 0, Random.Range(min.z, max.z));
        Instantiate(spherePrefab, randomPosition, Quaternion.identity);
    }
}
