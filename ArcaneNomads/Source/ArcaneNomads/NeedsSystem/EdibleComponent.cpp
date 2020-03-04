#include "EdibleComponent.h"
#include "NeedsSystem/HungerComponent.h"
#include <GameFramework/Actor.h>

void UEdibleComponent::Use_Implementation(AActor* anActor)
{
	if (anActor == nullptr)
		return;

	GEngine->AddOnScreenDebugMessage(-1, 10.f, FColor::Green, TEXT("You tried to eat me"));
	UHungerComponnent* hungerComponent = Cast<UHungerComponnent>(anActor->GetComponentByClass(UHungerComponnent::StaticClass()));
	if (hungerComponent && !hungerComponent->IsFull())
	{
		hungerComponent->Eat(myHungerReduction);
		GetWorld()->DestroyActor(GetOwner());
	}
}
