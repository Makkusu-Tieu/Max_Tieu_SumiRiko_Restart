using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientationController : MonoBehaviour
{
    public float minXAngle = -90f;
    public float maxXAngle = 90f;
    public float minYAngle = -90f;
    public float maxYAngle = 90f;
    public float minZAngle = -90f;
    public float maxZAngle = 90f;

    public GameObject socket;

    private void Update()
    {
        Debug.Log("X Rotation is" + transform.eulerAngles.x);

        Vector3 objectRotation = transform.rotation.eulerAngles;

        if (objectRotation.x >= minXAngle && objectRotation.x <= maxXAngle)
            //&& objectRotation.y >= minYAngle && objectRotation.y <= maxYAngle
            //&& objectRotation.z >= minZAngle && objectRotation.z <= maxZAngle)
        {
            socket.SetActive(true);
            Debug.Log("Object is in correct orientation");
            // Remove any feedback mechanisms (e.g., stop highlighting the object)
        }
        else
        {
            socket.SetActive(false);
            Debug.Log("Object is not in correct orientation");
            // Add feedback mechanisms (e.g., highlight the object in red)
        }
    }
}

