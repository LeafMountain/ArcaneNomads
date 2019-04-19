using UnityEngine;
using UnityEngine.Events;

public class InteractorComponent : MonoBehaviour
{
    public float Range = 1;
    public UnityEvent OnInteracted;

    Collider collider;
    IInteractable focusedTarget;

    void Start()
    {
        collider = GetComponent<Collider>();
    }

    void Update()
    {
        IInteractable visibleTarget = GetInteractableVisible();
        if(visibleTarget != focusedTarget)
        {
            focusedTarget?.OnUnfocus();
            focusedTarget = visibleTarget;
            if(focusedTarget != null)
                focusedTarget.OnFocus();
        }
    }

    IInteractable GetInteractableVisible()
    {
        // Maybe check in a cone instead
        RaycastHit hit;
        if (Physics.SphereCast(collider.bounds.center, .1f, transform.forward, out hit, Range))
        {
            return hit.transform.GetComponent<IInteractable>();
        }

        return null;
    }

    public void Interact()
    {
        if(focusedTarget != null)
            focusedTarget.OnInteract(this);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(GetComponent<Collider>().bounds.center, transform.forward * Range);
    }
}