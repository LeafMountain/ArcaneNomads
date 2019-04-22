using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveComponent : MonoBehaviour
{
    public InputController InputController;

    [Tooltip("Normal speed in m/s")]
    public float MoveSpeed = 1;
    [Tooltip("Sprint speed in m/s")]
    public float SprintSpeed = 2;
    [Range(0, 1)]
    public float Smoothing = .05f;
    public float RotationSpeed = 3;
    public bool RelativeToCamera;
    public bool IgnoreY;
    public float GroundedTolerance = .1f;
    public float Gravity = -.9f;

    [Header("Jumping")]
    public float JumpHeight;

    public delegate void MoveEvent();
    public MoveEvent OnJump;

    float targetSpeed;
    float currentSpeed;
    CharacterController characterController;
    Vector3 moveVector;
    float currentSmoothVelocity;
    float velocityY;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        targetSpeed = MoveSpeed;
        Gravity = Physics.gravity.y;
    }

    void Update()
    {
        if(InputController)
        {
            Move(InputController.GetMoveIntup(transform));
            SetSprint(InputController.GetSprintInput());
            if(InputController.GetJumpInput()) Jump();
        }

        // Calculate new position
        Vector3 moveDirection = moveVector;
        if (RelativeToCamera) moveDirection = MakeRelativeToCamera(moveDirection, IgnoreY);
        float targetSpeed2 = targetSpeed * moveDirection.z;

        Vector3 currentVelocity = GetCurrentVelocity();
        currentVelocity.y = 0;
        currentSpeed = currentVelocity.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref currentSmoothVelocity, Smoothing);

        // Apply gravity
        velocityY += Time.deltaTime * Gravity;

        // Move
        Vector3 velocity = moveDirection * currentSpeed + Vector3.up * velocityY;
        characterController.Move(velocity * Time.deltaTime);

        // Reset gravity
        if (IsGrounded())
            velocityY = 0;

        // Rotation
        RotateTowardsMoveDir(moveDirection);
    }

    Vector3 MakeRelativeToCamera(Vector3 vector, bool ignoreY = false)
    {
        Vector3 moveDirectionRelativeToCamera = Camera.main.transform.TransformDirection(vector);
        if (ignoreY) moveDirectionRelativeToCamera.y = 0;
        moveDirectionRelativeToCamera.Normalize();
        return moveDirectionRelativeToCamera;
    }

    // Temporary
    void RotateTowardsMoveDir(Vector3 direction)
    {
        direction.y = 0;
        Vector3 lookDirection = Vector3.Lerp(transform.forward, direction, Time.deltaTime * RotationSpeed);
        transform.LookAt(transform.position + lookDirection);
    }

    public void Move(Vector2 direction) => Move(new Vector3(direction.x, 0, direction.y));
    public void Move(Vector3 direction)
    {
        moveVector = Vector3.Normalize(direction) * targetSpeed;
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            float jumpVelocity = Mathf.Sqrt(-2 * Gravity * JumpHeight);
            velocityY = jumpVelocity;
            OnJump?.Invoke();
        }
    }

    public void SetSprint(bool value)
    {
        targetSpeed = value ? SprintSpeed : MoveSpeed;
    }

    public bool IsGrounded()
    {
        return characterController.isGrounded;
        // float radius = characterController.radius;
        // Vector3 feetPosition = characterController.bounds.center - (Vector3.up * (characterController.height / 2 - radius + GroundDistance));
        // Ray groundedRay = new Ray(feetPosition, Vector3.down);
        // return (Physics.SphereCast(groundedRay, characterController.radius));
    }

    public Vector3 GetLocalVelocity(Vector3 worldVelocity)
    {
        Vector3 localVelocity = transform.InverseTransformDirection(worldVelocity);
        Debug.DrawRay(transform.position, localVelocity, Color.red);
        Debug.DrawRay(transform.position, worldVelocity, Color.blue);
        return localVelocity;
    }

    public Vector3 GetCurrentVelocity()
    {
        return characterController.velocity;
    }

    void OnDrawGizmos()
    {
        // Gizmos.DrawSphere(moveTarget, .5f);
        // if (characterController)
        // {
        //     float radius = characterController.radius;
        //     Vector3 feetPosition = characterController.bounds.center - (Vector3.up * (characterController.height / 2 - radius + GroundDistance));
        //     Gizmos.DrawWireSphere(feetPosition, characterController.radius);

        //     Debug.Log(IsGrounded());
        // }
    }
}
