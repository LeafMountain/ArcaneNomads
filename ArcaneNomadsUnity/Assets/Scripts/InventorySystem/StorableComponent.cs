using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorableComponent : MonoBehaviour, IInteractable
{
    public Sprite icon;

    InventoryAsset currentInventory;

    public void OnStore(InventoryAsset inventory)
    {
        currentInventory = inventory;
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        gameObject.SetActive(true);
    }

    public void DropFromInventory()
    {
        currentInventory?.Withdraw(this);
    }

    public void OnInteract(InteractorComponent interactor)
    {
        StorageComponent storage = interactor.GetComponent<StorageComponent>();
        if(storage)
            storage.inventory.Deposit(this);
        else
            Debug.Log("No storage on interactor");
    }

    public void OnFocus(InteractorComponent interactor)
    {
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
    }
}
