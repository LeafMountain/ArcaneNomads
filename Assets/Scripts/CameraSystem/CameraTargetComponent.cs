using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetComponent : MonoBehaviour
{
    ThirdPersonCameraComponent camera;
    ThirdPersonCameraComponent Camera
    {
        get
        {
            if (!camera)
                camera = GameObject.FindObjectOfType<ThirdPersonCameraComponent>();
            if (!camera)
            {
                Debug.LogError("Third person camera missing.");
                return null;
            }
            else
                return camera;
        }
    }

    void OnEnable()
    {
        Camera.AddTarget(transform);
    }

    void OnDisable()
    {
        Camera.RemoveTarget(transform);
    }

    void Update()
    {

    }
}
