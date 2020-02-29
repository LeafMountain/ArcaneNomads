#include "InteractorComponent.h"
#include <CollisionQueryParams.h>
#include <ArcaneNomads\InteractionSystem\InteractableComponent.h>
#include <Engine/EngineBaseTypes.h>

UInteractorComponent::UInteractorComponent()
{
	PrimaryComponentTick.bCanEverTick = true;
}

void UInteractorComponent::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);

	FCollisionQueryParams CollisionParameters;
	CollisionParameters.AddIgnoredActor(GetOwner());

	//GetWorld()->GetFirstPlayerController()->Camera();
	FVector CameraForward = FVector::ZeroVector;

	if(GEngine != nullptr)
		CameraForward = GEngine->GetFirstLocalPlayerController(GetWorld())->PlayerCameraManager->GetActorForwardVector();

	FHitResult HitResult;
	FVector StartLocation = GetOwner()->GetActorLocation();	
	FVector EndLocation = StartLocation + CameraForward * Range;

	if (GetWorld()->LineTraceSingleByChannel(HitResult, StartLocation, EndLocation, ECC_WorldDynamic, CollisionParameters))
	{
		auto LookInteractables = HitResult.Actor->GetComponentsByInterface(UInteractable::StaticClass());

		if (LookInteractables.Num() > 0)
		{
			if (HitResult.Actor != CurrentFocusedInteractable)
			{
				if (CurrentFocusedInteractable != nullptr)
					EndFocus();

				if (HitResult.Actor != nullptr)
					StartFocus(HitResult.Actor.Get());

				CurrentFocusedInteractable = HitResult.Actor.Get();
			}
		}
	}
}

bool UInteractorComponent::LookingAtInteractable()
{
	return CurrentFocusedInteractable != nullptr;
}

AActor* UInteractorComponent::GetInteractable()
{
	return CurrentFocusedInteractable;
}

bool UInteractorComponent::Interact()
{
	if (CurrentFocusedInteractable == nullptr)
		return false;

	TArray<UActorComponent*> interactable = CurrentFocusedInteractable->GetComponentsByInterface(UInteractable::StaticClass());

	for (auto it = interactable.CreateIterator(); it; ++it)
	{
		IInteractable::Execute_Interact(*it, this);
	}

	return true;
}

void UInteractorComponent::StartFocus(AActor* anActor)
{
	if (anActor == nullptr)
		return;

	TArray<UActorComponent*> interactables = anActor->GetComponentsByInterface(UInteractable::StaticClass());

	for (auto it = interactables.CreateIterator(); it; ++it)
	{
		IInteractable::Execute_StartFocus(*it);
	}
}

void UInteractorComponent::EndFocus()
{
	if (CurrentFocusedInteractable == nullptr)
		return;

	TArray<UActorComponent*> interactables = CurrentFocusedInteractable->GetComponentsByInterface(UInteractable::StaticClass());

	for (auto it = interactables.CreateIterator(); it; ++it)
	{
		IInteractable::Execute_StopFocus(*it);
	}
}

