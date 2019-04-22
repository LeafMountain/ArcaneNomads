using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StorableComponent))]
public class StorableInteractionResponse : MonoBehaviour, IInteractable
{
    StorableComponent storeable;

    void Start()
    {
        storeable = GetComponent<StorableComponent>();
    }

    public void OnFocus()
    {
    }

    public void OnInteract(InteractorComponent interactor)
    {
        StorageComponent storage = interactor.GetComponent<StorageComponent>();
        if(storage)
            storage.inventory.Deposit(storeable);
        else
            Debug.Log("No storage on interactor");
    }

    public void OnUnfocus()
    {
    }
}
