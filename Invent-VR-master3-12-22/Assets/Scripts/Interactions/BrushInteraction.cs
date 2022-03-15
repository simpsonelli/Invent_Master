using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushInteraction : MonoBehaviour
{
    [SerializeField] private GameObject prefabTrail;
    [SerializeField] private Transform spawnTransform;

    private GameObject currentTrail;

    public AudioSource paintSound;

    void TriggerDown()
    {
        currentTrail = Instantiate(prefabTrail, spawnTransform.position, spawnTransform.rotation, spawnTransform);
        paintSound.Play();
    }

    void TriggerUp()
    {
        currentTrail.transform.parent = null;
        paintSound.Stop();
    }

    void Released()

    {
        currentTrail.transform.parent = null;
    }

    void Undo()
    {
        Destroy(currentTrail);
    }

    void PerformRedo()
    {
                                    
    }
}
