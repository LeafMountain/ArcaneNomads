using UnityEngine;
using UnityEngine.Events;

public class InteractableComponent : MonoBehaviour
{
    public UnityEventInteractor OnInteracted;
    public UnityEvent OnFocus;
    public UnityEvent OnUnfocus;

    public void SetFocus(bool value)
    {
        if (value) OnFocus.Invoke();
        else OnUnfocus.Invoke();
    }

    public void Interact(InteractorComponent interactor)
    {
        OnInteracted.Invoke(interactor);
    }
}

[System.Serializable]
public class UnityEventInteractable : UnityEngine.Events.UnityEvent<InteractableComponent> { }
