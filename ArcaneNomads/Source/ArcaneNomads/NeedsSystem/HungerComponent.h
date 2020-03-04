#pragma once

#include "Components/ActorComponent.h"
#include "HungerComponent.generated.h"

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UHungerComponnent : public UActorComponent
{
	GENERATED_BODY()

protected:
	UHungerComponnent();
	//virtual void TickComponent(float DeltaTime, enum ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction) override;
	virtual void BeginPlay() override;
	virtual void EndPlay(EEndPlayReason::Type EndReason) override;
	void Decay();

private:

	float myHunger = 1;	// 1 = not hungry, 0 = starving
	//float myDecayRate = .05f;
	float myDecayMultiplier = 1;

	UPROPERTY(EditDefaultsOnly)
	float myTimeUntilDepletedFromFullHealth = 60;

	FTimerHandle myDecayTimerHandle;

public:

	UFUNCTION(BlueprintPure)
	FORCEINLINE float GetHunger() { return myHunger; }

	UFUNCTION(BlueprintPure)
	FORCEINLINE float GetDecayRate() { return (1.f / myTimeUntilDepletedFromFullHealth) * myDecayMultiplier; } // Value reduced each second

	UFUNCTION(BlueprintPure)
	FORCEINLINE float GetDecayMultiplier() { return myDecayMultiplier; }

	UFUNCTION(BlueprintCallable)
	void SetDecayMultiplier(float aMultiplier);

	UFUNCTION(BlueprintCallable)
	void ResetDecayMultiplier();

	UFUNCTION(BlueprintCallable)
	void SetTimeUntilDepleted(float aTimeInSeconds);

	UFUNCTION(BlueprintPure)
	FORCEINLINE float GetTimeRemaining() { return GetHunger() / GetDecayRate(); }

	void Eat(float aValue);	// Should take in an edible 

	bool IsFull() { return myHunger == 1; }

};