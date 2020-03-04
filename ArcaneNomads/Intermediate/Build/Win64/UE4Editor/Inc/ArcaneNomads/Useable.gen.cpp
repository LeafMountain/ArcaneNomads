// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/InteractionSystem/Useable.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeUseable() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UUseable_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UUseable();
	COREUOBJECT_API UClass* Z_Construct_UClass_UInterface();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UUseable_Use();
	ENGINE_API UClass* Z_Construct_UClass_AActor_NoRegister();
// End Cross Module References
	void IUseable::Use(AActor* anActor)
	{
		check(0 && "Do not directly call Event functions in Interfaces. Call Execute_Use instead.");
	}
	void UUseable::StaticRegisterNativesUUseable()
	{
		UClass* Class = UUseable::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "Use", &IUseable::execUse },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UUseable_Use_Statics
	{
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_anActor;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UUseable_Use_Statics::NewProp_anActor = { "anActor", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(Useable_eventUse_Parms, anActor), Z_Construct_UClass_AActor_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UUseable_Use_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UUseable_Use_Statics::NewProp_anActor,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UUseable_Use_Statics::Function_MetaDataParams[] = {
		{ "Category", "Useable" },
		{ "ModuleRelativePath", "InteractionSystem/Useable.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UUseable_Use_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UUseable, nullptr, "Use", nullptr, nullptr, sizeof(Useable_eventUse_Parms), Z_Construct_UFunction_UUseable_Use_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UUseable_Use_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x0C020C00, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UUseable_Use_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UUseable_Use_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UUseable_Use()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UUseable_Use_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UUseable_NoRegister()
	{
		return UUseable::StaticClass();
	}
	struct Z_Construct_UClass_UUseable_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UUseable_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UInterface,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UUseable_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UUseable_Use, "Use" }, // 2245280256
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UUseable_Statics::Class_MetaDataParams[] = {
		{ "BlueprintType", "true" },
		{ "IsBlueprintBase", "true" },
		{ "ModuleRelativePath", "InteractionSystem/Useable.h" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_UUseable_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<IUseable>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UUseable_Statics::ClassParams = {
		&UUseable::StaticClass,
		nullptr,
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		nullptr,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		0,
		0,
		0x001040A1u,
		METADATA_PARAMS(Z_Construct_UClass_UUseable_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UUseable_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UUseable()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UUseable_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UUseable, 2567694393);
	template<> ARCANENOMADS_API UClass* StaticClass<UUseable>()
	{
		return UUseable::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UUseable(Z_Construct_UClass_UUseable, &UUseable::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UUseable"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UUseable);
	static FName NAME_UUseable_Use = FName(TEXT("Use"));
	void IUseable::Execute_Use(UObject* O, AActor* anActor)
	{
		check(O != NULL);
		check(O->GetClass()->ImplementsInterface(UUseable::StaticClass()));
		Useable_eventUse_Parms Parms;
		UFunction* const Func = O->FindFunction(NAME_UUseable_Use);
		if (Func)
		{
			Parms.anActor=anActor;
			O->ProcessEvent(Func, &Parms);
		}
		else if (auto I = (IUseable*)(O->GetNativeInterfaceAddress(UUseable::StaticClass())))
		{
			I->Use_Implementation(anActor);
		}
	}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
