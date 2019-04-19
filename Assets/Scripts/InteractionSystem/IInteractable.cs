public interface IInteractable
{
    void OnInteract(InteractorComponent interactor);
    void OnFocus();
    void OnUnfocus();
}
