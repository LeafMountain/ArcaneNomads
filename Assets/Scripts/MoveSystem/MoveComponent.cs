using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveComponent : MonoBehaviour
{
    [Range(0, 20)]
    public float MoveSpeed = 1;
    [Range(0, 1)]
    public float Smoothing = .3f;

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
        Vector3 smoothMove = Vector3.SmoothDamp(transform.position, transform.position + moveVector, ref currentVelocity, Smoothing);
        smoothMove += Physics.gravity;
        characterController.Move(smoothMove - transform.position);
        
        // Send velocity to animator if it exists
        if(animator){
            animator.SetFloat("VelocityX", currentVelocity.x, Smoothing, Time.deltaTime);
            animator.SetFloat("VelocityY", currentVelocity.y, Smoothing, Time.deltaTime);
            animator.SetFloat("VelocityZ", currentVelocity.z, Smoothing, Time.deltaTime);
        }
    }

    public void Move(Vector2 direction)
    {
        Move(new Vector3(direction.x, 0, direction.y));
    }

    public void Move(Vector3 direction)
    {
        moveVector = direction * MoveSpeed;
    }
}
