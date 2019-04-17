using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveComponent : MonoBehaviour
{
    [Range(0, 20)]
    public float MoveSpeed = 1;
    [Range(0, 1)]
    public float Smoothing = .05f;
    public float RotationSpeed = 3;
    [Range(0, 1)]
    public float AnimationSmoothing = 0;
    public bool RelativeToCamera;
    public bool IgnoreY;

    CharacterController characterController;
    Animator animator;
    Vector3 moveVector;
    Vector3 currentVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 moveDirection = moveVector;
        if (RelativeToCamera) moveDirection = Camera.main.transform.TransformVector(moveDirection);
        if (IgnoreY) moveDirection.y = 0;
        Vector3 smoothMove = Vector3.SmoothDamp(transform.position, transform.position + moveDirection, ref currentVelocity, Smoothing, MoveSpeed, Time.deltaTime);
        smoothMove += Physics.gravity;
        characterController.Move(smoothMove - transform.position);

        RotateTowardsMoveDir(moveDirection);

        Vector3 localVelocity = transform.InverseTransformDirection(currentVelocity);
        Debug.DrawRay(transform.position, localVelocity, Color.red);
        Debug.DrawRay(transform.position, currentVelocity, Color.blue);

        // Send velocity to animator if it exists
        if (animator)
        {
            animator.SetFloat("VelocityX", localVelocity.x, AnimationSmoothing, Time.deltaTime);
            animator.SetFloat("VelocityY", localVelocity.y, AnimationSmoothing, Time.deltaTime);
            animator.SetFloat("VelocityZ", localVelocity.z, AnimationSmoothing, Time.deltaTime);
        }
    }

    // Temporary
    void RotateTowardsMoveDir(Vector3 direction)
    {
        direction.y = 0;
        Vector3 lookDirection = Vector3.Lerp(transform.forward, direction, Time.deltaTime * RotationSpeed);
        transform.LookAt(transform.position + lookDirection);
    }

    public void Move(Vector2 direction)
    {
        Move(new Vector3(direction.x, 0, direction.y));
    }

    public void Move(Vector3 direction)
    {
        direction.Normalize();
        moveVector = direction * MoveSpeed;
    }

    public void Jump(float height)
    {
        // Look up the algorithm
    }
}
