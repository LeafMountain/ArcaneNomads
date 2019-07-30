// Fill out your copyright notice in the Description page of Project Settings.


#include "ToolUser.h"
#include "Weapon.h"
#include "Components/SkeletalMeshComponent.h"
#include <Components/SceneComponent.h>

// Sets default values
UToolUser::UToolUser()
{
	PrimaryComponentTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void UToolUser::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void UToolUser::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
	if (Using)
	{
		Use();
	}
}

void UToolUser::Equip(AWeapon* Tool, USceneComponent* Parent, FName SocketName)
{
	if (EquippedTool != nullptr)
	{
		Unequip();
	}

	if (Tool != nullptr)
	{
		Parent = Cast<USceneComponent>(GetOwner()->GetComponentByClass(USkeletalMeshComponent::StaticClass()));

		//if (Parent == nullptr) return;
		UE_LOG(LogTemp, Warning, TEXT("%s"), *Parent->GetName());


		EquippedTool = Tool;
		IsEquipped = true;
		FAttachmentTransformRules attachRules(
			EAttachmentRule::SnapToTarget, 
			EAttachmentRule::SnapToTarget, 
			EAttachmentRule::KeepRelative, 
			true
		);

		Tool->AttachToComponent(Parent, attachRules, SocketName);
	}
}

AWeapon* UToolUser::Unequip()
{
	AWeapon* OldEquippedTool = EquippedTool;
	EquippedTool = nullptr;
	IsEquipped = false;

	return OldEquippedTool;
}

void UToolUser::Use()
{
	if (EquippedTool != nullptr)
	{
		EquippedTool->Use();
	}
}

void UToolUser::UseActivate()
{
	Using = true;
}

void UToolUser::UseInactivate()
{
	Using = false;
}
