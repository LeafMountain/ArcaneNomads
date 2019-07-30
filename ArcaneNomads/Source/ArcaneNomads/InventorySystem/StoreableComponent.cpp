#include "StoreableComponent.h"
#include "InventoryComponent.h"

UStoreableComponent::UStoreableComponent()
{
    
}

void UStoreableComponent::Store(UInventoryComponent* Inventory)
{
    AActor* Owner = GetOwner();

    Owner->SetActorEnableCollision(false);
    Owner->SetActorHiddenInGame(true);
    Owner->SetActorTickEnabled(false);
    
    this->Inventory = Inventory;
    OnStored.Broadcast(Inventory);
}

void UStoreableComponent::Drop()
{
    AActor* Owner = GetOwner();
    Owner->SetActorEnableCollision(true);
    Owner->SetActorHiddenInGame(false);
    Owner->SetActorTickEnabled(true);

    OnDropped.Broadcast(Inventory);
}