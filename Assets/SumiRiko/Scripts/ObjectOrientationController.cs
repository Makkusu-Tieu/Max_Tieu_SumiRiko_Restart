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

    private void Update()
    {
        Vector3 objectRotation = transform.rotation.eulerAngles;

        if (objectRotation.x >= minXAngle && objectRotation.x <= maxXAngle
            && objectRotation.y >= minYAngle && objectRotation.y <= maxYAngle
            && objectRotation.z >= minZAngle && objectRotation.z <= maxZAngle)
        {
            socket.SetActive(true);
            // Remove any feedback mechanisms (e.g., stop highlighting the object)
        }
        else
        {
            socket.SetActive(false);
            // Add feedback mechanisms (e.g., highlight the object in red)
        }
    }
}

