#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "InteractableComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FOnInteractedOne, class UInteractorComponent*, Interactor);

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UInteractableComponent : public UActorComponent
{
	GENERATED_BODY()

public:
	UInteractableComponent();

	UFUNCTION(BlueprintCallable, Category = "Interactable")
	void Interact(class UInteractorComponent* Interactor);

	UFUNCTION(BlueprintCallable, Category = "Interactable")
	void Focus(class UInteractorComponent* Interactor);

	UFUNCTION(BlueprintCallable, Category = "Interactable")
	void Unfocus(class UInteractorComponent* Interactor);

	UPROPERTY(BlueprintAssignable)
	FOnInteractedOne OnInteracted;

	UPROPERTY(BlueprintAssignable)
	FOnInteractedOne OnFocused;

	UPROPERTY(BlueprintAssignable)
	FOnInteractedOne OnUnfocused;
};