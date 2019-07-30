#include "HealthComponent.h"
#include "DamagerComponent.h"

UHealthComponent::UHealthComponent()
{
}

void UHealthComponent::BeginPlay()
{
	CurrentHealth = MaxHealth;
}

void UHealthComponent::ApplyDamage(int Value, AActor* Instagator)
{
	//UE_LOG(LogTemp, Warning, TEXT("Damage received"));
	Value = FMath::Clamp(Value, 0, MaxHealth);
	AdjustHealth(-Value, Instagator);
}

void UHealthComponent::ApplyHealing(int Value, AActor* Instagator)
{
	Value = FMath::Clamp(Value, 0, MaxHealth);
	AdjustHealth(Value, Instagator);
}

void UHealthComponent::AdjustHealth(int Value, AActor* Instagator)
{
	CurrentHealth = CurrentHealth + Value;
	CurrentHealth = FMath::Clamp(CurrentHealth, 0, MaxHealth);

	if (CurrentHealth == 0)
		OnDeath.Broadcast(Instagator);

	OnHit.Broadcast(Value, Instagator);
}
