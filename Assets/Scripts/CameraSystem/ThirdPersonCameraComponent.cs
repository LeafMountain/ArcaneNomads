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
    public Vector2 PitchMinMax = new Vector2(0, 80);
    public bool LockAndHideCursor = false;

    Vector3 currentVelocity;
    Vector3 currentrotation;

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
        transform.eulerAngles = currentrotation;
        transform.position = Target.position + Offset + (-transform.forward * Distance);
    }

    public void Move(Vector2 direction)
    {
        yaw += direction.x;
        pitch -= direction.y;
        pitch = Mathf.Clamp(pitch, PitchMinMax.x, PitchMinMax.y);

        currentrotation = Vector3.SmoothDamp(currentrotation, new Vector3(pitch, yaw), ref currentVelocity, Smoothing);
    }

    public void AddRotation(Quaternion rotation)
    {

    }

    public void SetRotation(Quaternion rotation)
    {

    }
}
