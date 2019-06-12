using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationTriggerInteractionResponse : MonoBehaviour, IInteractable
{
    public string TriggerName;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnFocus(InteractorComponent interactor)
    {
    }

    public void OnInteract(InteractorComponent interactor)
    {
        animator.SetTrigger(TriggerName);
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
    }
}
