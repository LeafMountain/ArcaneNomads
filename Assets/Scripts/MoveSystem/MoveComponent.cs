using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveComponent : MonoBehaviour
{
    [Tooltip("Normal speed in m/s")]
    public float MoveSpeed = 1;
    [Tooltip("Sprint speed in m/s")]
    public float SprintSpeed = 2;
    [Range(0, 1)]
    public float Smoothing = .05f;
    public float RotationSpeed = 3;
    public bool RelativeToCamera;
    public bool IgnoreY;
    public float GroundDistance = .1f;

    [Header("Animation")]
    [Range(0, 1)]
    public float AnimationSmoothing = 0;

    float currentSpeed;
    CharacterController characterController;
    Animator animator;
    Vector3 moveVector;
    Vector3 currentVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        currentSpeed = MoveSpeed;
    }

    void Update()
    {
        Vector3 moveDirection = moveVector;
        if (RelativeToCamera) moveDirection = Camera.main.transform.TransformVector(moveDirection);
        if (IgnoreY) moveDirection.y = 0;
        Vector3 smoothMove = Vector3.SmoothDamp(transform.position, transform.position + moveDirection, ref currentVelocity, Smoothing, currentSpeed, Time.deltaTime);
        if (IsGrounded()) smoothMove += Physics.gravity;
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
        moveVector = direction * currentSpeed;
    }

    public void Jump(float height)
    {
        // Look up the algorithm
    }

    public void SetSprint(bool value)
    {
        currentSpeed = value ? SprintSpeed : MoveSpeed;
    }

    public bool IsGrounded()
    {
        return characterController.isGrounded;
        float radius = characterController.radius;
        Vector3 feetPosition = characterController.bounds.center - (Vector3.up * (characterController.height / 2 - radius + GroundDistance));
        Ray groundedRay = new Ray(feetPosition, Vector3.down);
        return (Physics.SphereCast(groundedRay, characterController.radius));
    }

    // void OnDrawGizmos()
    // {
    //     if (characterController)
    //     {
    //         float radius = characterController.radius;
    //         Vector3 feetPosition = characterController.bounds.center - (Vector3.up * (characterController.height / 2 - radius + GroundDistance));
    //         Gizmos.DrawWireSphere(feetPosition, characterController.radius);

    //         Debug.Log(IsGrounded());
    //     }
    // }
}
