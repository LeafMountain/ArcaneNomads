using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraComponent : MonoBehaviour
{
    [Header("Position")]
    public Transform[] Targets = new Transform[10];
    public Vector3 Offset;
    public float Distance;

    [Header("Moving")]
    [Range(0, 1)]
    public float MoveSmoothing = .3f;
    [Range(0, 1)]
    public float MoveSensitivity = 1;

    [Header("Rotation")]
    [Range(0, 1)]
    public float RotationSmoothing = .05f;
    [Range(0, 1)]
    public float RotationSensitivity = 1;
    public Vector2 PitchMinMax = new Vector2(0, 80);

    [Header("Other")]
    public bool LockAndHideCursor = false;

    Vector3 currentRotationVelocity;
    Vector3 currentrotation;
    Vector3 currentVelocity;

    float yaw;
    float pitch;

    void Start()
    {
        if (LockAndHideCursor)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void LateUpdate()
    {
        if (!Targets[0])
            return;

        transform.eulerAngles = currentrotation;
        Vector3 targetPosition = Targets[0].position + Offset + (-transform.forward * Distance);// Make a bounding box instead to include all targets
        targetPosition *= MoveSensitivity;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, MoveSmoothing);
    }

    public void Move(Vector2 direction)
    {
        direction *= RotationSensitivity;
        yaw += direction.x;
        // yaw = yaw % 360;
        pitch -= direction.y;
        pitch = Mathf.Clamp(pitch, PitchMinMax.x, PitchMinMax.y);
        // pitch = pitch % 360;

        currentrotation = Vector3.SmoothDamp(currentrotation, new Vector3(pitch, yaw), ref currentRotationVelocity, RotationSmoothing);
    }

    public void AddRotation(Quaternion rotation)
    {

    }

    public void SetRotation(Quaternion rotation)
    {

    }

    public void AddTarget(Transform target)
    {
        for (int i = 0; i < Targets.Length; i++)
        {
            if (Targets[i])
                continue;

            Targets[i] = target;
            return;
        }

        Debug.LogWarning("No more targets allowed");
    }

    public void RemoveTarget(Transform target)
    {
        for (int i = 0; i < Targets.Length; i++)
        {
            if (Targets[i] == target)
            {
                Targets[i] = null;
                return;
            }
        }

        Debug.LogWarning("Target not a part of targets");
    }
}
