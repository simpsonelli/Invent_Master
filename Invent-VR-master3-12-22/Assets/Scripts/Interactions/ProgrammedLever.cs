using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammedLever : MonoBehaviour
{
    [SerializeField] Transform startTransform;
    [SerializeField] Transform endTransform;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 heading = endTransform.position - startTransform.position;
            float magnitudeOfHeading = heading.magnitude;
            heading.Normalize();

            Vector3 startToHand = other.transform.position - startTransform.position;
            float dotProduct = Vector3.Dot(startToHand, heading);
            dotProduct = Mathf.Clamp(dotProduct, 0, magnitudeOfHeading);

            transform.position = startTransform.position + heading * dotProduct;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
