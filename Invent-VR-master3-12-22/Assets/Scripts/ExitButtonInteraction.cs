using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class ExitButtonInteraction : MonoBehaviour
{
    [SerializeField] Transform exitDownTransform;
    [SerializeField] Transform exitButtonMesh;
    [SerializeField] UnityEvent exitButtonDown;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = this.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            exitButtonMesh.position = exitDownTransform.position;

            exitButtonDown.Invoke();
            Debug.Log("Quit Game");
            Application.Quit();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            exitButtonMesh.position = startPosition;
        }
    }
}
