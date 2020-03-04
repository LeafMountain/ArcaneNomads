// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/NeedsSystem/HungerComponent.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeHungerComponent() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UHungerComponnent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UHungerComponnent();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_GetDecayRate();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_GetHunger();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted();
// End Cross Module References
	void UHungerComponnent::StaticRegisterNativesUHungerComponnent()
	{
		UClass* Class = UHungerComponnent::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "GetDecayMultiplier", &UHungerComponnent::execGetDecayMultiplier },
			{ "GetDecayRate", &UHungerComponnent::execGetDecayRate },
			{ "GetHunger", &UHungerComponnent::execGetHunger },
			{ "GetTimeRemaining", &UHungerComponnent::execGetTimeRemaining },
			{ "ResetDecayMultiplier", &UHungerComponnent::execResetDecayMultiplier },
			{ "SetDecayMultiplier", &UHungerComponnent::execSetDecayMultiplier },
			{ "SetTimeUntilDepleted", &UHungerComponnent::execSetTimeUntilDepleted },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics
	{
		struct HungerComponnent_eventGetDecayMultiplier_Parms
		{
			float ReturnValue;
		};
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(HungerComponnent_eventGetDecayMultiplier_Parms, ReturnValue), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Value reduced each second\n" },
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
		{ "ToolTip", "Value reduced each second" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "GetDecayMultiplier", nullptr, nullptr, sizeof(HungerComponnent_eventGetDecayMultiplier_Parms), Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x14020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics
	{
		struct HungerComponnent_eventGetDecayRate_Parms
		{
			float ReturnValue;
		};
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(HungerComponnent_eventGetDecayRate_Parms, ReturnValue), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "GetDecayRate", nullptr, nullptr, sizeof(HungerComponnent_eventGetDecayRate_Parms), Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x14020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_GetDecayRate()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_GetDecayRate_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics
	{
		struct HungerComponnent_eventGetHunger_Parms
		{
			float ReturnValue;
		};
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(HungerComponnent_eventGetHunger_Parms, ReturnValue), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "GetHunger", nullptr, nullptr, sizeof(HungerComponnent_eventGetHunger_Parms), Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x14020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_GetHunger()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_GetHunger_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics
	{
		struct HungerComponnent_eventGetTimeRemaining_Parms
		{
			float ReturnValue;
		};
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(HungerComponnent_eventGetTimeRemaining_Parms, ReturnValue), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "GetTimeRemaining", nullptr, nullptr, sizeof(HungerComponnent_eventGetTimeRemaining_Parms), Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x14020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "ResetDecayMultiplier", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics
	{
		struct HungerComponnent_eventSetDecayMultiplier_Parms
		{
			float aMultiplier;
		};
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_aMultiplier;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::NewProp_aMultiplier = { "aMultiplier", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(HungerComponnent_eventSetDecayMultiplier_Parms, aMultiplier), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::NewProp_aMultiplier,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "SetDecayMultiplier", nullptr, nullptr, sizeof(HungerComponnent_eventSetDecayMultiplier_Parms), Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics
	{
		struct HungerComponnent_eventSetTimeUntilDepleted_Parms
		{
			float aTimeInSeconds;
		};
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_aTimeInSeconds;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::NewProp_aTimeInSeconds = { "aTimeInSeconds", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(HungerComponnent_eventSetTimeUntilDepleted_Parms, aTimeInSeconds), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::NewProp_aTimeInSeconds,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHungerComponnent, nullptr, "SetTimeUntilDepleted", nullptr, nullptr, sizeof(HungerComponnent_eventSetTimeUntilDepleted_Parms), Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UHungerComponnent_NoRegister()
	{
		return UHungerComponnent::StaticClass();
	}
	struct Z_Construct_UClass_UHungerComponnent_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_myTimeUntilDepletedFromFullHealth_MetaData[];
#endif
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_myTimeUntilDepletedFromFullHealth;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UHungerComponnent_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UHungerComponnent_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UHungerComponnent_GetDecayMultiplier, "GetDecayMultiplier" }, // 412614253
		{ &Z_Construct_UFunction_UHungerComponnent_GetDecayRate, "GetDecayRate" }, // 3540639359
		{ &Z_Construct_UFunction_UHungerComponnent_GetHunger, "GetHunger" }, // 537682200
		{ &Z_Construct_UFunction_UHungerComponnent_GetTimeRemaining, "GetTimeRemaining" }, // 2430670303
		{ &Z_Construct_UFunction_UHungerComponnent_ResetDecayMultiplier, "ResetDecayMultiplier" }, // 905294003
		{ &Z_Construct_UFunction_UHungerComponnent_SetDecayMultiplier, "SetDecayMultiplier" }, // 3552382422
		{ &Z_Construct_UFunction_UHungerComponnent_SetTimeUntilDepleted, "SetTimeUntilDepleted" }, // 1723673401
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UHungerComponnent_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "NeedsSystem/HungerComponent.h" },
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UHungerComponnent_Statics::NewProp_myTimeUntilDepletedFromFullHealth_MetaData[] = {
		{ "Category", "HungerComponnent" },
		{ "ModuleRelativePath", "NeedsSystem/HungerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UClass_UHungerComponnent_Statics::NewProp_myTimeUntilDepletedFromFullHealth = { "myTimeUntilDepletedFromFullHealth", nullptr, (EPropertyFlags)0x0040000000010001, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UHungerComponnent, myTimeUntilDepletedFromFullHealth), METADATA_PARAMS(Z_Construct_UClass_UHungerComponnent_Statics::NewProp_myTimeUntilDepletedFromFullHealth_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UHungerComponnent_Statics::NewProp_myTimeUntilDepletedFromFullHealth_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UHungerComponnent_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UHungerComponnent_Statics::NewProp_myTimeUntilDepletedFromFullHealth,
	};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UHungerComponnent_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UHungerComponnent>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UHungerComponnent_Statics::ClassParams = {
		&UHungerComponnent::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		Z_Construct_UClass_UHungerComponnent_Statics::PropPointers,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		UE_ARRAY_COUNT(Z_Construct_UClass_UHungerComponnent_Statics::PropPointers),
		0,
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UHungerComponnent_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UHungerComponnent_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UHungerComponnent()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UHungerComponnent_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UHungerComponnent, 2877491832);
	template<> ARCANENOMADS_API UClass* StaticClass<UHungerComponnent>()
	{
		return UHungerComponnent::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UHungerComponnent(Z_Construct_UClass_UHungerComponnent, &UHungerComponnent::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UHungerComponnent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UHungerComponnent);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
