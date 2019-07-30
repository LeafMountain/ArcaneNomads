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
            Addressables.Instantiate("Assets/Scripts/InventorySystem/UI/pref_core_ui_inventory.prefab", transform.position + uiOffset, Quaternion.identity, transform).Completed += OnUICreated;
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
        ui.transform.forward = Camera.main.transform.position - transform.position;
        ui.SetActive(true);
    }

    public void OnFocus(InteractorComponent interactor)
    {
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
        ui.SetActive(false);
    }
}
