using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorableComponent : MonoBehaviour, IInteractable
{
    public Sprite icon;

    public void OnStore()
    {
        gameObject.SetActive(false);
    }

    public void OnUnstore()
    {
        gameObject.SetActive(true);
    }

    public void OnInteract(InteractorComponent interactor)
    {
        StorageComponent storage = interactor.GetComponent<StorageComponent>();
        if(storage)
            storage.Deposit(this);
        else
            Debug.Log("No storage on interactor");
    }

    public void OnFocus()
    {
    }

    public void OnUnfocus()
    {
    }
}
