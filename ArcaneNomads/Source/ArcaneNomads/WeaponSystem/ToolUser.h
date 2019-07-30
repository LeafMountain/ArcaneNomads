// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "ToolUser.generated.h"

UCLASS(ClassGroup = (Custom), meta = (BlueprintSpawnableComponent))
class ARCANENOMADS_API UToolUser : public UActorComponent
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	UToolUser();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

	class AWeapon* EquippedTool;

	bool Using;

public:	
	// Called every frame
	virtual void TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction) override;

	// Equip a new tool
	UFUNCTION(BlueprintCallable)
	void Equip(class AWeapon* Tool, class USceneComponent* Parent, FName SocketName = "RightHandSocket");	// Skip the socket name later for something else

	// Unequip the current tool
	UFUNCTION(BlueprintCallable)
	class AWeapon* Unequip();

	// Use the current tool
	UFUNCTION(BlueprintCallable)
	void Use();

	UFUNCTION(BlueprintCallable)
	void UseActivate();

	UFUNCTION(BlueprintCallable)
	void UseInactivate();

	UPROPERTY(BlueprintReadOnly)
	bool IsEquipped;

	//// The mesh to attach tool to
	//UPROPERTY(VisibleAnywhere, BlueprintReadOnly)
	//class USceneComponent* Parent;

	//// Name of the socket where the tool is to attach
	//UPROPERTY(EditAnywhere)
	//	FName SocketName = "WeaponSocket";

};
