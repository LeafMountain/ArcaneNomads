// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/WeaponSystem/ToolUser.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeToolUser() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UToolUser_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UToolUser();
	ENGINE_API UClass* Z_Construct_UClass_UActorComponent();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UToolUser_Equip();
	ENGINE_API UClass* Z_Construct_UClass_USceneComponent_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_AWeapon_NoRegister();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UToolUser_Unequip();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UToolUser_Use();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UToolUser_UseActivate();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UToolUser_UseInactivate();
// End Cross Module References
	void UToolUser::StaticRegisterNativesUToolUser()
	{
		UClass* Class = UToolUser::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "Equip", &UToolUser::execEquip },
			{ "Unequip", &UToolUser::execUnequip },
			{ "Use", &UToolUser::execUse },
			{ "UseActivate", &UToolUser::execUseActivate },
			{ "UseInactivate", &UToolUser::execUseInactivate },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UToolUser_Equip_Statics
	{
		struct ToolUser_eventEquip_Parms
		{
			AWeapon* Tool;
			USceneComponent* Parent;
			FName SocketName;
		};
		static const UE4CodeGen_Private::FNamePropertyParams NewProp_SocketName;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_Parent_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Parent;
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_Tool;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FNamePropertyParams Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_SocketName = { "SocketName", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Name, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(ToolUser_eventEquip_Parms, SocketName), METADATA_PARAMS(nullptr, 0) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Parent_MetaData[] = {
		{ "EditInline", "true" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Parent = { "Parent", nullptr, (EPropertyFlags)0x0010000000080080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(ToolUser_eventEquip_Parms, Parent), Z_Construct_UClass_USceneComponent_NoRegister, METADATA_PARAMS(Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Parent_MetaData, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Parent_MetaData)) };
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Tool = { "Tool", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(ToolUser_eventEquip_Parms, Tool), Z_Construct_UClass_AWeapon_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UToolUser_Equip_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_SocketName,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Parent,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UToolUser_Equip_Statics::NewProp_Tool,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UToolUser_Equip_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Equip a new tool\n" },
		{ "CPP_Default_SocketName", "RightHandSocket" },
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
		{ "ToolTip", "Equip a new tool" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UToolUser_Equip_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UToolUser, nullptr, "Equip", nullptr, nullptr, sizeof(ToolUser_eventEquip_Parms), Z_Construct_UFunction_UToolUser_Equip_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_Equip_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UToolUser_Equip_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_Equip_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UToolUser_Equip()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UToolUser_Equip_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UToolUser_Unequip_Statics
	{
		struct ToolUser_eventUnequip_Parms
		{
			AWeapon* ReturnValue;
		};
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_ReturnValue;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UToolUser_Unequip_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000000580, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(ToolUser_eventUnequip_Parms, ReturnValue), Z_Construct_UClass_AWeapon_NoRegister, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UToolUser_Unequip_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UToolUser_Unequip_Statics::NewProp_ReturnValue,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UToolUser_Unequip_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Unequip the current tool\n" },
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
		{ "ToolTip", "Unequip the current tool" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UToolUser_Unequip_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UToolUser, nullptr, "Unequip", nullptr, nullptr, sizeof(ToolUser_eventUnequip_Parms), Z_Construct_UFunction_UToolUser_Unequip_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_Unequip_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UToolUser_Unequip_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_Unequip_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UToolUser_Unequip()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UToolUser_Unequip_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UToolUser_Use_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UToolUser_Use_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Use the current tool\n" },
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
		{ "ToolTip", "Use the current tool" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UToolUser_Use_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UToolUser, nullptr, "Use", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UToolUser_Use_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_Use_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UToolUser_Use()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UToolUser_Use_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UToolUser_UseActivate_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UToolUser_UseActivate_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UToolUser_UseActivate_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UToolUser, nullptr, "UseActivate", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UToolUser_UseActivate_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_UseActivate_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UToolUser_UseActivate()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UToolUser_UseActivate_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UToolUser_UseInactivate_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UToolUser_UseInactivate_Statics::Function_MetaDataParams[] = {
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UToolUser_UseInactivate_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UToolUser, nullptr, "UseInactivate", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UToolUser_UseInactivate_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UToolUser_UseInactivate_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UToolUser_UseInactivate()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UToolUser_UseInactivate_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UToolUser_NoRegister()
	{
		return UToolUser::StaticClass();
	}
	struct Z_Construct_UClass_UToolUser_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_IsEquipped_MetaData[];
#endif
		static void NewProp_IsEquipped_SetBit(void* Obj);
		static const UE4CodeGen_Private::FBoolPropertyParams NewProp_IsEquipped;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UToolUser_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UActorComponent,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UToolUser_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UToolUser_Equip, "Equip" }, // 1498577183
		{ &Z_Construct_UFunction_UToolUser_Unequip, "Unequip" }, // 3436078542
		{ &Z_Construct_UFunction_UToolUser_Use, "Use" }, // 1681053236
		{ &Z_Construct_UFunction_UToolUser_UseActivate, "UseActivate" }, // 4146694286
		{ &Z_Construct_UFunction_UToolUser_UseInactivate, "UseInactivate" }, // 3739701846
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UToolUser_Statics::Class_MetaDataParams[] = {
		{ "BlueprintSpawnableComponent", "" },
		{ "ClassGroupNames", "Custom" },
		{ "IncludePath", "WeaponSystem/ToolUser.h" },
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped_MetaData[] = {
		{ "Category", "ToolUser" },
		{ "ModuleRelativePath", "WeaponSystem/ToolUser.h" },
	};
#endif
	void Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped_SetBit(void* Obj)
	{
		((UToolUser*)Obj)->IsEquipped = 1;
	}
	const UE4CodeGen_Private::FBoolPropertyParams Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped = { "IsEquipped", nullptr, (EPropertyFlags)0x0010000000000014, UE4CodeGen_Private::EPropertyGenFlags::Bool | UE4CodeGen_Private::EPropertyGenFlags::NativeBool, RF_Public|RF_Transient|RF_MarkAsNative, 1, sizeof(bool), sizeof(UToolUser), &Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped_SetBit, METADATA_PARAMS(Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped_MetaData, UE_ARRAY_COUNT(Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_UToolUser_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_UToolUser_Statics::NewProp_IsEquipped,
	};
	const FCppClassTypeInfoStatic Z_Construct_UClass_UToolUser_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UToolUser>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UToolUser_Statics::ClassParams = {
		&UToolUser::StaticClass,
		"Engine",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		FuncInfo,
		Z_Construct_UClass_UToolUser_Statics::PropPointers,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		UE_ARRAY_COUNT(FuncInfo),
		UE_ARRAY_COUNT(Z_Construct_UClass_UToolUser_Statics::PropPointers),
		0,
		0x00B000A4u,
		METADATA_PARAMS(Z_Construct_UClass_UToolUser_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UToolUser_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UToolUser()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UToolUser_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UToolUser, 362960784);
	template<> ARCANENOMADS_API UClass* StaticClass<UToolUser>()
	{
		return UToolUser::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UToolUser(Z_Construct_UClass_UToolUser, &UToolUser::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UToolUser"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UToolUser);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
