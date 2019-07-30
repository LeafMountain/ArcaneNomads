#include "InteractableComponent.h"
#include "InteractorComponent.h"

UInteractableComponent::UInteractableComponent()
{

}

void UInteractableComponent::Interact(UInteractorComponent* Interactor)
{
	OnInteracted.Broadcast(Interactor);
}

void UInteractableComponent::Focus(class UInteractorComponent* Interactor)
{
	OnFocused.Broadcast(Interactor);
}

void UInteractableComponent::Unfocus(class UInteractorComponent* Interactor)
{
	OnUnfocused.Broadcast(Interactor);
}

