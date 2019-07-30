// Fill out your copyright notice in the Description page of Project Settings.


#include "PlayerCharacter.h"
#include "Classes/Components/CapsuleComponent.h"
#include "Classes/Camera/CameraComponent.h"
#include "Classes/Components/SkeletalMeshComponent.h"

void APlayerCharacter::MoveForward(float value)
{
	AddMovementInput(GetActorForwardVector() * value);
	UE_LOG(LogTemp, Warning, TEXT("Moving forward"));
}

void APlayerCharacter::MoveRight(float value)
{
	AddMovementInput(GetActorRightVector() * value);
	UE_LOG(LogTemp, Warning, TEXT("Moving Right"));
}

// Sets default values
APlayerCharacter::APlayerCharacter()
{
 	// Set this pawn to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
	//PrimaryActorTick.bStartWithTickEnabled = true;

	//Collider = CreateDefaultSubobject<UCapsuleComponent>(TEXT("Collider"));
	//RootComponent = Collider;
	//Camera = CreateDefaultSubobject<UCameraComponent>(TEXT("Camera"));
	//Camera->SetWorldLocation(FVector(0.0f, 0.0f, 100.0f));
	//Camera->AttachToComponent(RootComponent, FAttachmentTransformRules::KeepRelativeTransform);
	//Mesh = CreateDefaultSubobject<USkeletalMeshComponent>(TEXT("Skeletal Mesh"));
}

// Called when the game starts or when spawned
void APlayerCharacter::BeginPlay()
{
	Super::BeginPlay();


	
}

// Called every frame
void APlayerCharacter::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
	//UE_LOG(LogTemp, Warning, TEXT("Moving Right"));

}

// Called to bind functionality to input
void APlayerCharacter::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);
	UE_LOG(LogTemp, Warning, TEXT("Binding input"));

	PlayerInputComponent->BindAxis("MoveForward", this, &APlayerCharacter::MoveForward);
	PlayerInputComponent->BindAxis("MoveRight", this, &APlayerCharacter::MoveRight);
	PlayerInputComponent->BindAction("Fire", IE_Pressed, this, &APlayerCharacter::Test);

}

void APlayerCharacter::Test()
{
	UE_LOG(LogTemp, Warning, TEXT("Hello"));
}

