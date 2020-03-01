// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/InteractionSystem/InteractorComponent.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeInteractorComponent() {}
// Cross Module References
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ENGINE_API UClass* Z_Construct_UClass_AActor_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UInteractorComponent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UInteractorComponent();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UInteractorComponent_GetInteractable();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UInteractableComponent_NoRegister();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UInteractorComponent_Interact();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable();
// End Cross Module References
	struct Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics
	{
		struct _Script_ArcaneNomads_eventInteractionEventOne_Parms
		{
			AActor* Interactable;
		};
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Interactable;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::NewProp_Interactable = { "Interactable", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(_Script_ArcaneNomads_eventInteractionEventOne_Parms, Interactable), Z_Construct_UClass_AActor_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::NewProp_Interactable,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::FuncParams = { (UObject*(*)())Z_Construct_UPackage__Script_ArcaneNomads, nullptr, "InteractionEventOne__DelegateSignature", nullptr, nullptr, sizeof(_Script_ArcaneNomads_eventInteractionEventOne_Parms), Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x00130000, 0, 0, METADATA_PARAMS(Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	void UInteractorComponent::StaticRegisterNativesUInteractorComponent()
	{
		UClass* Class = UInteractorComponent::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "GetInteractable", &UInteractorComponent::execGetInteractable },
			{ "Interact", &UInteractorComponent::execInteract },
			{ "LookingAtInteractable", &UInteractorComponent::execLookingAtInteractable },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics
	{
		struct InteractorComponent_eventGetInteractable_Parms
		{
			UInteractableComponent* ReturnValue;
		};
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_ReturnValue_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::NewProp_ReturnValue_MetaData[] = {
		{ "EditInline", "true" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000080588, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(InteractorComponent_eventGetInteractable_Parms, ReturnValue), Z_Construct_UClass_UInteractableComponent_NoRegister, METADATA_PARAMS(Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::NewProp_ReturnValue_MetaData, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::NewProp_ReturnValue_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UInteractorComponent, nullptr, "GetInteractable", nullptr, nullptr, sizeof(InteractorComponent_eventGetInteractable_Parms), Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UInteractorComponent_GetInteractable()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UInteractorComponent_GetInteractable_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UInteractorComponent_Interact_Statics
	{
		struct InteractorComponent_eventInteract_Parms
		{
			bool ReturnValue;
		};
		static void NewProp_ReturnValue_SetBit(void* Obj);
		static const UE4CodeGen_Private::FBoolPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	void Z_Construct_UFunction_UInteractorComponent_Interact_Statics::NewProp_ReturnValue_SetBit(void* Obj)
	{
		((InteractorComponent_eventInteract_Parms*)Obj)->ReturnValue = 1;
	}
	const UE4CodeGen_Private::FBoolPropertyParams Z_Construct_UFunction_UInteractorComponent_Interact_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Bool | UE4CodeGen_Private::EPropertyGenFlags::NativeBool, RF_Public|RF_Transient|RF_MarkAsNative, 1, sizeof(bool), sizeof(InteractorComponent_eventInteract_Parms), &Z_Construct_UFunction_UInteractorComponent_Interact_Statics::NewProp_ReturnValue_SetBit, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UInteractorComponent_Interact_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UInteractorComponent_Interact_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UInteractorComponent_Interact_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UInteractorComponent_Interact_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UInteractorComponent, nullptr, "Interact", nullptr, nullptr, sizeof(InteractorComponent_eventInteract_Parms), Z_Construct_UFunction_UInteractorComponent_Interact_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_Interact_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UInteractorComponent_Interact_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_Interact_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UInteractorComponent_Interact()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UInteractorComponent_Interact_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics
	{
		struct InteractorComponent_eventLookingAtInteractable_Parms
		{
			bool ReturnValue;
		};
		static void NewProp_ReturnValue_SetBit(void* Obj);
		static const UE4CodeGen_Private::FBoolPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	void Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::NewProp_ReturnValue_SetBit(void* Obj)
	{
		((InteractorComponent_eventLookingAtInteractable_Parms*)Obj)->ReturnValue = 1;
	}
	const UE4CodeGen_Private::FBoolPropertyParams Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Bool | UE4CodeGen_Private::EPropertyGenFlags::NativeBool, RF_Public|RF_Transient|RF_MarkAsNative, 1, sizeof(bool), sizeof(InteractorComponent_eventLookingAtInteractable_Parms), &Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::NewProp_ReturnValue_SetBit, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UInteractorComponent, nullptr, "LookingAtInteractable", nullptr, nullptr, sizeof(InteractorComponent_eventLookingAtInteractable_Parms), Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UInteractorComponent_NoRegister()
	{
		return UInteractorComponent::StaticClass();
	}
	struct Z_Construct_UClass_UInteractorComponent_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_OnInteracted_MetaData[];
#endif
		static const UE4CodeGen_Private::FMulticastDelegatePropertyParams NewProp_OnInteracted;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Range_MetaData[];
#endif
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_Range;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UInteractorComponent_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UInteractorComponent_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UInteractorComponent_GetInteractable, "GetInteractable" }, // 1671904590
		{ &Z_Construct_UFunction_UInteractorComponent_Interact, "Interact" }, // 2693310111
		{ &Z_Construct_UFunction_UInteractorComponent_LookingAtInteractable, "LookingAtInteractable" }, // 3467349165
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UInteractorComponent_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "InteractionSystem/InteractorComponent.h" },
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UInteractorComponent_Statics::NewProp_OnInteracted_MetaData[] = {
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FMulticastDelegatePropertyParams Z_Construct_UClass_UInteractorComponent_Statics::NewProp_OnInteracted = { "OnInteracted", nullptr, (EPropertyFlags)0x0010000010080000, UE4CodeGen_Private::EPropertyGenFlags::InlineMulticastDelegate, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UInteractorComponent, OnInteracted), Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature, METADATA_PARAMS(Z_Construct_UClass_UInteractorComponent_Statics::NewProp_OnInteracted_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UInteractorComponent_Statics::NewProp_OnInteracted_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UInteractorComponent_Statics::NewProp_Range_MetaData[] = {
		{ "Category", "InteractorComponent" },
		{ "ModuleRelativePath", "InteractionSystem/InteractorComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UClass_UInteractorComponent_Statics::NewProp_Range = { "Range", nullptr, (EPropertyFlags)0x0010000000000001, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UInteractorComponent, Range), METADATA_PARAMS(Z_Construct_UClass_UInteractorComponent_Statics::NewProp_Range_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UInteractorComponent_Statics::NewProp_Range_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UInteractorComponent_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UInteractorComponent_Statics::NewProp_OnInteracted,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UInteractorComponent_Statics::NewProp_Range,
	};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UInteractorComponent_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UInteractorComponent>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UInteractorComponent_Statics::ClassParams = {
		&UInteractorComponent::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		Z_Construct_UClass_UInteractorComponent_Statics::PropPointers,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		UE_ARRAY_COUNT(Z_Construct_UClass_UInteractorComponent_Statics::PropPointers),
		0,
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UInteractorComponent_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UInteractorComponent_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UInteractorComponent()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UInteractorComponent_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UInteractorComponent, 1738629002);
	template<> ARCANENOMADS_API UClass* StaticClass<UInteractorComponent>()
	{
		return UInteractorComponent::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UInteractorComponent(Z_Construct_UClass_UInteractorComponent, &UInteractorComponent::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UInteractorComponent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UInteractorComponent);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
