using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
public class EventSubscriber : MonoBehaviour
{
    private void Start()
    {
        Koreographer.Instance.RegisterForEvents("TestEventID", FireEventDebugLog);
    }

    void FireEventDebugLog(KoreographyEvent koreoEvent)
    {
        Debug.Log("Koreography Event Fired");
    }
  
}
