using UnityEngine;
using UnityEngine.UI;

public class InventoryUIComponent : MonoBehaviour
{
    public InventoryAsset inventory;
    public Transform buttonParent;
    public GameObject buttonPrefab;

    InventoryUIButton[] currentTiles = new InventoryUIButton[0];

    void Awake()
    {
        if(!buttonPrefab)
            Destroy(this);
        if(!buttonParent)
            buttonParent = transform;
    }

    void Start()
    {
        for (int i = 0; i < buttonParent.childCount; i++)
        {
            Destroy(buttonParent.GetChild(i).gameObject);
        }

        if(!inventory)
            return;
        else
            SetInventory(inventory);
    }

    public void SetInventory(InventoryAsset inventory)
    {
        for (int i = 0; i < currentTiles.Length; i++)
            Destroy(currentTiles[i].gameObject);

        this.inventory = inventory;
        currentTiles = new InventoryUIButton[inventory.size];
        for (int i = 0; i < currentTiles.Length; i++)
            currentTiles[i] = Instantiate(buttonPrefab, buttonParent).GetComponent<InventoryUIButton>();

        inventory.OnInventoryUpdated += UpdateUI;
        UpdateUI();
    }

    void UpdateUI()
    {
        if(!inventory)
            return;

        StorableComponent[] storables = inventory.GetStorables();
        for (int i = 0; i < currentTiles.Length && i < storables.Length; i++)   
            currentTiles[i].SetStorable(storables[i]);
    }
}
