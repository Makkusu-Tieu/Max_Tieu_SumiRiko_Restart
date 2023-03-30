using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientationController : MonoBehaviour
{
    public float minXAngle = -90f;
    public float maxXAngle = 90f;
    public float minYAngle = -90f;
    public float maxYAngle = 90f;
    //public float minZAngle = -90f;
    //public float maxZAngle = 90f;
    
    //For ranges that are only postive (example 0-90)

    public float minXAngle2 = -90f;
    public float maxXAngle2 = 90f;
    public float minYAngle2 = -90f;
    public float maxYAngle2 = 90f;
    //public float minZAngle2 = -90f;
    //public float maxZAngle2 = 90f;
    
    //Enable only if your range goes from negative and postive (example 270-90)
    //For the example above, enable second set of variables and set one to (270-360) and another to (0-90)

    public GameObject socket;

    private void Update()
    {
        //Debug.Log("X Rotation is" + transform.eulerAngles.x);
        Debug.Log("Y Rotation is" + transform.eulerAngles.y);
        //Enable Each One at a Time to Figure Out Ranges

        Vector3 objectRotation = transform.rotation.eulerAngles;

        if ((objectRotation.y >= minYAngle && objectRotation.y <= maxYAngle) || (objectRotation.y >= minYAngle2 && objectRotation.y <= maxYAngle2) &&
            (objectRotation.y >= minYAngle && objectRotation.y <= maxYAngle) || (objectRotation.y >= minYAngle2 && objectRotation.y <= maxYAngle2))
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

