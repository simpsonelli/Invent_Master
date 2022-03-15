using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{

    private Animator animator;
    public string buttonName;
    public string triggerName;
    public string undoButton;

    private GrabbableObject hoveredObject;
    private GrabbableObject grabbedObject;

    private void OnTriggerEnter(Collider other)
    {
        GrabbableObject grabble = other.GetComponent<GrabbableObject>();

        if (grabble != null)
        {

            if (hoveredObject != null)
            {
                hoveredObject.OnHoverEnd();
            }
            hoveredObject = grabble;
            hoveredObject.OnHoverStart();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GrabbableObject grabble = other.GetComponent<GrabbableObject>();
        if (grabble == hoveredObject && grabble != null)
        {
            hoveredObject.OnHoverEnd();
            hoveredObject = null;
        }
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   // checking if grip button is pressed
        if (Input.GetButtonDown(buttonName))
        {
            animator.SetBool("Gripped", true);

            if (hoveredObject != null)
            {
                hoveredObject.OnGrabStart(this);
                grabbedObject = hoveredObject;
                hoveredObject = null;
            }
        }
        //checking if button was released
        if (Input.GetButtonUp(buttonName))
        {
            animator.SetBool("Gripped", false);
            if (grabbedObject != null)
            {
                grabbedObject.OnGrabEnd();
                grabbedObject.SendMessage("Released");

                grabbedObject = null;

            }
        }

        if (Input.GetButtonDown(triggerName))
        {
            if (grabbedObject != null)
            {
                grabbedObject.SendMessage("TriggerDown");
            }
        }

        else if (Input.GetButtonUp(triggerName))
        {
            if (grabbedObject != null)
            {
                grabbedObject.SendMessage("TriggerUp");
            }
        }

        if(Input.GetButtonDown(undoButton))
        {
            grabbedObject.SendMessage("Undo");
        }
    }              

}
