#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "InteractionSystem/Interactable.h"
#include <Engine/Texture2D.h>
#include "StoreableComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FStoreEvent, class UInventoryComponent*, Inventory);

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UStoreableComponent : public UActorComponent, public IInteractable
{
    GENERATED_BODY()

public:
    UStoreableComponent();


private:
    UPROPERTY(EditDefaultsOnly)
    FString myName = "NameMissing";

	UPROPERTY(EditAnywhere)
    UTexture2D* myIcon;

protected:

    virtual void BeginDestroy() override;

    class UInventoryComponent* Inventory;
    
public:
    UFUNCTION(BlueprintPure, Category = "Storeable")
    FString GetName() { return myName; };

    UFUNCTION(BlueprintPure, Category = "Storeable")
    UTexture2D* GetIcon() { return myIcon; };

    UFUNCTION(BlueprintCallable)
    void Store(class UInventoryComponent* Inventory);

    UFUNCTION(BlueprintCallable)
    void Drop();

    UPROPERTY(BlueprintAssignable)
    FStoreEvent OnStored;

    UPROPERTY(BlueprintAssignable)
    FStoreEvent OnDropped;

    void Interact_Implementation(class UInteractorComponent* aInteractor) override;
    void StartFocus_Implementation() override;
    void StopFocus_Implementation() override;
};