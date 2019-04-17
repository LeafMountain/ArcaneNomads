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

    // public Vector2 YawMinMax;
    public Vector2 PitchMinMax = new Vector2(-80, 80);

    void Start()
    {

    }

    void LateUpdate()
    {
        Vector3 targetPosition = Target.position;
        transform.position = targetPosition + Offset + (-transform.forward * Distance);
    }

    public void Move(Vector2 direction)
    {
        // dir X will rotate Y
        // dir Y will rotate X
        // Nothing should rotate Z
        // Clamp values
    }

    public void AddRotation(Quaternion rotation)
    {
        
    }

    public void SetRotation(Quaternion rotation)
    {

    }
}
