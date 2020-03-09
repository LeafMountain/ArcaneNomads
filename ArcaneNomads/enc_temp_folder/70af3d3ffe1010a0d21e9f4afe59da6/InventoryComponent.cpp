#include "InventoryComponent.h"
#include "StoreableComponent.h"
#include <Engine/Engine.h>
#include "UISubsystem/UISubsystem.h"
#include "InventorySystem/InventoryWidget.h"
#include "InteractionSystem/InteractorComponent.h"

UInventoryComponent::UInventoryComponent()
{
    myStoreables.SetNumZeroed(Size);
}

void UInventoryComponent::Interact_Implementation(class UInteractorComponent* Interactor)
{
    if (myUISubsystem != nullptr)
    {
        Toggle();

        if (Interactor)
        {
            UInventoryComponent* interactorInventory = Cast<UInventoryComponent>(Interactor->GetOwner()->GetComponentByClass(UInventoryComponent::StaticClass()));
            if (interactorInventory)
            {
                interactorInventory->Toggle();
            }
        }
    }
}

void UInventoryComponent::StopFocus_Implementation()
{
    //Close();
}

void UInventoryComponent::BeginPlay()
{
    myUISubsystem = GetWorld()->GetGameInstance()->GetSubsystem<UUISubsystem>();
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

void UInventoryComponent::Open()
{
    if (isOpen == true || anInventoryWidget == nullptr)
        return;

	myOpenInventoryWidget = CastChecked<UInventoryWidget>(myUISubsystem->OpenWidget(anInventoryWidget.Get(), true));
    myOpenInventoryWidget->SetupInventory(this);
    isOpen = true;

    OnInventoryUpdated.AddDynamic(this, &UInventoryComponent::Open);
}

void UInventoryComponent::Close()
{
    // Implement this in UI system first

    if (isOpen == false)
        return;

    myUISubsystem->CloseTop();
    isOpen = false;
    OnInventoryUpdated.RemoveDynamic(this, &UInventoryComponent::Open);
}

void UInventoryComponent::Toggle()
{
    if (isOpen)
    {
        Close();
    }
    else
    {
        Open();
    }
}


