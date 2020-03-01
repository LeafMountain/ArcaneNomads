// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeArcaneNomads_init() {}
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_HitEventTwo__DelegateSignature();
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_HitEventOne__DelegateSignature();
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_OnInteractedOne__DelegateSignature();
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature();
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_InventoryEvent__DelegateSignature();
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_InventoryEventOne__DelegateSignature();
	ARCANENOMADS_API UFunction* Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads()
	{
		static UPackage* ReturnPackage = nullptr;
		if (!ReturnPackage)
		{
			static UObject* (*const SingletonFuncArray[])() = {
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_HitEventTwo__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_HitEventOne__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_OnInteractedOne__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_InteractionEventOne__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_InventoryEvent__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_InventoryEventOne__DelegateSignature,
				(UObject* (*)())Z_Construct_UDelegateFunction_ArcaneNomads_StoreEvent__DelegateSignature,
			};
			static const UE4CodeGen_Private::FPackageParams PackageParams = {
				"/Script/ArcaneNomads",
				SingletonFuncArray,
				UE_ARRAY_COUNT(SingletonFuncArray),
				PKG_CompiledIn | 0x00000000,
				0x77624A76,
				0x02D121B8,
				METADATA_PARAMS(nullptr, 0)
			};
			UE4CodeGen_Private::ConstructUPackage(ReturnPackage, PackageParams);
		}
		return ReturnPackage;
	}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
