#include "InventoryComponent.h"
#include "StoreableComponent.h"

UInventoryComponent::UInventoryComponent()
{
    myStoreables.SetNumZeroed(Size);
}

void UInventoryComponent::BeginPlay()
{
    // Inventory = new Inventory[Size];
}

void UInventoryComponent::Deposit(UStoreableComponent *Item)
{
    if (IsFull())
    {
        UE_LOG(LogTemp, Warning, TEXT("[InventoryComponent] No space in inventory for item %s"), *Item->GetName());
        return;
    }

    myStoreables[myStoreables.Find(nullptr)] = Item;
	Item->Store(this);
	OnInventoryUpdated.Broadcast();


    //for (int i = 0; i < Size; i++)
    //{        
    //    if(myStoreables[i] == nullptr)
    //    {
    //        myStoreables[i] = Item;
    //        Item->Store(this);
    //        OnInventoryUpdated.Broadcast();
    //        return;
    //    }
    //}
}

UStoreableComponent* UInventoryComponent::WithdrawAt(int Index)
{
    UStoreableComponent* storeable = myStoreables[Index];
    if (storeable)
    {
        myStoreables[Index] = nullptr;
        storeable->Drop();
        OnInventoryUpdated.Broadcast();
    }
    return storeable;
}

UStoreableComponent* UInventoryComponent::Withdraw(UStoreableComponent* aStoreable)
{
    return WithdrawAt(myStoreables.Find(aStoreable));
}

TArray<UStoreableComponent*> UInventoryComponent::GetInventory()
{
    return myStoreables;
}

int UInventoryComponent::GetNumberOfItemsInInventory()
{
    int NumberOfItems = 0;

    for (int i = 0; i < Size; i++)
    {
        if(myStoreables[i] != nullptr) NumberOfItems++;
    }
    
    return NumberOfItems;
}

UStoreableComponent* UInventoryComponent::GetItemAt(int Index)
{
    if(Size >= Index)
    {
        return myStoreables[Index];
    }

    return nullptr;
}

bool UInventoryComponent::Contains(UStoreableComponent* aStoreable)
{
    return myStoreables.Contains(aStoreable);
}

bool UInventoryComponent::IsFull()
{
	//UE_LOG(LogTemp, Warning, TEXT("%i"), myStoreables.Num());
    for (auto it = myStoreables.CreateIterator(); it; ++it)
    {
        if (*it == nullptr)
        {
            return false;
        }
    }
    return true;
}
