#include "HungerComponent.h"

UHungerComponnent::UHungerComponnent()
{
	//PrimaryComponentTick.bCanEverTick = true;
	//PrimaryComponentTick.bStartWithTickEnabled = true;
}

//void UHungerComponnent::TickComponent(float DeltaTime, enum ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
//{
//	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
//
//
//}

void UHungerComponnent::BeginPlay()
{
	if (GetWorld())
	{
		GetWorld()->GetTimerManager().SetTimer(myDecayTimerHandle, this, &UHungerComponnent::Decay, 1);
	}
}

void UHungerComponnent::EndPlay(EEndPlayReason::Type EndReason)
{
	if (GetWorld())
	{
		GetWorld()->GetTimerManager().ClearTimer(myDecayTimerHandle);
	}
}

void UHungerComponnent::Decay()
{
	GEngine->AddOnScreenDebugMessage(-1, 1.f, FColor::Green, FString::Printf(TEXT("My hunger is: %f"), myHunger));
	myHunger -= GetDecayRate();
	myHunger = FMath::Clamp(myHunger, 0.f, 1.f);
	GetWorld()->GetTimerManager().SetTimer(myDecayTimerHandle, this, &UHungerComponnent::Decay, 1);
}

void UHungerComponnent::SetDecayMultiplier(float aMultiplier)
{
	myDecayMultiplier = FMath::Clamp(aMultiplier, 0.f, 100.f);
}

void UHungerComponnent::ResetDecayMultiplier()
{
	myDecayMultiplier = 1;
}

void UHungerComponnent::SetTimeUntilDepleted(float aTimeInSeconds)
{
	myTimeUntilDepletedFromFullHealth = aTimeInSeconds;
}

void UHungerComponnent::Eat(float aValue)
{
	myHunger += aValue;
	myHunger = FMath::Clamp(myHunger, 0.f, 1.f);
}
