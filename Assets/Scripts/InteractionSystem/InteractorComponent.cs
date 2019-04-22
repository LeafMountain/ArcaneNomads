using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractorComponent : MonoBehaviour
{
    public InputController InputController;

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
        if(InputController.GetInteractButton())
            Interact();

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
        if (Physics.SphereCast(col.bounds.center - transform.forward * .1f, .5f, transform.forward, out hit, Range))
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
        Gizmos.DrawWireSphere(GetComponent<Collider>().bounds.center, .5f);
        Gizmos.DrawRay(GetComponent<Collider>().bounds.center, transform.forward * Range);
    }
}