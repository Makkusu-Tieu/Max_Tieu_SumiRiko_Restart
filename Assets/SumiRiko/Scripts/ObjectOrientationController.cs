using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientationController : MonoBehaviour
{
    public float minXAngle = 0f;
    public float maxXAngle = 90f;
    public float minYAngle = 0f;
    public float maxYAngle = 90f;
    public float minZAngle = 0f;
    public float maxZAngle = 90f;

    public GameObject socket;
    public GameObject other;

    private bool isInRange = false;

    private void Update()
    {
        Vector3 objectRotation = transform.rotation.eulerAngles;

        if (objectRotation.x >= minXAngle && objectRotation.x <= maxXAngle
            && objectRotation.y >= minYAngle && objectRotation.y <= maxYAngle
            && objectRotation.z >= minZAngle && objectRotation.z <= maxZAngle)
        {
            isInRange = true;
            // Remove any feedback mechanisms (e.g., stop highlighting the object)
        }
        else
        {
            isInRange = false;
            // Add feedback mechanisms (e.g., highlight the object in red)
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == socket && isInRange)
        {
            // Allow the object to be inserted into the socket
        }
    }

    private void OnTriggerExit(Collider other)
{
    if (other.gameObject == socket)
    {
        isInRange = false; // set isInRange to false when object exits the trigger
        // Prevent the object from being inserted into the socket
    }
}
}

