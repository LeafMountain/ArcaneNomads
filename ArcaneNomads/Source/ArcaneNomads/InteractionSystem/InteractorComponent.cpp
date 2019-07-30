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
	//GetWorld()->LineTraceSingleByChannel(HitResult, StartLocation, EndLocation, ECC_WorldDynamic, CollisionParameters);

	if (GetWorld()->LineTraceSingleByChannel(HitResult, StartLocation, EndLocation, ECC_WorldDynamic, CollisionParameters))
	{
		UInteractableComponent* LookInteractable = (UInteractableComponent*)HitResult.Actor->GetComponentByClass(UInteractableComponent::StaticClass());

		if (LookInteractable != nullptr && CurrentFocusedInteractable != LookInteractable)
		{
			if(CurrentFocusedInteractable != nullptr)
				CurrentFocusedInteractable->Unfocus(this);

			CurrentFocusedInteractable = LookInteractable;
			CurrentFocusedInteractable->Focus(this);
		}
	}
	else if(CurrentFocusedInteractable != nullptr)
	{
		CurrentFocusedInteractable->Unfocus(this);
		CurrentFocusedInteractable = nullptr;
	}
}

bool UInteractorComponent::LookingAtInteractable()
{
	return CurrentFocusedInteractable != nullptr;
}

UInteractableComponent* UInteractorComponent::GetInteractable()
{
	return CurrentFocusedInteractable;
}

bool UInteractorComponent::Interact()
{
	if(CurrentFocusedInteractable != nullptr)
		CurrentFocusedInteractable->Interact(this);

	return CurrentFocusedInteractable != nullptr;
}

