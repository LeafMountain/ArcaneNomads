// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/InventorySystem/StoreableComponent.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeStoreableComponent() {}
// Cross Module References
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UInventoryComponent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UStoreableComponent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UStoreableComponent();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UStoreableComponent_Drop();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UStoreableComponent_Store();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UInteractable_NoRegister();
// End Cross Module References
	struct Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics
	{
		struct _Script_ArcaneNomads_eventStoreEvent_Parms
		{
			UInventoryComponent* Inventory;
		};
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Inventory_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Inventory;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::NewProp_Inventory_MetaData[] = {
		{ "EditInline", "true" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::NewProp_Inventory = { "Inventory", nullptr, (EPropertyFlags)0x0010000000080080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(_Script_ArcaneNomads_eventStoreEvent_Parms, Inventory), Z_Construct_UClass_UInventoryComponent_NoRegister, METADATA_PARAMS(Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::NewProp_Inventory_MetaData, UE_ARRAY_COUNT(Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::NewProp_Inventory_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::NewProp_Inventory,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::FuncParams = { (UObject*(*)())Z_Construct_UPackage__Script_ArcaneNomads, nullptr, "StoreEvent__DelegateSignature", nullptr, nullptr, sizeof(_Script_ArcaneNomads_eventStoreEvent_Parms), Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x00130000, 0, 0, METADATA_PARAMS(Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	void UStoreableComponent::StaticRegisterNativesUStoreableComponent()
	{
		UClass* Class = UStoreableComponent::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "Drop", &UStoreableComponent::execDrop },
			{ "Store", &UStoreableComponent::execStore },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UStoreableComponent_Drop_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UStoreableComponent_Drop_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Trigger when dropped from inventory\n" },
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
		{ "ToolTip", "Trigger when dropped from inventory" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UStoreableComponent_Drop_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UStoreableComponent, nullptr, "Drop", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UStoreableComponent_Drop_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UStoreableComponent_Drop_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UStoreableComponent_Drop()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UStoreableComponent_Drop_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UStoreableComponent_Store_Statics
	{
		struct StoreableComponent_eventStore_Parms
		{
			UInventoryComponent* Inventory;
		};
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Inventory_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Inventory;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UStoreableComponent_Store_Statics::NewProp_Inventory_MetaData[] = {
		{ "EditInline", "true" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UStoreableComponent_Store_Statics::NewProp_Inventory = { "Inventory", nullptr, (EPropertyFlags)0x0010000000080080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(StoreableComponent_eventStore_Parms, Inventory), Z_Construct_UClass_UInventoryComponent_NoRegister, METADATA_PARAMS(Z_Construct_UFunction_UStoreableComponent_Store_Statics::NewProp_Inventory_MetaData, UE_ARRAY_COUNT(Z_Construct_UFunction_UStoreableComponent_Store_Statics::NewProp_Inventory_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UStoreableComponent_Store_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UStoreableComponent_Store_Statics::NewProp_Inventory,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UStoreableComponent_Store_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Trigger when being stored\n" },
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
		{ "ToolTip", "Trigger when being stored" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UStoreableComponent_Store_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UStoreableComponent, nullptr, "Store", nullptr, nullptr, sizeof(StoreableComponent_eventStore_Parms), Z_Construct_UFunction_UStoreableComponent_Store_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UStoreableComponent_Store_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UStoreableComponent_Store_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UStoreableComponent_Store_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UStoreableComponent_Store()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UStoreableComponent_Store_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UStoreableComponent_NoRegister()
	{
		return UStoreableComponent::StaticClass();
	}
	struct Z_Construct_UClass_UStoreableComponent_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_OnDropped_MetaData[];
#endif
		static const UE4CodeGen_Private::FMulticastDelegatePropertyParams NewProp_OnDropped;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_OnStored_MetaData[];
#endif
		static const UE4CodeGen_Private::FMulticastDelegatePropertyParams NewProp_OnStored;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const UE4CodeGen_Private::FImplementedInterfaceParams InterfaceParams[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UStoreableComponent_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UStoreableComponent_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UStoreableComponent_Drop, "Drop" }, // 3070225117
		{ &Z_Construct_UFunction_UStoreableComponent_Store, "Store" }, // 4244681524
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UStoreableComponent_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "InventorySystem/StoreableComponent.h" },
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnDropped_MetaData[] = {
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FMulticastDelegatePropertyParams Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnDropped = { "OnDropped", nullptr, (EPropertyFlags)0x0010000010080000, UE4CodeGen_Private::EPropertyGenFlags::InlineMulticastDelegate, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UStoreableComponent, OnDropped), Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature, METADATA_PARAMS(Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnDropped_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnDropped_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnStored_MetaData[] = {
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FMulticastDelegatePropertyParams Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnStored = { "OnStored", nullptr, (EPropertyFlags)0x0010000010080000, UE4CodeGen_Private::EPropertyGenFlags::InlineMulticastDelegate, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UStoreableComponent, OnStored), Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature, METADATA_PARAMS(Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnStored_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnStored_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UStoreableComponent_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnDropped,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UStoreableComponent_Statics::NewProp_OnStored,
	};
		const UE4CodeGen_Private::FImplementedInterfaceParams Z_Construct_UClass_UStoreableComponent_Statics::InterfaceParams[] = {
			{ Z_Construct_UClass_UInteractable_NoRegister, (int32)VTABLE_OFFSET(UStoreableComponent, IInteractable), false },
		};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UStoreableComponent_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UStoreableComponent>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UStoreableComponent_Statics::ClassParams = {
		&UStoreableComponent::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		Z_Construct_UClass_UStoreableComponent_Statics::PropPointers,
		InterfaceParams,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		UE_ARRAY_COUNT(Z_Construct_UClass_UStoreableComponent_Statics::PropPointers),
		UE_ARRAY_COUNT(InterfaceParams),
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UStoreableComponent_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UStoreableComponent_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UStoreableComponent()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UStoreableComponent_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UStoreableComponent, 273149367);
	template<> ARCANENOMADS_API UClass* StaticClass<UStoreableComponent>()
	{
		return UStoreableComponent::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UStoreableComponent(Z_Construct_UClass_UStoreableComponent, &UStoreableComponent::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UStoreableComponent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UStoreableComponent);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
