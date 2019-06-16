using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetComponent : MonoBehaviour
{
    ThirdPersonCameraComponent cam;
    ThirdPersonCameraComponent Camera
    {
        get
        {
            if (!cam)
                cam = GameObject.FindObjectOfType<ThirdPersonCameraComponent>();
            if (!cam)
            {
                Debug.LogError("Third person camera missing.");
                return null;
            }
            else
                return cam;
        }
    }

    void OnEnable()
    {
        Camera?.AddTarget(transform);
    }

    void OnDisable()
    {
        Camera?.RemoveTarget(transform);
    }

    void Update()
    {

    }
}
