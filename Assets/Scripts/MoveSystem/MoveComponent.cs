using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    public float MoveSpeed;

    void Move(Vector3 Direction)
    {
        transform.Translate(Direction * MoveSpeed);
    }
}
