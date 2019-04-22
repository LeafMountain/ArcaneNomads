using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class StorageUIComponent : MonoBehaviour, IInteractable
{
    public Vector3 uiOffset;

    StorageComponent storage;
    GameObject ui;

    void Start()
    {
        storage = GetComponent<StorageComponent>();
        if(storage)
            Addressables.Instantiate("Assets/Core/pref_core_worldUI.prefab", transform.position + uiOffset, Quaternion.identity, transform).Completed += OnUICreated;
        else
            Destroy(gameObject);
    }

    void OnUICreated(IAsyncOperation<GameObject> operation)
    {
        ui = operation.Result;
        InventoryUIComponent inv = ui.GetComponentInChildren<InventoryUIComponent>();
        inv.SetInventory(storage.inventory);
        ui.SetActive(false);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + uiOffset, .3f);
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

    public void OnFocus()
    {
        ui.SetActive(true);
    }

    public void OnUnfocus()
    {
        ui.SetActive(false);
    }
}
