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

    }

    public void OnFocus(InteractorComponent interactor)
    {
        ui.SetActive(true);
        ui.transform.forward = Camera.main.transform.position - transform.position;
    }

    public void OnUnfocus(InteractorComponent interactor)
    {
        ui.SetActive(false);
    }
}
