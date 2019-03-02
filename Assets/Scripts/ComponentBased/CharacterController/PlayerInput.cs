using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public UnityEventVector3 moveInput;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        moveInput.Invoke(new Vector3(h, 0, v));
    }
}

[System.Serializable]
public class UnityEventVector3 : UnityEvent<Vector3> {}
