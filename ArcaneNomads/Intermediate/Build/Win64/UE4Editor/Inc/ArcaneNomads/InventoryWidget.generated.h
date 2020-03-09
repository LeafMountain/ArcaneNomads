// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UInventoryComponent;
#ifdef ARCANENOMADS_InventoryWidget_generated_h
#error "InventoryWidget.generated.h already included, missing '#pragma once' in InventoryWidget.h"
#endif
#define ARCANENOMADS_InventoryWidget_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_RPC_WRAPPERS \
	virtual void OnInventorySetup_Implementation(UInventoryComponent* anInventory); \
 \
	DECLARE_FUNCTION(execOnInventorySetup) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnInventorySetup_Implementation(Z_Param_anInventory); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execSetupInventory) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetupInventory(Z_Param_anInventory); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_RPC_WRAPPERS_NO_PURE_DECLS \
	virtual void OnInventorySetup_Implementation(UInventoryComponent* anInventory); \
 \
	DECLARE_FUNCTION(execOnInventorySetup) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnInventorySetup_Implementation(Z_Param_anInventory); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execSetupInventory) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetupInventory(Z_Param_anInventory); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_EVENT_PARMS \
	struct InventoryWidget_eventOnInventorySetup_Parms \
	{ \
		UInventoryComponent* anInventory; \
	};


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_CALLBACK_WRAPPERS
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUInventoryWidget(); \
	friend struct Z_Construct_UClass_UInventoryWidget_Statics; \
public: \
	DECLARE_CLASS(UInventoryWidget, UUserWidget, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInventoryWidget)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_INCLASS \
private: \
	static void StaticRegisterNativesUInventoryWidget(); \
	friend struct Z_Construct_UClass_UInventoryWidget_Statics; \
public: \
	DECLARE_CLASS(UInventoryWidget, UUserWidget, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInventoryWidget)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInventoryWidget(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInventoryWidget) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInventoryWidget); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInventoryWidget); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInventoryWidget(UInventoryWidget&&); \
	NO_API UInventoryWidget(const UInventoryWidget&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInventoryWidget(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) : Super(ObjectInitializer) { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInventoryWidget(UInventoryWidget&&); \
	NO_API UInventoryWidget(const UInventoryWidget&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInventoryWidget); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInventoryWidget); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInventoryWidget)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_PRIVATE_PROPERTY_OFFSET
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_12_PROLOG \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_EVENT_PARMS


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h_15_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UInventoryWidget>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryWidget_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
