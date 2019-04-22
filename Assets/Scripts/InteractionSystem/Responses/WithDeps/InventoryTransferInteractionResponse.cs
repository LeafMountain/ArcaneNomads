using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(StorageComponent))]
public class InventoryTransferInteractionResponse : MonoBehaviour, IInteractable
{
    StorageComponent storage;

    GameObject canvas;
    GameObject uiText;
    Camera cam;

    void Start()
    {
        storage = GetComponent<StorageComponent>();
        cam = FindObjectOfType<Camera>();
        canvas = new GameObject("Canvas", typeof(Canvas));
        canvas.transform.SetParent(transform, false);
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
    }

    void Update()
    {
        if(uiText)
            uiText.transform.position = cam.WorldToScreenPoint(transform.position);
    }

    public void OnFocus(InteractorComponent interactor)
    {
        // Debug.Log("Interact to transfer all of your items.");

        uiText = new GameObject();
        uiText.transform.SetParent(canvas.transform, false);
        var text = uiText.AddComponent<TextMeshProUGUI>();
        text.text = "Transfer storage";
        // text.color = Color.red;
        text.outlineWidth = .3f;
        text.fontSize = 20f;
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
        if(uiText)
            Destroy(uiText);
    }
}
