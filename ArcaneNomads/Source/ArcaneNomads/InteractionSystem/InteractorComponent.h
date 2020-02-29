#pragma once

#include "Components/ActorComponent.h"
#include "InteractionSystem/Interactable.h"
#include "InteractorComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FInteractionEventOne, class AActor*, Interactable);

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UInteractorComponent : public UActorComponent
{
	GENERATED_BODY()

public:
	UInteractorComponent();

protected:

	virtual void TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction) override;

	class AActor* CurrentFocusedInteractable;

public:
	UPROPERTY(EditAnywhere)
		float Range = 100.0f;

	UFUNCTION(BlueprintCallable)
	bool LookingAtInteractable();

	UFUNCTION(BlueprintCallable)
	class AActor* GetInteractable();

	UFUNCTION(BlueprintCallable)
	bool Interact();

	UPROPERTY(BlueprintAssignable)
	FInteractionEventOne OnInteracted;

	void StartFocus(AActor* anActor);
	void EndFocus();
};