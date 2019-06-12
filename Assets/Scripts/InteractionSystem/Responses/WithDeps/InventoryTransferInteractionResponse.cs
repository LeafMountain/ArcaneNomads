using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(StorageComponent))]
public class InventoryTransferInteractionResponse : MonoBehaviour, IInteractable
{
    StorageComponent storage;

    void Start()
    {
        storage = GetComponent<StorageComponent>();
    }

    public void OnFocus(InteractorComponent interactor)
    {
    }

    public void OnInteract(InteractorComponent interactor)
    {
        // For testing
        var otherInventory = interactor.GetComponent<StorageComponent>().inventory;
        for (int i = 0; i < otherInventory.size; i++)
        {
            if(otherInventory.storables[i])
                storage.inventory.Deposit(otherInventory.Withdraw(i));
        }
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
    }
}
