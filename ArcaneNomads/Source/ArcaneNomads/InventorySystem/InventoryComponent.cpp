#include "InventoryComponent.h"
#include "StoreableComponent.h"

UInventoryComponent::UInventoryComponent()
{
}

void UInventoryComponent::BeginPlay()
{
    // Inventory = new Inventory[Size];
}

void UInventoryComponent::Deposit(UStoreableComponent *Item)
{
    for (int i = 0; i < Size; i++)
    {        
        if(Inventory[i] == nullptr)
        {
            Inventory[i] = Item;
            Item->Store(this);
            OnInventoryUpdated.Broadcast();
            return;
        }
    }
    
    UE_LOG(LogTemp, Warning, TEXT("[InventoryComponent] No space in inventory for item %s"), *Item->GetName());
}

UStoreableComponent* UInventoryComponent::Withdraw(int Index)
{
    UStoreableComponent* storeable = Inventory[Index];
    if (storeable)
    {
        Inventory[Index] = nullptr;
        storeable->Drop();
        OnInventoryUpdated.Broadcast();
    }
    return storeable;
}

UStoreableComponent* UInventoryComponent::GetInventory()
{
    return *Inventory;
}

int UInventoryComponent::GetNumberOfItemsInInventory()
{
    int NumberOfItems = 0;

    for (int i = 0; i < Size; i++)
    {
        if(Inventory[i] != nullptr) NumberOfItems++;
    }
    
    return NumberOfItems;
}

UStoreableComponent* UInventoryComponent::GetItemAt(int Index)
{
    if(Size >= Index)
    {
        return Inventory[Index];
    }

    return nullptr;
}