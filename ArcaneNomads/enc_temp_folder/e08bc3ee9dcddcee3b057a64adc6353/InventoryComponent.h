#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "InteractionSystem/Interactable.h"
#include "InventoryComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE(FInventoryEvent);
DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FInventoryEventOne, class UStoreableComponent*, Storeable);

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UInventoryComponent : public UActorComponent, public IInteractable
{
    GENERATED_BODY()

public:
    UInventoryComponent();

    void Interact_Implementation(class UInteractorComponent* Interactor) override;
    void StopFocus_Implementation() override;

protected:
	virtual void BeginPlay() override;

    // Size of the inventory
    UPROPERTY(EditAnywhere)
    int Size = 4;

    TArray<class UStoreableComponent*> myStoreables;

	UPROPERTY(EditDefaultsOnly)
	TSubclassOf<class UInventoryWidget> anInventoryWidget;

    class UUISubsystem* myUISubsystem;

    bool isOpen = false;
    class UInventoryWidget* myOpenInventoryWidget;

public:
    // Put storeable in inventory
    UFUNCTION(BlueprintCallable)
    void Deposit(class UStoreableComponent *Item);

    // Withdraw item wit index
    UFUNCTION(BlueprintCallable)
    class UStoreableComponent* WithdrawAt(int Index);

    UFUNCTION(BlueprintCallable)
    class UStoreableComponent* Withdraw(class UStoreableComponent* aStoreable);

    // Get inventory items
    UFUNCTION(BlueprintCallable)
    TArray<class UStoreableComponent*> GetInventory();

    // Get UInventoryComponent::the number of items currently in the inventory
    UFUNCTION(BlueprintPure)
    int GetNumberOfItemsInInventory();

    UFUNCTION(BlueprintCallable)
    class UStoreableComponent* GetItemAt(int Index);

    UPROPERTY(BlueprintAssignable)
    FInventoryEvent OnInventoryUpdated;

    UFUNCTION(BlueprintCallable)
	bool Contains(class UStoreableComponent* aStoreable);

    UFUNCTION(BlueprintPure)
    bool IsFull();

    UFUNCTION(BlueprintCallable)
    void Open();

    UFUNCTION(BlueprintCallable)
    void Close();

    UFUNCTION(BlueprintCallable)
    void Toggle();
};