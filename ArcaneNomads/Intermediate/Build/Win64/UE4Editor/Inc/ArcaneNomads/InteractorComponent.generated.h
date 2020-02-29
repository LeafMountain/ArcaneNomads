// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class AActor;
#ifdef ARCANENOMADS_InteractorComponent_generated_h
#error "InteractorComponent.generated.h already included, missing '#pragma once' in InteractorComponent.h"
#endif
#define ARCANENOMADS_InteractorComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_7_DELEGATE \
struct _Script_ArcaneNomads_eventInteractionEventOne_Parms \
{ \
	AActor* Interactable; \
}; \
static inline void FInteractionEventOne_DelegateWrapper(const FMulticastScriptDelegate& InteractionEventOne, AActor* Interactable) \
{ \
	_Script_ArcaneNomads_eventInteractionEventOne_Parms Parms; \
	Parms.Interactable=Interactable; \
	InteractionEventOne.ProcessMulticastDelegate<UObject>(&Parms); \
}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execInteract) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->Interact(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetInteractable) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(AActor**)Z_Param__Result=P_THIS->GetInteractable(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execLookingAtInteractable) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->LookingAtInteractable(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execInteract) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->Interact(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetInteractable) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(AActor**)Z_Param__Result=P_THIS->GetInteractable(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execLookingAtInteractable) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(bool*)Z_Param__Result=P_THIS->LookingAtInteractable(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUInteractorComponent(); \
	friend struct Z_Construct_UClass_UInteractorComponent_Statics; \
public: \
	DECLARE_CLASS(UInteractorComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInteractorComponent)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_INCLASS \
private: \
	static void StaticRegisterNativesUInteractorComponent(); \
	friend struct Z_Construct_UClass_UInteractorComponent_Statics; \
public: \
	DECLARE_CLASS(UInteractorComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInteractorComponent)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInteractorComponent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInteractorComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInteractorComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInteractorComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInteractorComponent(UInteractorComponent&&); \
	NO_API UInteractorComponent(const UInteractorComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInteractorComponent(UInteractorComponent&&); \
	NO_API UInteractorComponent(const UInteractorComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInteractorComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInteractorComponent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UInteractorComponent)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_PRIVATE_PROPERTY_OFFSET
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_9_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UInteractorComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractorComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
