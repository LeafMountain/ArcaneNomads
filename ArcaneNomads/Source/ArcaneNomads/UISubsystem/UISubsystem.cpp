// Fill out your copyright notice in the Description page of Project Settings.

#include "UISubsystem.h"

UUserWidget* UUISubsystem::OpenWidget(TSubclassOf<UUserWidget> aWidget, bool unlockMouse)
{
	if (aWidget.Get() == nullptr)
	{
		return nullptr;
	}

	int widgetIndex = myWidgets.Emplace(CreateWidget<UUserWidget>(GetWorld(), aWidget));
	myWidgets[widgetIndex]->AddToViewport();

	if (unlockMouse)
	{
		GetWorld()->GetFirstPlayerController()->bShowMouseCursor = true;
	}

	return myWidgets[widgetIndex];
}

void UUISubsystem::CloseAll()
{
	UE_LOG(LogTemp, Log, TEXT("Trying to close all open widgets."));

	for (int i = myWidgets.Num() - 1; i >= 0; --i)
	{
		myWidgets[i]->RemoveFromViewport();
		myWidgets.Pop();
	}
}

void UUISubsystem::CloseTop()
{
	if (myWidgets.Num() <= 0)
		return;

	UUserWidget* widget = myWidgets.Pop();	// Should remove the last element
	widget->RemoveFromViewport();
}
