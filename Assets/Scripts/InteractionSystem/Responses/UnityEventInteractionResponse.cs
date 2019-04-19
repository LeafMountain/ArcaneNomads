using UnityEngine;
using UnityEngine.Events;

public class UnityEventInteractionResponse : MonoBehaviour, IInteractable
{
    public UnityEvent OnInteracted;
    public UnityEvent OnFocus;
    public UnityEvent OnUnfocus;

    public void OnInteract(InteractorComponent interactor)
    {
        OnInteracted.Invoke();
    }

    void IInteractable.OnFocus()
    {
        OnFocus.Invoke();
    }

    void IInteractable.OnUnfocus()
    {
        OnUnfocus.Invoke();
    }
}

// [System.Serializable]
// public class UnityEventInteractable : UnityEngine.Events.UnityEvent<InteractableComponent> { }
