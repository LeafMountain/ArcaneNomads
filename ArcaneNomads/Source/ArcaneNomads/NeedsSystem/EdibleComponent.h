#pragma once

#include "Components/ActorComponent.h"
#include "InteractionSystem/Useable.h"
#include "EdibleComponent.generated.h"

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UEdibleComponent : public UActorComponent, public IUseable
{
	GENERATED_BODY()

protected:
	virtual void Use_Implementation(class AActor* anActor) override;

	UPROPERTY(EditDefaultsOnly)
	float myHungerReduction = .01f;

public:

	UFUNCTION(BlueprintPure)
	FORCEINLINE float GetHungerReduction() { return myHungerReduction; }
};