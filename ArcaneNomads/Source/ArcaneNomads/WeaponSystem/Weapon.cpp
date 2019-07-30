// Fill out your copyright notice in the Description page of Project Settings.


#include "Weapon.h"
#include "Classes/Components/SkeletalMeshComponent.h"

// Sets default values
AWeapon::AWeapon()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

	MeshComponent = CreateDefaultSubobject<USkeletalMeshComponent>(TEXT("Mesh"));
	RootComponent = MeshComponent;
}

// Called when the game starts or when spawned
void AWeapon::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void AWeapon::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void AWeapon::Use()
{
	Active = true;

	if (!OnCooldown)
	{
		OnUse();
		GetWorld()->GetTimerManager().SetTimer(cooldownTimerHandle, this, &AWeapon::ResetTimer, FireRate, false);
		OnCooldown = true;
	}

}

void AWeapon::StopUse()
{
	Active = false;
}

void AWeapon::ResetTimer()
{
	OnCooldown = false;
}

void AWeapon::OnUse_Implementation()
{
	OnUseInternal();
}

void AWeapon::OnUseInternal()
{
	UE_LOG(LogTemp, Warning, TEXT("[Weapon] Using weapon"));
}

