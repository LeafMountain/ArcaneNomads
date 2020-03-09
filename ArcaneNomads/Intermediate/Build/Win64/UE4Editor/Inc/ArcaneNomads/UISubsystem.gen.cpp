// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "ArcaneNomads/UISubsystem/UISubsystem.h"
#include "Engine/Classes/Engine/GameInstance.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeUISubsystem() {}
// Cross Module References
	ARCANENOMADS_API UClass* Z_Construct_UClass_UUISubsystem_NoRegister();
	ARCANENOMADS_API UClass* Z_Construct_UClass_UUISubsystem();
	ENGINE_API UClass* Z_Construct_UClass_UGameInstanceSubsystem();
	UPackage* Z_Construct_UPackage__Script_ArcaneNomads();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UUISubsystem_CloseAll();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UUISubsystem_CloseTop();
	ARCANENOMADS_API UFunction* Z_Construct_UFunction_UUISubsystem_OpenWidget();
	UMG_API UClass* Z_Construct_UClass_UUserWidget_NoRegister();
	COREUOBJECT_API UClass* Z_Construct_UClass_UClass();
// End Cross Module References
	void UUISubsystem::StaticRegisterNativesUUISubsystem()
	{
		UClass* Class = UUISubsystem::StaticClass();
		static const FNameNativePtrPair Funcs[] = {
			{ "CloseAll", &UUISubsystem::execCloseAll },
			{ "CloseTop", &UUISubsystem::execCloseTop },
			{ "OpenWidget", &UUISubsystem::execOpenWidget },
		};
		FNativeFunctionRegistrar::RegisterFunctions(Class, Funcs, UE_ARRAY_COUNT(Funcs));
	}
	struct Z_Construct_UFunction_UUISubsystem_CloseAll_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UUISubsystem_CloseAll_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Close all UI\n" },
		{ "ModuleRelativePath", "UISubsystem/UISubsystem.h" },
		{ "ToolTip", "Close all UI" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UUISubsystem_CloseAll_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UUISubsystem, nullptr, "CloseAll", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UUISubsystem_CloseAll_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UUISubsystem_CloseAll_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UUISubsystem_CloseAll()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UUISubsystem_CloseAll_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UUISubsystem_CloseTop_Statics
	{
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UUISubsystem_CloseTop_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Close top UI\n" },
		{ "ModuleRelativePath", "UISubsystem/UISubsystem.h" },
		{ "ToolTip", "Close top UI" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UUISubsystem_CloseTop_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UUISubsystem, nullptr, "CloseTop", nullptr, nullptr, 0, nullptr, 0, RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UUISubsystem_CloseTop_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UUISubsystem_CloseTop_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UUISubsystem_CloseTop()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UUISubsystem_CloseTop_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	struct Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics
	{
		struct UISubsystem_eventOpenWidget_Parms
		{
			TSubclassOf<UUserWidget>  aWidget;
			bool unlockMouse;
			UUserWidget* ReturnValue;
		};
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_ReturnValue_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_ReturnValue;
		static void NewProp_unlockMouse_SetBit(void* Obj);
		static const UE4CodeGen_Private::FBoolPropertyParams NewProp_unlockMouse;
		static const UE4CodeGen_Private::FClassPropertyParams NewProp_aWidget;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Function_MetaDataParams[];
#endif
		static const UE4CodeGen_Private::FFunctionParams FuncParams;
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_ReturnValue_MetaData[] = {
		{ "EditInline", "true" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_ReturnValue = { "ReturnValue", nullptr, (EPropertyFlags)0x0010000000080588, UE4CodeGen_Private::EPropertyGenFlags::Object, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UISubsystem_eventOpenWidget_Parms, ReturnValue), Z_Construct_UClass_UUserWidget_NoRegister, METADATA_PARAMS(Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_ReturnValue_MetaData, UE_ARRAY_COUNT(Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_ReturnValue_MetaData)) };
	void Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_unlockMouse_SetBit(void* Obj)
	{
		((UISubsystem_eventOpenWidget_Parms*)Obj)->unlockMouse = 1;
	}
	const UE4CodeGen_Private::FBoolPropertyParams Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_unlockMouse = { "unlockMouse", nullptr, (EPropertyFlags)0x0010000000000080, UE4CodeGen_Private::EPropertyGenFlags::Bool | UE4CodeGen_Private::EPropertyGenFlags::NativeBool, RF_Public|RF_Transient|RF_MarkAsNative, 1, sizeof(bool), sizeof(UISubsystem_eventOpenWidget_Parms), &Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_unlockMouse_SetBit, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FClassPropertyParams Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_aWidget = { "aWidget", nullptr, (EPropertyFlags)0x0014000000000080, UE4CodeGen_Private::EPropertyGenFlags::Class, RF_Public|RF_Transient|RF_MarkAsNative, 1, STRUCT_OFFSET(UISubsystem_eventOpenWidget_Parms, aWidget), Z_Construct_UClass_UUserWidget_NoRegister, Z_Construct_UClass_UClass, METADATA_PARAMS(nullptr, 0) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_ReturnValue,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_unlockMouse,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::NewProp_aWidget,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::Function_MetaDataParams[] = {
		{ "Comment", "// Open a UI and add it to a list\n" },
		{ "CPP_Default_unlockMouse", "false" },
		{ "ModuleRelativePath", "UISubsystem/UISubsystem.h" },
		{ "ToolTip", "Open a UI and add it to a list" },
	};
#endif
	const UE4CodeGen_Private::FFunctionParams Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::FuncParams = { (UObject*(*)())Z_Construct_UClass_UUISubsystem, nullptr, "OpenWidget", nullptr, nullptr, sizeof(UISubsystem_eventOpenWidget_Parms), Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::PropPointers, UE_ARRAY_COUNT(Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::PropPointers), RF_Public|RF_Transient|RF_MarkAsNative, (EFunctionFlags)0x04020401, 0, 0, METADATA_PARAMS(Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::Function_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::Function_MetaDataParams)) };
	UFunction* Z_Construct_UFunction_UUISubsystem_OpenWidget()
	{
		static UFunction* ReturnFunction = nullptr;
		if (!ReturnFunction)
		{
			UE4CodeGen_Private::ConstructUFunction(ReturnFunction, Z_Construct_UFunction_UUISubsystem_OpenWidget_Statics::FuncParams);
		}
		return ReturnFunction;
	}
	UClass* Z_Construct_UClass_UUISubsystem_NoRegister()
	{
		return UUISubsystem::StaticClass();
	}
	struct Z_Construct_UClass_UUISubsystem_Statics
	{
		static UObject* (*const DependentSingletons[])();
		static const FClassFunctionLinkInfo FuncInfo[];
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_UUISubsystem_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_UGameInstanceSubsystem,
		(UObject* (*)())Z_Construct_UPackage__Script_ArcaneNomads,
	};
	const FClassFunctionLinkInfo Z_Construct_UClass_UUISubsystem_Statics::FuncInfo[] = {
		{ &Z_Construct_UFunction_UUISubsystem_CloseAll, "CloseAll" }, // 3368822781
		{ &Z_Construct_UFunction_UUISubsystem_CloseTop, "CloseTop" }, // 2797892500
		{ &Z_Construct_UFunction_UUISubsystem_OpenWidget, "OpenWidget" }, // 2204216131
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_UUISubsystem_Statics::Class_MetaDataParams[] = {
		{ "Comment", "/**\n * \n */" },
		{ "IncludePath", "UISubsystem/UISubsystem.h" },
		{ "ModuleRelativePath", "UISubsystem/UISubsystem.h" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_UUISubsystem_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<UUISubsystem>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_UUISubsystem_Statics::ClassParams = {
		&UUISubsystem::StaticClass,
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
		0x001000A0u,
		METADATA_PARAMS(Z_Construct_UClass_UUISubsystem_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_UUISubsystem_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_UUISubsystem()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_UUISubsystem_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(UUISubsystem, 3370554665);
	template<> ARCANENOMADS_API UClass* StaticClass<UUISubsystem>()
	{
		return UUISubsystem::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_UUISubsystem(Z_Construct_UClass_UUISubsystem, &UUISubsystem::StaticClass, TEXT("/Script/ArcaneNomads"), TEXT("UUISubsystem"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(UUISubsystem);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
