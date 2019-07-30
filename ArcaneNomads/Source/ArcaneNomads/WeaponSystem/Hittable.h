#pragma once

#include "Hittable.generated.h"

UINTERFACE(Blueprintable)
class ARCANENOMADS_API UHittable : public UInterface
{
	GENERATED_BODY()
};

class ARCANENOMADS_API IHittable
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintNativeEvent, BlueprintCallable, Category = "Hittable")
	void OnHit(int Damage, class AWeapon* Instagator);
};