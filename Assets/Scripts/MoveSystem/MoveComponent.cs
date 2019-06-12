using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveComponent : MonoBehaviour
{
    [Tooltip("Normal speed in m/s")] public float MoveSpeed = 1;
    [Tooltip("Sprint speed in m/s")] public float SprintSpeed = 2;
    public float RotationSpeed = 3;
    public bool RelativeToCamera;
    public float Gravity = -12f;

    [Header("Jumping")]
    public float JumpHeight;

    public float animationSmoothing = .1f;

    public delegate void MoveEvent();
    public MoveEvent OnJump;

    float targetSpeed;
    CharacterController characterController;
    Animator animator;
    Vector3 velocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        targetSpeed = MoveSpeed;
    }

    void Update()
    {
        // Apply gravity
        velocity.y += Time.deltaTime * Gravity;

        // Debug.Log(velocity);
        characterController.Move(velocity * Time.deltaTime);

        // Rotation
        Vector3 lookDirection = velocity;
        if (rotationLock)
            lookDirection = Camera.main.transform.forward;
        RotateTowardsMoveDir(lookDirection);

        // Reset gravity
        if (IsGrounded())
        {
            velocity.y = 0;
            velocity.x *= .1f;
            velocity.z *= .1f;
        }
    }

    void LateUpdate()
    {
        // Animation
        if (animator)
        {
            Vector3 localVelocity = GetLocalVelocity(GetCurrentVelocity());
            animator.SetFloat("VelocityX", localVelocity.x, animationSmoothing, Time.deltaTime);
            animator.SetFloat("VelocityY", localVelocity.y, animationSmoothing, Time.deltaTime);
            animator.SetFloat("VelocityZ", localVelocity.z, animationSmoothing, Time.deltaTime);
            animator.SetBool("Grounded", IsGrounded());
        }
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
        Vector3 force = direction;
        force = Camera.main.transform.TransformDirection(force);
        force.y = 0;
        force = force.normalized;
        force *= targetSpeed;

        Vector3 horizontalVelocity = new Vector3(velocity.x, 0, velocity.z);
        float test = horizontalVelocity.magnitude;
        float maxForce = Mathf.Clamp(force.magnitude - horizontalVelocity.magnitude, 0, 5);

        force = Vector3.ClampMagnitude(force, maxForce);

        AddForce(force);
    }

    public void Jump()
    {
        if (IsGrounded())
        {
            velocity.y = 0;
            float jumpVelocity = Mathf.Sqrt(-2 * Gravity * JumpHeight);
            AddForce(Vector3.up * jumpVelocity);

            if (animator)
                animator.SetTrigger("Jump");
        }
    }

    public void SetSprint(bool value)
    {
        targetSpeed = value ? SprintSpeed : MoveSpeed;
    }

    public bool IsGrounded()
    {
        return characterController.isGrounded;
    }

    public Vector3 GetLocalVelocity(Vector3 worldVelocity)
    {
        Vector3 localVelocity = transform.InverseTransformDirection(worldVelocity);
        return localVelocity;
    }

    public Vector3 GetCurrentVelocity()
    {
        return characterController.velocity;
    }

    public void AddForce(Vector3 force)
    {
        velocity += force;
    }

    public void SetRelativeToCamera(bool value) => RelativeToCamera = value;

    bool rotationLock = false;
    public void LockRotation(bool value) => rotationLock = value;
}
