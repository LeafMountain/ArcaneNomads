// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/NeedsSystem/EdibleComponent.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeEdibleComponent() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UEdibleComponent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UEdibleComponent();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UEdibleComponent_GetHungerReduction();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UUseable_NoRegister();
// End Cross Module References
	void UEdibleComponent::StaticRegisterNativesUEdibleComponent()
	{
		UClass* Class = UEdibleComponent::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "GetHungerReduction", &UEdibleComponent::execGetHungerReduction },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics
	{
		struct EdibleComponent_eventGetHungerReduction_Parms
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
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(EdibleComponent_eventGetHungerReduction_Parms, ReturnValue), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "NeedsSystem/EdibleComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UEdibleComponent, nullptr, "GetHungerReduction", nullptr, nullptr, sizeof(EdibleComponent_eventGetHungerReduction_Parms), Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x14020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UEdibleComponent_GetHungerReduction()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UEdibleComponent_GetHungerReduction_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UEdibleComponent_NoRegister()
	{
		return UEdibleComponent::StaticClass();
	}
	struct Z_Construct_UClass_UEdibleComponent_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_myHungerReduction_MetaData[];
#endif
		static const UE4CodeGen_Private::FFloatPropertyParams NewProp_myHungerReduction;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const UE4CodeGen_Private::FImplementedInterfaceParams InterfaceParams[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UEdibleComponent_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UEdibleComponent_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UEdibleComponent_GetHungerReduction, "GetHungerReduction" }, // 1121366622
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UEdibleComponent_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "NeedsSystem/EdibleComponent.h" },
		{ "ModuleRelativePath", "NeedsSystem/EdibleComponent.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UEdibleComponent_Statics::NewProp_myHungerReduction_MetaData[] = {
		{ "Category", "EdibleComponent" },
		{ "ModuleRelativePath", "NeedsSystem/EdibleComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFloatPropertyParams Z_Construct_UClass_UEdibleComponent_Statics::NewProp_myHungerReduction = { "myHungerReduction", nullptr, (EPropertyFlags)0x0020080000010001, UE4CodeGen_Private::EPropertyGenFlags::Float, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UEdibleComponent, myHungerReduction), METADATA_PARAMS(Z_Construct_UClass_UEdibleComponent_Statics::NewProp_myHungerReduction_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UEdibleComponent_Statics::NewProp_myHungerReduction_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UEdibleComponent_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UEdibleComponent_Statics::NewProp_myHungerReduction,
	};
		const UE4CodeGen_Private::FImplementedInterfaceParams Z_Construct_UClass_UEdibleComponent_Statics::InterfaceParams[] = {
			{ Z_Construct_UClass_UUseable_NoRegister, (int32)VTABLE_OFFSET(UEdibleComponent, IUseable), false },
		};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UEdibleComponent_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UEdibleComponent>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UEdibleComponent_Statics::ClassParams = {
		&UEdibleComponent::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		Z_Construct_UClass_UEdibleComponent_Statics::PropPointers,
		InterfaceParams,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		UE_ARRAY_COUNT(Z_Construct_UClass_UEdibleComponent_Statics::PropPointers),
		UE_ARRAY_COUNT(InterfaceParams),
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UEdibleComponent_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UEdibleComponent_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UEdibleComponent()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UEdibleComponent_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UEdibleComponent, 3681954367);
	template<> ARCANENOMADS_API UClass* StaticClass<UEdibleComponent>()
	{
		return UEdibleComponent::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UEdibleComponent(Z_Construct_UClass_UEdibleComponent, &UEdibleComponent::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UEdibleComponent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UEdibleComponent);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
