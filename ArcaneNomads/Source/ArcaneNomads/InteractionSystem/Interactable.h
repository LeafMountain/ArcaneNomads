#pragma once

#include "CoreMinimal.h"
#include "UObject/Interface.h"
#include "Interactable.generated.h"

UINTERFACE(Blueprintable)
class ARCANENOMADS_API UInteractable : public UInterface
{
	GENERATED_BODY()
};

class ARCANENOMADS_API IInteractable
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Interactable")
	void Interact(class UInteractorComponent* Interactor);

	UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Interactable")
	void StartFocus();

	UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Interactable")
	void StopFocus();

	//UFUNCTION(BlueprintImplementableEvent, BlueprintCallable, Category = "Interactable")
	//void Interact(class UInteractorComponent* Interactor);
};
