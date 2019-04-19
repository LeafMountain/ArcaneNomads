using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageComponent : MonoBehaviour
{
    public int size = 10;
    public StorableComponent[] storables;

    void Start()
    {
        storables = new StorableComponent[size];
    }

    public bool Deposit(StorableComponent storeable)
    {
        for (int i = 0; i < size; i++)
        {
            if(storables[i] == null)
            {
                storables[i] = storeable;
                storeable.OnStore();
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
                storeable.OnUnstore();
                return storeable;
            }
        }
        Debug.Log("Storeable not fond in this storage");
        return null;
    }

    public StorableComponent Withdraw(int index)
    {
        if(index < size && index >= 0){
            storables[index].OnUnstore();
            return storables[index];
        }
        else{
            Debug.Log("Outside of storage size");
            return null;
        }
    }

    public int GetStorageSize()
    {
        return size;
    }

    public StorableComponent[] GetStorables()
    {
        return storables;
    }

    public void DropNext()
    {
        for (int i = 0; i < size; i++)
        {
            if(storables[i])
            {
                StorableComponent storable = Withdraw(storables[i]);
                storable.transform.position = transform.position;
                return;
            }
        }
    }
}
