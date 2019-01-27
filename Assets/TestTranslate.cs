using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTranslate : MonoBehaviour
{
    public float Speed = 1;
    public float maxSpeed = 1;

    void FixedUpdate()
    {
        Vector3 moveDir = Vector3.forward * Speed;
        // transform.Translate(Vector3.forward * Speed);
        // GetComponent<Rigidbody>().MovePosition(transform.position + moveDir);
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        // velocity += moveDir;

        Debug.Log(velocity.magnitude);

        if(moveDir != Vector3.zero && velocity.magnitude < maxSpeed)
            GetComponent<Rigidbody>().AddForce(moveDir, ForceMode.VelocityChange);

    }
}
