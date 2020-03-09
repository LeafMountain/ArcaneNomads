// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "InventoryWidget.generated.h"

/**
 * 
 */
UCLASS()
class ARCANENOMADS_API UInventoryWidget : public UUserWidget
{
	GENERATED_BODY()

protected:
	virtual void BeginDestroy() override;

public:
	UPROPERTY(EditDefaultsOnly)
	TArray<class UUserWidget*> mySlots;

	UPROPERTY(BlueprintReadOnly)
	class UInventoryComponent* myInventory;

	UFUNCTION(BlueprintCallable)
	void SetupInventory(class UInventoryComponent* anInventory);

	void OnInventoryUpdated();

	UFUNCTION(BlueprintNativeEvent, BlueprintCallable)
	void OnInventorySetup(class UInventoryComponent* anInventory);
};
