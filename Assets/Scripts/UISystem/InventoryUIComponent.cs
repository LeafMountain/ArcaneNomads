using UnityEngine;
using UnityEngine.UI;

public class InventoryUIComponent : MonoBehaviour
{
    public InventoryAsset inventory;
    Image[] currentTiles = new Image[0];

    void Start()
    {
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
        // Create tiles
        currentTiles = new Image[inventory.size];
        for (int i = 0; i < currentTiles.Length; i++)
        {
            GameObject go = new GameObject();
            go.name = i + " inventory tile";
            go.transform.SetParent(transform, false);
            currentTiles[i] = go.AddComponent<Image>();
        }
    }

    void Update()
    {
        if(!inventory)
            return;

        StorableComponent[] storables = inventory.GetStorables();
        for (int i = 0; i < currentTiles.Length; i++)
        {
            if(i < storables.Length && storables[i] != null)
            {
                currentTiles[i].sprite = storables[i].icon;
            }
            else
            {
                currentTiles[i].sprite = null;
            }
        }
    }
}
