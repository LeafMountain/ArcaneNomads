using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    [Range(0, 1)]
    public float AnimationSmoothing;

    Animator animator;
    MoveComponent moveComponent;

    void Start()
    {
        animator = GetComponent<Animator>();
        moveComponent = GetComponent<MoveComponent>();
        moveComponent.OnJump += TriggerJump;
    }

    void Update(){
        if(moveComponent)
        {
            Vector3 localVelocity = moveComponent.GetLocalVelocity(moveComponent.GetCurrentVelocity());
            animator.SetFloat("VelocityX", localVelocity.x, AnimationSmoothing, Time.deltaTime);
            // animator.SetFloatChecked("VelocityY", localVelocity.y, AnimationSmoothing, Time.deltaTime);
            animator.SetFloat("VelocityZ", localVelocity.z, AnimationSmoothing, Time.deltaTime);
            // animator.SetBool("Grounded", moveComponent.IsGrounded());
        }
    }

    void TriggerJump()
    {
        animator.SetTrigger("Jump");
    }
}
