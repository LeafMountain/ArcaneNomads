#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "DamagerComponent.generated.h"

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UDamagerComponent : public UActorComponent
{
	GENERATED_BODY()

public:
	UDamagerComponent();

protected:

	UPROPERTY(EditAnywhere)
	int DamageValue;

	class AActor* Owner;

public:
	UFUNCTION(BlueprintCallable)
	void Damage(class AActor* OtherActor);

	UFUNCTION(BlueprintCallable)
		void SetOwner(class AActor* Owner);
	// On hit event
};