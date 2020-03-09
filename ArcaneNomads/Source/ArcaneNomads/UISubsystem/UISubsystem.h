// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include <Array.h>
#include <UserWidget.h>
#include "UISubsystem.generated.h"

/**
 * 
 */
UCLASS()
class ARCANENOMADS_API UUISubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()

private:

	TArray<class UUserWidget*> myWidgets;

public:

	// Open a UI and add it to a list
	UFUNCTION(BlueprintCallable)
	class UUserWidget* OpenWidget(TSubclassOf<UUserWidget> aWidget, bool unlockMouse = false);

	// Close all UI
	UFUNCTION(BlueprintCallable)
	void CloseAll();

	// Close top UI
	UFUNCTION(BlueprintCallable)
	void CloseTop();
};
