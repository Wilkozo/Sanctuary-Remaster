using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 CameraOffset;

    // Prevents Jittery camera Movement
    void LateUpdate ()
    {
        Vector3 desiredPos = target.position + CameraOffset;
        Vector3 SmoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = target.position + CameraOffset;
    }

}
