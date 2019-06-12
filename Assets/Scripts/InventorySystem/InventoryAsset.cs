using UnityEngine;

[CreateAssetMenu]
public class InventoryAsset : ScriptableObject
{
    public int size;
    // [HideInInspector]
    public StorableComponent[] storables;

    public delegate void InventoryEvent();
    public InventoryEvent OnInventoryUpdated;

    void OnEnable()
    {
        storables = new StorableComponent[size];
    }

    public void SetSize(int value)
    {
        if(size != value)
        {
            size = value;
            storables = new StorableComponent[size];
            // Maybe transfer the old items to the new array first?

            OnInventoryUpdated?.Invoke();
        }
    }

    public bool Deposit(StorableComponent storeable)
    {
        for (int i = 0; i < size; i++)
        {
            if(storables[i] == null)
            {
                storables[i] = storeable;
                storeable.OnStore(this);
                OnInventoryUpdated?.Invoke();
                return true;
            }
        }

        Debug.Log("The storage is full");
        return false;
    }

    public StorableComponent Withdraw(StorableComponent storeable)
    {
        for (int i = 0; i < size; i++)
        {
            if(storables[i] == storeable)
            {
                storables[i] = null;
                storeable.OnDrop();
                OnInventoryUpdated?.Invoke();
                return storeable;
            }
        }
        Debug.Log("Storable not found in this storage");
        return null;
    }

    public StorableComponent Withdraw(int index)
    {
        if(index < size && index >= 0){
            if(storables[index])
            {
                StorableComponent storable = storables[index];
                storables[index] = null;
                storable.OnDrop();
                OnInventoryUpdated?.Invoke();
                return storable;
            }
        }
        else{
            Debug.Log("Outside of storage size");
        }

        return null;
    }

    public int GetStorageSize()
    {
        return size;
    }

    public StorableComponent[] GetStorables()
    {
        return storables;
    }
}
