// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/HealthSystem/DamagerComponent.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeDamagerComponent() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UDamagerComponent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UDamagerComponent();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UDamagerComponent_Damage();
	ENGINE_API UClass* Z_Construct_UClass_AActor_NoRegister();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UDamagerComponent_SetOwner();
// End Cross Module References
	void UDamagerComponent::StaticRegisterNativesUDamagerComponent()
	{
		UClass* Class = UDamagerComponent::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "Damage", &UDamagerComponent::execDamage },
			{ "SetOwner", &UDamagerComponent::execSetOwner },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UDamagerComponent_Damage_Statics
	{
		struct DamagerComponent_eventDamage_Parms
		{
			AActor* OtherActor;
		};
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_OtherActor;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UDamagerComponent_Damage_Statics::NewProp_OtherActor = { "OtherActor", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(DamagerComponent_eventDamage_Parms, OtherActor), Z_Construct_UClass_AActor_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UDamagerComponent_Damage_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UDamagerComponent_Damage_Statics::NewProp_OtherActor,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UDamagerComponent_Damage_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "HealthSystem/DamagerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UDamagerComponent_Damage_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UDamagerComponent, nullptr, "Damage", sizeof(DamagerComponent_eventDamage_Parms), Z_Construct_UFunction_UDamagerComponent_Damage_Statics::PropPointers, ARRAY_COUNT(Z_Construct_UFunction_UDamagerComponent_Damage_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UDamagerComponent_Damage_Statics::Function_MetaDataParams, ARRAY_COUNT(Z_Construct_UFunction_UDamagerComponent_Damage_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UDamagerComponent_Damage()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UDamagerComponent_Damage_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics
	{
		struct DamagerComponent_eventSetOwner_Parms
		{
			AActor* Owner;
		};
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Owner;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::NewProp_Owner = { "Owner", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(DamagerComponent_eventSetOwner_Parms, Owner), Z_Construct_UClass_AActor_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::NewProp_Owner,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "HealthSystem/DamagerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UDamagerComponent, nullptr, "SetOwner", sizeof(DamagerComponent_eventSetOwner_Parms), Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::PropPointers, ARRAY_COUNT(Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::Function_MetaDataParams, ARRAY_COUNT(Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UDamagerComponent_SetOwner()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UDamagerComponent_SetOwner_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UDamagerComponent_NoRegister()
	{
		return UDamagerComponent::StaticClass();
	}
	struct Z_Construct_UClass_UDamagerComponent_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_DamageValue_MetaData[];
#endif
		static const UE4CodeGen_Private::FUnsizedIntPropertyParams NewProp_DamageValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UDamagerComponent_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UDamagerComponent_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UDamagerComponent_Damage, "Damage" }, // 3368059649
		{ &Z_Construct_UFunction_UDamagerComponent_SetOwner, "SetOwner" }, // 4292756572
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UDamagerComponent_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "HealthSystem/DamagerComponent.h" },
		{ "ModuleRelativePath", "HealthSystem/DamagerComponent.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UDamagerComponent_Statics::NewProp_DamageValue_MetaData[] = {
		{ "Category", "DamagerComponent" },
		{ "ModuleRelativePath", "HealthSystem/DamagerComponent.h" },
	};
#endif
	const UE4CodeGen_Private::FUnsizedIntPropertyParams Z_Construct_UClass_UDamagerComponent_Statics::NewProp_DamageValue = { "DamageValue", nullptr, (EPropertyFlags)0x0020080000000001, UE4CodeGen_Private::EPropertyGenFlags::Int, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UDamagerComponent, DamageValue), METADATA_PARAMS(Z_Construct_UClass_UDamagerComponent_Statics::NewProp_DamageValue_MetaData, ARRAY_COUNT(Z_Construct_UClass_UDamagerComponent_Statics::NewProp_DamageValue_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UDamagerComponent_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UDamagerComponent_Statics::NewProp_DamageValue,
	};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UDamagerComponent_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UDamagerComponent>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UDamagerComponent_Statics::ClassParams = {
		&UDamagerComponent::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		Z_Construct_UClass_UDamagerComponent_Statics::PropPointers,
		nullptr,
		ARRAY_COUNT(DependentSingletons),
		ARRAY_COUNT(FuncInfo),
		ARRAY_COUNT(Z_Construct_UClass_UDamagerComponent_Statics::PropPointers),
		0,
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UDamagerComponent_Statics::Class_MetaDataParams, ARRAY_COUNT(Z_Construct_UClass_UDamagerComponent_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UDamagerComponent()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UDamagerComponent_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UDamagerComponent, 2303478330);
	template<> ARCANENOMADS_API UClass* StaticClass<UDamagerComponent>()
	{
		return UDamagerComponent::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UDamagerComponent(Z_Construct_UClass_UDamagerComponent, &UDamagerComponent::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UDamagerComponent"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UDamagerComponent);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
