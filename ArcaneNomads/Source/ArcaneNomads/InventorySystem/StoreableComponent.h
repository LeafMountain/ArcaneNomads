#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "StoreableComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FStoreEvent, class UInventoryComponent*, Inventory);

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UStoreableComponent : public UActorComponent
{
    GENERATED_BODY()

public:
    UStoreableComponent();

protected:

    class UInventoryComponent* Inventory;
    
public:
    // Trigger when being stored
    UFUNCTION(BlueprintCallable)
    void Store(class UInventoryComponent* Inventory);

    // Trigger when dropped from inventory
    UFUNCTION(BlueprintCallable)
    void Drop();

    UPROPERTY(BlueprintAssignable)
    FStoreEvent OnStored;

    UPROPERTY(BlueprintAssignable)
    FStoreEvent OnDropped;
};