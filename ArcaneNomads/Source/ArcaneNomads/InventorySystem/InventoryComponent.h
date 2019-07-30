#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "InventoryComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE(FInventoryEvent);
DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FInventoryEventOne, class UStoreableComponent*, Storeable);

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UInventoryComponent : public UActorComponent
{
    GENERATED_BODY()

public:
    UInventoryComponent();

protected:
	virtual void BeginPlay() override;

    // Size of the inventory
    UPROPERTY(EditAnywhere)
    int Size = 10;

    class UStoreableComponent* Inventory[100];

public:
    // Put storeable in inventory
    UFUNCTION(BlueprintCallable)
    void Deposit(class UStoreableComponent *Item);

    // Withdraw item wit index
    UFUNCTION(BlueprintCallable)
    class UStoreableComponent* Withdraw(int Index);

    // Get inventory items
    UFUNCTION(BlueprintCallable)
    class UStoreableComponent* GetInventory();

    // Get UInventoryComponent::the number of items currently in the inventory
    UFUNCTION(BlueprintPure)
    int GetNumberOfItemsInInventory();

    UFUNCTION(BlueprintCallable)
    class UStoreableComponent* GetItemAt(int Index);

    UPROPERTY(BlueprintAssignable)
    FInventoryEvent OnInventoryUpdated;
};