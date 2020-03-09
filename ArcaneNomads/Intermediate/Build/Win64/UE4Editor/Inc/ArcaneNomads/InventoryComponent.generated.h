// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UStoreableComponent;
class UInventoryComponent;
#ifdef ARCANENOMADS_InventoryComponent_generated_h
#error "InventoryComponent.generated.h already included, missing '#pragma once' in InventoryComponent.h"
#endif
#define ARCANENOMADS_InventoryComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_9_DELEGATE \
struct _Script_ArcaneNomads_eventInventoryEventOne_Parms \
{ \
	UStoreableComponent* Storeable; \
}; \
static inline void FInventoryEventOne_DelegateWrapper(const FMulticastScriptDelegate& InventoryEventOne, UStoreableComponent* Storeable) \
{ \
	_Script_ArcaneNomads_eventInventoryEventOne_Parms Parms; \
	Parms.Storeable=Storeable; \
	InventoryEventOne.ProcessMulticastDelegate<UObject>(&Parms); \
}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_8_DELEGATE \
static inline void FInventoryEvent_DelegateWrapper(const FMulticastScriptDelegate& InventoryEvent) \
{ \
	InventoryEvent.ProcessMulticastDelegate<UObject>(NULL); \
}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execTransferAll) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->TransferAll(Z_Param_anInventory); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execTransfer) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_GET_PROPERTY(UIntProperty,Z_Param_anIndex); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Transfer(Z_Param_anInventory,Z_Param_anIndex); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execToggle) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Toggle(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execClose) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Close(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execOpen) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Open(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execIsFull) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->IsFull(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execContains) \
	{ \
		P_GET_OBJECT(UStoreableComponent,Z_Param_aStoreable); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->Contains(Z_Param_aStoreable); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetItemAt) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_Index); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UStoreableComponent**)Z_Param__Result=P_THIS->GetItemAt(Z_Param_Index); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetNumberOfItemsInInventory) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(int32*)Z_Param__Result=P_THIS->GetNumberOfItemsInInventory(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetInventory) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(TArray<UStoreableComponent*>*)Z_Param__Result=P_THIS->GetInventory(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execWithdraw) \
	{ \
		P_GET_OBJECT(UStoreableComponent,Z_Param_aStoreable); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UStoreableComponent**)Z_Param__Result=P_THIS->Withdraw(Z_Param_aStoreable); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execWithdrawAt) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_Index); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UStoreableComponent**)Z_Param__Result=P_THIS->WithdrawAt(Z_Param_Index); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execDeposit) \
	{ \
		P_GET_OBJECT(UStoreableComponent,Z_Param_Item); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Deposit(Z_Param_Item); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execTransferAll) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->TransferAll(Z_Param_anInventory); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execTransfer) \
	{ \
		P_GET_OBJECT(UInventoryComponent,Z_Param_anInventory); \
		P_GET_PROPERTY(UIntProperty,Z_Param_anIndex); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Transfer(Z_Param_anInventory,Z_Param_anIndex); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execToggle) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Toggle(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execClose) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Close(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execOpen) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Open(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execIsFull) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->IsFull(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execContains) \
	{ \
		P_GET_OBJECT(UStoreableComponent,Z_Param_aStoreable); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->Contains(Z_Param_aStoreable); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetItemAt) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_Index); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UStoreableComponent**)Z_Param__Result=P_THIS->GetItemAt(Z_Param_Index); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetNumberOfItemsInInventory) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(int32*)Z_Param__Result=P_THIS->GetNumberOfItemsInInventory(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetInventory) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(TArray<UStoreableComponent*>*)Z_Param__Result=P_THIS->GetInventory(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execWithdraw) \
	{ \
		P_GET_OBJECT(UStoreableComponent,Z_Param_aStoreable); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UStoreableComponent**)Z_Param__Result=P_THIS->Withdraw(Z_Param_aStoreable); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execWithdrawAt) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_Index); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UStoreableComponent**)Z_Param__Result=P_THIS->WithdrawAt(Z_Param_Index); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execDeposit) \
	{ \
		P_GET_OBJECT(UStoreableComponent,Z_Param_Item); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Deposit(Z_Param_Item); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUInventoryComponent(); \
	friend struct Z_Construct_UClass_UInventoryComponent_Statics; \
public: \
	DECLARE_CLASS(UInventoryComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInventoryComponent) \
	virtual UObject* _getUObject() const override { return const_cast<UInventoryComponent*>(this); }


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_INCLASS \
private: \
	static void StaticRegisterNativesUInventoryComponent(); \
	friend struct Z_Construct_UClass_UInventoryComponent_Statics; \
public: \
	DECLARE_CLASS(UInventoryComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInventoryComponent) \
	virtual UObject* _getUObject() const override { return const_cast<UInventoryComponent*>(this); }


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInventoryComponent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInventoryComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInventoryComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInventoryComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInventoryComponent(UInventoryComponent&&); \
	NO_API UInventoryComponent(const UInventoryComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInventoryComponent(UInventoryComponent&&); \
	NO_API UInventoryComponent(const UInventoryComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInventoryComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInventoryComponent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UInventoryComponent)


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__Size() { return STRUCT_OFFSET(UInventoryComponent, Size); } \
	FORCEINLINE static uint32 __PPO__anInventoryWidget() { return STRUCT_OFFSET(UInventoryComponent, anInventoryWidget); }


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_11_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h_14_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UInventoryComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InventorySystem_InventoryComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
