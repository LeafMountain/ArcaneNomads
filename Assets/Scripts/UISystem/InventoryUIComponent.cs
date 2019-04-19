using UnityEngine;
using UnityEngine.UI;

public class InventoryUIComponent : MonoBehaviour
{
    StorageComponent storage;

    Image[] currentTiles = new Image[9];

    void Start()
    {
        storage = GameObject.FindGameObjectWithTag("Player")?.GetComponent<StorageComponent>();

        // Create tiles
        for (int i = 0; i < currentTiles.Length; i++)
        {
            GameObject go = new GameObject();
            go.name = i + " inventory tile";
            go.transform.SetParent(transform);
            currentTiles[i] = go.AddComponent<Image>();
        }
    }

    void Update()
    {
        StorableComponent[] storables = storage.GetStorables();
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
