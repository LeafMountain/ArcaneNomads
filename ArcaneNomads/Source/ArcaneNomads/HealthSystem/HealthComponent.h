#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "HealthComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE_TwoParams(FHitEventTwo, int, Damage, class AActor *, Instagator);
DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FHitEventOne, class AActor*, Instagator);


UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UHealthComponent : public UActorComponent
{
	GENERATED_BODY()

public:
	UHealthComponent();

private:
	int CurrentHealth;

protected:

	UPROPERTY(EditAnywhere)
	int MaxHealth = 1;

	virtual void BeginPlay() override;

public:
	UFUNCTION(BlueprintCallable)
	inline int GetCurrentHealth() { return CurrentHealth; }

	UFUNCTION(BlueprintCallable)
	inline int GetMaxHealth() { return MaxHealth; }

	UFUNCTION(BlueprintCallable)
	inline float GetHealthPercentage() { return CurrentHealth / MaxHealth; }

	// Reduce current health by amount
	UFUNCTION(BlueprintCallable)
	void ApplyDamage(int value, class AActor* Instagator);

	// Increase current health by amount
	UFUNCTION(BlueprintCallable)
	void ApplyHealing(int value, class AActor* Instagator);

	// Add value to current health
	UFUNCTION(BlueprintCallable)
	void AdjustHealth(int value, class AActor* Instagator);

	UPROPERTY(BlueprintAssignable)
	FHitEventTwo OnHit;

	UPROPERTY(BlueprintAssignable)
	FHitEventOne OnDeath;
};