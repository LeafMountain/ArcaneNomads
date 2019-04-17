using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraComponent : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float Distance;
    [Range(0, 1)]
    public float Smoothing = .3f;

    void Start()
    {

    }

    void LateUpdate()
    {
        Vector3 targetPosition = Target.position;
        transform.position = targetPosition + Offset + (-transform.forward * Distance);
    }

    public void AddRotation(Quaternion rotation)
    {
        
    }

    public void SetRotation(Quaternion rotation)
    {

    }
}
