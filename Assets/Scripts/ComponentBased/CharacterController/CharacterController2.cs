using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterController2 : MonoBehaviour
{
    [Range(0.01f, 2)]
    public float moveSpeed = 1;

    private CharacterController characterController;
    private Vector3 gravity;
    private Transform cameraTransform;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        gravity = Physics.gravity;
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if(!IsGrounded())
        {
            MovePrivate(gravity);
        }
    }

    public bool IsGrounded()
    {
        return characterController.isGrounded;
    }

    public void Move(Vector3 direction)
    {
        direction = direction.normalized;
        direction *= moveSpeed;
        direction = cameraTransform.InverseTransformDirection(direction);
        MovePrivate(direction);
    }

    void MovePrivate(Vector3 vector)
    {
        characterController.Move(vector * Time.deltaTime);
    }
}
