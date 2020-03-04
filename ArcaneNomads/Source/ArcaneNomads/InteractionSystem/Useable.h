#pragma once

#include "CoreMinimal.h"
#include "UObject/Interface.h"
#include "Useable.generated.h"

UINTERFACE(Blueprintable)
class ARCANENOMADS_API UUseable : public UInterface
{
	GENERATED_BODY()
};

class ARCANENOMADS_API IUseable
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Useable")
	void Use(class AActor* anActor);

	//UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Interactable")
	//void StartFocus();

	//UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Interactable")
	//void StopFocus();

	//UFUNCTION(BlueprintImplementableEvent, BlueprintCallable, Category = "Interactable")
	//void Interact(class UInteractorComponent* Interactor);
};
