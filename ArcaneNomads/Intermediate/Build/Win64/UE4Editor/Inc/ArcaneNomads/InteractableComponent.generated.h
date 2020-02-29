// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UInteractorComponent;
#ifdef ARCANENOMADS_InteractableComponent_generated_h
#error "InteractableComponent.generated.h already included, missing '#pragma once' in InteractableComponent.h"
#endif
#define ARCANENOMADS_InteractableComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_7_DELEGATE \
struct _Script_ArcaneNomads_eventOnInteractedOne_Parms \
{ \
	UInteractorComponent* Interactor; \
}; \
static inline void FOnInteractedOne_DelegateWrapper(const FMulticastScriptDelegate& OnInteractedOne, UInteractorComponent* Interactor) \
{ \
	_Script_ArcaneNomads_eventOnInteractedOne_Parms Parms; \
	Parms.Interactor=Interactor; \
	OnInteractedOne.ProcessMulticastDelegate<UObject>(&Parms); \
}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execUnfocus) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Unfocus(Z_Param_Interactor); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execFocus) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Focus(Z_Param_Interactor); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execInteract) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Interact(Z_Param_Interactor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execUnfocus) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Unfocus(Z_Param_Interactor); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execFocus) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Focus(Z_Param_Interactor); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execInteract) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Interact(Z_Param_Interactor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUInteractableComponent(); \
	friend struct Z_Construct_UClass_UInteractableComponent_Statics; \
public: \
	DECLARE_CLASS(UInteractableComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInteractableComponent)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_INCLASS \
private: \
	static void StaticRegisterNativesUInteractableComponent(); \
	friend struct Z_Construct_UClass_UInteractableComponent_Statics; \
public: \
	DECLARE_CLASS(UInteractableComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInteractableComponent)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInteractableComponent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInteractableComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInteractableComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInteractableComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInteractableComponent(UInteractableComponent&&); \
	NO_API UInteractableComponent(const UInteractableComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInteractableComponent(UInteractableComponent&&); \
	NO_API UInteractableComponent(const UInteractableComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInteractableComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInteractableComponent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UInteractableComponent)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_PRIVATE_PROPERTY_OFFSET
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_9_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UInteractableComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InteractionSystem_InteractableComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
