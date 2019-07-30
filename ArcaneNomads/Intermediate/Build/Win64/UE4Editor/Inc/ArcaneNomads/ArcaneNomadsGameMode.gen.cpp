// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/ArcaneNomadsGameMode.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeArcaneNomadsGameMode() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_AArcaneNomadsGameMode_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_AArcaneNomadsGameMode();
	ENGINE_API UClass* Z_Construct_UClass_AGameModeBase();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
// End Cross Module References
	void AArcaneNomadsGameMode::StaticRegisterNativesAArcaneNomadsGameMode()
	{
	}
	UClass* Z_Construct_UClass_AArcaneNomadsGameMode_NoRegister()
	{
		return AArcaneNomadsGameMode::StaticClass();
	}
	struct Z_Construct_UClass_AArcaneNomadsGameMode_Statics
	{
		static UObject* (*const DependentSingletons[])();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_AArcaneNomadsGameMode_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_AGameModeBase,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_AArcaneNomadsGameMode_Statics::Class_MetaDataParams[] = {
		{ "HideCategories", "Info Rendering MovementReplication Replication Actor Input Movement Collision Rendering Utilities|Transformation" },
		{ "IncludePath", "ArcaneNomadsGameMode.h" },
		{ "ModuleRelativePath", "ArcaneNomadsGameMode.h" },
		{ "ShowCategories", "Input|MouseInput Input|TouchInput" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_AArcaneNomadsGameMode_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<AArcaneNomadsGameMode>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_AArcaneNomadsGameMode_Statics::ClassParams = {
		&AArcaneNomadsGameMode::StaticClass,
		nullptr,
		&StaticCppClassTypeInfo,
		DependentSingletons,
		nullptr,
		nullptr,
		nullptr,
		ARRAY_COUNT(DependentSingletons),
		0,
		0,
		0,
		0x008802A8u,
		METADATA_PARAMS(Z_Construct_UClass_AArcaneNomadsGameMode_Statics::Class_MetaDataParams, ARRAY_COUNT(Z_Construct_UClass_AArcaneNomadsGameMode_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_AArcaneNomadsGameMode()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_AArcaneNomadsGameMode_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(AArcaneNomadsGameMode, 2144958998);
	template<> ARCANENOMADS_API UClass* StaticClass<AArcaneNomadsGameMode>()
	{
		return AArcaneNomadsGameMode::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_AArcaneNomadsGameMode(Z_Construct_UClass_AArcaneNomadsGameMode, &AArcaneNomadsGameMode::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("AArcaneNomadsGameMode"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(AArcaneNomadsGameMode);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
