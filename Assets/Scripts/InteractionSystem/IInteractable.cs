public interface IInteractable
{
    void OnInteract(InteractorComponent interactor);
    void OnFocus(InteractorComponent interactor);
    void OnUnfocus(InteractorComponent interactor);
}
