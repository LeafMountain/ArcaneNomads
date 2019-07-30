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
	ARCANENOMADS_API UClass* Z_Construct_UClass_UStoreableCompenent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UStoreableCompenent();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
// End Cross Module References
	void UStoreableCompenent::StaticRegisterNativesUStoreableCompenent()
	{
	}
	UClass* Z_Construct_UClass_UStoreableCompenent_NoRegister()
	{
		return UStoreableCompenent::StaticClass();
	}
	struct Z_Construct_UClass_UStoreableCompenent_Statics
	{
		static UObject* (*const DependentSingletons[])();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UStoreableCompenent_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UStoreableCompenent_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "InventorySystem/StoreableComponent.h" },
		{ "ModuleRelativePath", "InventorySystem/StoreableComponent.h" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_UStoreableCompenent_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UStoreableCompenent>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UStoreableCompenent_Statics::ClassParams = {
		&UStoreableCompenent::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		nullptr,
		nullptr,
		nullptr,
		ARRAY_COUNT(DependentSingletons),
		0,
		0,
		0,
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UStoreableCompenent_Statics::Class_MetaDataParams, ARRAY_COUNT(Z_Construct_UClass_UStoreableCompenent_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UStoreableCompenent()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UStoreableCompenent_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UStoreableCompenent, 830789497);
	template<> ARCANENOMADS_API UClass* StaticClass<UStoreableCompenent>()
	{
		return UStoreableCompenent::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UStoreableCompenent(Z_Construct_UClass_UStoreableCompenent, &UStoreableCompenent::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UStoreableCompenent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UStoreableCompenent);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
