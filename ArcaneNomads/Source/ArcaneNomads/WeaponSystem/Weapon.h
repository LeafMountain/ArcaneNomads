// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Weapon.generated.h"

UCLASS()
class ARCANENOMADS_API AWeapon : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AWeapon();

	// Seconds between each shot
	UPROPERTY(EditAnywhere)
	float FireRate = 1;

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;
	
	UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = "Mesh")
	class USkeletalMeshComponent* MeshComponent;

	FTimerHandle cooldownTimerHandle;

	bool OnCooldown;
	bool Active;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	// Use Tool
	UFUNCTION(BlueprintCallable)
	void Use();

	UFUNCTION(BlueprintCallable)
		void StopUse();

	void ResetTimer();

	UFUNCTION(BlueprintNativeEvent, BlueprintCallable)
	void OnUse();

	//inline bool OnCooldown()
	//{
	//	UE_LOG(LogTemp, Warning, TEXT("log %f"), GetWorld()->GetTimerManager().GetTimerRemaining(cooldownTimerHandle));
	//	return GetWorld()->GetTimerManager().GetTimerRemaining(cooldownTimerHandle) == 0;
	//};

protected:
	virtual void OnUseInternal();
};
