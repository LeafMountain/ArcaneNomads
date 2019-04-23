using UnityEngine;

public class UseableComponent : MonoBehaviour, IInteractable
{
    public UnityEngine.Events.UnityEvent OnUse;

    public void OnFocus(InteractorComponent interactor)
    {
    }

    public void OnInteract(InteractorComponent interactor)
    {
        UserComponent user = interactor.GetComponent<UserComponent>();
        if(user)
        {
            user.SetUseable(this);
        }
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
    }

    public void Use(UserComponent user)
    {
        OnUse?.Invoke();
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(transform.position, new Vector3(.05f, .4f, .05f));
    }
}
