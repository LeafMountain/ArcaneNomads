// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UInventoryComponent;
#ifdef ARCANENOMADS_StoreableComponent_generated_h
#error "StoreableComponent.generated.h already included, missing '#pragma once' in StoreableComponent.h"
#endif
#define ARCANENOMADS_StoreableComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_7_DELEGATE \
struct _Script_ArcaneNomads_eventStoreEvent_Parms \
{ \
	UInventoryComponent* Inventory; \
}; \
static inline void FStoreEvent_DelegateWrapper(const FMulticastScriptDelegate& StoreEvent, UInventoryComponent* Inventory) \
{ \
	_Script_ArcaneNomads_eventStoreEvent_Parms Parms; \
	Parms.Inventory=Inventory; \
	StoreEvent.ProcessMulticastDelegate<UObject>(&Parms); \
}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execDrop) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Drop(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execStore) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_Inventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Store(Z_Param_Inventory); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execDrop) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Drop(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execStore) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_Inventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Store(Z_Param_Inventory); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUStoreableComponent(); \
	friend struct Z_Construct_UClass_UStoreableComponent_Statics; \
public: \
	DECLARE_CLASS(UStoreableComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UStoreableComponent)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_INCLASS \
private: \
	static void StaticRegisterNativesUStoreableComponent(); \
	friend struct Z_Construct_UClass_UStoreableComponent_Statics; \
public: \
	DECLARE_CLASS(UStoreableComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UStoreableComponent)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UStoreableComponent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UStoreableComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UStoreableComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UStoreableComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UStoreableComponent(UStoreableComponent&&); \
	NO_API UStoreableComponent(const UStoreableComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UStoreableComponent(UStoreableComponent&&); \
	NO_API UStoreableComponent(const UStoreableComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UStoreableComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UStoreableComponent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UStoreableComponent)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_PRIVATE_PROPERTY_OFFSET
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_9_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UStoreableComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InventorySystem_StoreableComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
