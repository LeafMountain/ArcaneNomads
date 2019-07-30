#include "DamagerComponent.h"
#include <ArcaneNomads\HealthSystem\HealthComponent.h>
#include "GameFramework/Actor.h"

UDamagerComponent::UDamagerComponent()
{
}

void UDamagerComponent::Damage(AActor *Target)
{
	if (Target != nullptr)
	{
		UHealthComponent *TargetHealth = Cast<UHealthComponent>(Target->GetComponentByClass(UHealthComponent::StaticClass()));
		if (TargetHealth != nullptr)
		{
			TargetHealth->ApplyDamage(DamageValue, GetOwner()->GetOwner());
		}
	}
}

void UDamagerComponent::SetOwner(class AActor* Owner)
{
	this->Owner = Owner;
}
