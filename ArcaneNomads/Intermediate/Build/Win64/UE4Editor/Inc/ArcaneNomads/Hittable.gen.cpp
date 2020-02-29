// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/WeaponSystem/Hittable.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeHittable() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UHittable_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UHittable();
	COREUOBJECT_API UClass* Z_Construct_UClass_UInterface();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UHittable_OnHit();
	ARCANENOMADS_API UClass* Z_Construct_UClass_AWeapon_NoRegister();
// End Cross Module References
	void IHittable::OnHit(int32 Damage, AWeapon* Instagator)
	{
		check(0 && "Do not directly call Event functions in Interfaces. Call Execute_OnHit instead.");
	}
	void UHittable::StaticRegisterNativesUHittable()
	{
		UClass* Class = UHittable::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "OnHit", &IHittable::execOnHit },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UHittable_OnHit_Statics
	{
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Instagator;
		static const UE4CodeGen_Private::FUnsizedIntPropertyParams NewProp_Damage;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UHittable_OnHit_Statics::NewProp_Instagator = { "Instagator", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(Hittable_eventOnHit_Parms, Instagator), Z_Construct_UClass_AWeapon_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FUnsizedIntPropertyParams Z_Construct_UFunction_UHittable_OnHit_Statics::NewProp_Damage = { "Damage", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Int, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(Hittable_eventOnHit_Parms, Damage), METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UHittable_OnHit_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHittable_OnHit_Statics::NewProp_Instagator,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UHittable_OnHit_Statics::NewProp_Damage,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UHittable_OnHit_Statics::Function_MetaDataParams[] = {
		{ "Category", "Hittable" },
		{ "ModuleRelativePath", "WeaponSystem/Hittable.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UHittable_OnHit_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UHittable, nullptr, "OnHit", nullptr, nullptr, sizeof(Hittable_eventOnHit_Parms), Z_Construct_UFunction_UHittable_OnHit_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UHittable_OnHit_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x0C020C00, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UHittable_OnHit_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UHittable_OnHit_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UHittable_OnHit()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UHittable_OnHit_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UHittable_NoRegister()
	{
		return UHittable::StaticClass();
	}
	struct Z_Construct_UClass_UHittable_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UHittable_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UInterface,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UHittable_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UHittable_OnHit, "OnHit" }, // 2009139918
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UHittable_Statics::Class_MetaDataParams[] = {
		{ "BlueprintType", "true" },
		{ "IsBlueprintBase", "true" },
		{ "ModuleRelativePath", "WeaponSystem/Hittable.h" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_UHittable_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<IHittable>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UHittable_Statics::ClassParams = {
		&UHittable::StaticClass,
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
		METADATA_PARAMS(Z_Construct_UClass_UHittable_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UHittable_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UHittable()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UHittable_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UHittable, 4228351566);
	template<> ARCANENOMADS_API UClass* StaticClass<UHittable>()
	{
		return UHittable::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UHittable(Z_Construct_UClass_UHittable, &UHittable::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UHittable"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UHittable);
	static FName NAME_UHittable_OnHit = FName(TEXT("OnHit"));
	void IHittable::Execute_OnHit(UObject* O, int32 Damage, AWeapon* Instagator)
	{
		check(O != NULL);
		check(O->GetClass()->ImplementsInterface(UHittable::StaticClass()));
		Hittable_eventOnHit_Parms Parms;
		UFunction* const Func = O->FindFunction(NAME_UHittable_OnHit);
		if (Func)
		{
			Parms.Damage=Damage;
			Parms.Instagator=Instagator;
			O->ProcessEvent(Func, &Parms);
		}
		else if (auto I = (IHittable*)(O->GetNativeInterfaceAddress(UHittable::StaticClass())))
		{
			I->OnHit_Implementation(Damage,Instagator);
		}
	}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
