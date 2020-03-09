// Fill out your copyright notice in the Description page of Project Settings.

#include "InventoryWidget.h"
#include "InventoryComponent.h"

void UInventoryWidget::BeginDestroy()
{
	if (myInventory != nullptr)
	{
		myInventory->OnInventoryUpdated.RemoveDynamic(this, &UInventoryWidget::OnInventoryUpdated);
	}

	Super::BeginDestroy();
}

void UInventoryWidget::SetupInventory(UInventoryComponent* anInventory)
{
	myInventory = anInventory;
	myInventory->OnInventoryUpdated.AddDynamic(this, &UInventoryWidget::OnInventoryUpdated);
	OnInventoryUpdated();
}

void UInventoryWidget::OnInventoryUpdated()
{
	OnInventorySetup(myInventory);
}

void UInventoryWidget::OnInventorySetup_Implementation(UInventoryComponent* anInventory){}
