#include "InteractableComponent.h"
#include "InteractorComponent.h"
#include "Interactable.h"

UInteractableComponent::UInteractableComponent()
{

}

void UInteractableComponent::Interact(UInteractorComponent* Interactor)
{
	OnInteracted.Broadcast(Interactor);
	TArray<UActorComponent*> interactableComponents = GetOwner()->GetComponentsByInterface(UInteractable::StaticClass());
	for (auto it = interactableComponents.CreateIterator(); it; ++it)
	{
		IInteractable::Execute_Interact(*it, Interactor);
	}
}

void UInteractableComponent::Focus(class UInteractorComponent* Interactor)
{
	OnFocused.Broadcast(Interactor);
	TArray<UActorComponent*> interactableComponents = GetOwner()->GetComponentsByInterface(UInteractable::StaticClass());
	for (auto it = interactableComponents.CreateIterator(); it; ++it)
	{
		IInteractable::Execute_StartFocus(*it);
	}
}

void UInteractableComponent::Unfocus(class UInteractorComponent* Interactor)
{
	OnUnfocused.Broadcast(Interactor);
	TArray<UActorComponent*> interactableComponents = GetOwner()->GetComponentsByInterface(UInteractable::StaticClass());
	for (auto it = interactableComponents.CreateIterator(); it; ++it)
	{
		IInteractable::Execute_StopFocus(*it);
	}
}

