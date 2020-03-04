#include "StoreableComponent.h"
#include "InventoryComponent.h"
#include "InteractionSystem/InteractorComponent.h"

UStoreableComponent::UStoreableComponent()
{
    
}

void UStoreableComponent::EndPlay(EEndPlayReason::Type Reason)
{
    Drop();
    Super::EndPlay(Reason);
}

void UStoreableComponent::Store(UInventoryComponent* Inventory)
{
    AActor* Owner = GetOwner();

    if (Inventory == nullptr || Owner == nullptr)
    {
        return;
    }

    Owner->SetActorEnableCollision(false);
    Owner->SetActorHiddenInGame(true);
    Owner->SetActorTickEnabled(false);
    
    this->Inventory = Inventory;

    OnStored.Broadcast(Inventory);
}

void UStoreableComponent::Drop()
{
    AActor* Owner = GetOwner();

    if (Owner == nullptr)
        return;

    Owner->SetActorEnableCollision(true);
    Owner->SetActorHiddenInGame(false);
    Owner->SetActorTickEnabled(true);

    if (Inventory != nullptr)
    {
        if (Inventory->Contains(this))
        {
            Inventory->Withdraw(this);
        }
        Inventory = nullptr;
    }

    OnDropped.Broadcast(Inventory);
}

void UStoreableComponent::Interact_Implementation(UInteractorComponent* aInteractor)
{
	GEngine->AddOnScreenDebugMessage(-1, 10.f, FColor::Red, TEXT("Interacting"));
    UInventoryComponent* inventory = CastChecked<UInventoryComponent>(aInteractor->GetOwner()->GetComponentByClass(UInventoryComponent::StaticClass()));

    if (inventory)
    {
        inventory->Deposit(this);
    }
}

void UStoreableComponent::StartFocus_Implementation()
{
    GEngine->AddOnScreenDebugMessage(-1, 10.f, FColor::Red, TEXT("Start Focusing"));
}

void UStoreableComponent::StopFocus_Implementation()
{
	GEngine->AddOnScreenDebugMessage(-1, 10.f, FColor::Red, TEXT("Stop Focusing"));
}