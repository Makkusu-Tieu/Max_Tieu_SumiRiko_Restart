using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientationLerp : MonoBehaviour
{
    public Transform objectToInsert;
    public float minAngle = -25f;
    public float maxAngle = 25f;
    public float tolerance = 10f;

    private Quaternion initialRotation;
    private Quaternion targetRotation;

    void Start()
    {
        initialRotation = objectToInsert.rotation;
        targetRotation = Quaternion.Euler(0f, 0f, minAngle);
    }

    void Update()
    {
        float currentAngle = Quaternion.Angle(objectToInsert.rotation, initialRotation);
        float rangeAngle = maxAngle - minAngle;
        float t = Mathf.InverseLerp(0f, rangeAngle, Mathf.Abs(currentAngle - minAngle));

        if (currentAngle <= tolerance)
        {
            // Object is within tolerance, insert it into the socket
            objectToInsert.rotation = targetRotation;
        }
        else
        {
            // Interpolate between the initial rotation and target rotation based on the current angle
            objectToInsert.rotation = Quaternion.Lerp(initialRotation, targetRotation, t);
        }
    }
}
