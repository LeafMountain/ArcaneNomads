using UnityEngine;

public class InteractorComponent : MonoBehaviour
{
    public float Range = 1;
    public UnityEventInteractable OnInteracted;

    Collider collider;

    void Start()
    {
        collider = GetComponent<Collider>();
    }

    void Update()
    {

    }

    InteractableComponent GetInteractableVisible()
    {
        // Maybe check in a cone instead
        RaycastHit hit;
        if (Physics.SphereCast(collider.bounds.center, .1f, transform.forward * Range, out hit))
        {
            return hit.transform.GetComponent<InteractableComponent>();
            // if (interactable)
            // {
            //     return interactable;
            //     // if (OnInteracted != null)
            //     //     OnInteracted.Invoke(interactable);
            //     // interactable.Interact(this);
            // }
        }

        return null;
    }

    public void Interact()
    {
        var interactable = GetInteractableVisible();
        interactable.Interact(this);
        OnInteracted.Invoke(interactable);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(GetComponent<Collider>().bounds.center, transform.forward * Range);
    }
}

[System.Serializable]
public class UnityEventInteractor : UnityEngine.Events.UnityEvent<InteractorComponent> { }