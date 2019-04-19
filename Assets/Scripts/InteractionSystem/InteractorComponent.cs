using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractorComponent : MonoBehaviour
{
    public float Range = 1;
    public UnityEvent OnInteracted;

    Collider col;
    IInteractable focusedTarget;
    GameObject focusedObject;

    IInteractable[] focusedInteractables;
    IInteractable[] newInteractables;

    void Start()
    {
        col = GetComponent<Collider>();
    }

    void Update()
    {
        (GameObject, IInteractable) visibleTarget = GetInteractableVisible();
        if(visibleTarget.Item2 != focusedTarget)
        {
            if(focusedTarget != null)
                foreach (var interactable in focusedObject.GetComponents<IInteractable>())
                    interactable.OnUnfocus();
            focusedObject = visibleTarget.Item1;
            focusedTarget = visibleTarget.Item2;
            if(focusedTarget != null)
                foreach (var interactable in focusedObject.GetComponents<IInteractable>())
                    interactable.OnFocus();
        }
    }

    (GameObject, IInteractable) GetInteractableVisible()
    {
        RaycastHit hit;
        if (Physics.SphereCast(col.bounds.center, .1f, transform.forward, out hit, Range))
        {
            return (hit.transform.gameObject, hit.transform.GetComponent<IInteractable>());
        }

        return (null, null);
    }

    public void Interact()
    {
        if(focusedTarget != null)
            foreach (var interactable in focusedObject.GetComponents<IInteractable>())
                interactable.OnInteract(this);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(GetComponent<Collider>().bounds.center, transform.forward * Range);
    }
}