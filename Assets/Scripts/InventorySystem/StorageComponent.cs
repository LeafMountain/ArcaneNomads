using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class StorageComponent : MonoBehaviour
{
    public InventoryAsset inventory;
    // public Vector3 uiOffset;
    
    void Start()
    {
        if(!inventory)
        {
            inventory = ScriptableObject.CreateInstance<InventoryAsset>();
            inventory.SetSize(4);
        }
    }

    public void DropNext()
    {
        for (int i = 0; i < inventory.size; i++)
        {
            if(inventory.storables[i])
            {
                StorableComponent storable = inventory.Withdraw(inventory.storables[i]);
                storable.transform.position = transform.position;
                return;
            }
        }
    }
}
