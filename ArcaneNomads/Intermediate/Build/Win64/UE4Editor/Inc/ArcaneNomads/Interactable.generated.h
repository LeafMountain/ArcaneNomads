// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UInteractorComponent;
#ifdef ARCANENOMADS_Interactable_generated_h
#error "Interactable.generated.h already included, missing '#pragma once' in Interactable.h"
#endif
#define ARCANENOMADS_Interactable_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_RPC_WRAPPERS \
	virtual void StopFocus_Implementation() {}; \
	virtual void StartFocus_Implementation() {}; \
	virtual void Interact_Implementation(UInteractorComponent* Interactor) {}; \
 \
	DECLARE_FUNCTION(execStopFocus) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->StopFocus_Implementation(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execStartFocus) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->StartFocus_Implementation(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execInteract) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Interact_Implementation(Z_Param_Interactor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
	virtual void StopFocus_Implementation() {}; \
	virtual void StartFocus_Implementation() {}; \
	virtual void Interact_Implementation(UInteractorComponent* Interactor) {}; \
 \
	DECLARE_FUNCTION(execStopFocus) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->StopFocus_Implementation(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execStartFocus) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->StartFocus_Implementation(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execInteract) \
	{ \
		P_GET_OBJECT(UInteractorComponent,Z_Param_Interactor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Interact_Implementation(Z_Param_Interactor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_EVENT_PARMS \
	struct Interactable_eventInteract_Parms \
	{ \
		UInteractorComponent* Interactor; \
	};


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_CALLBACK_WRAPPERS
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInteractable(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInteractable) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInteractable); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInteractable); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInteractable(UInteractable&&); \
	NO_API UInteractable(const UInteractable&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UInteractable(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) : Super(ObjectInitializer) { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UInteractable(UInteractable&&); \
	NO_API UInteractable(const UInteractable&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UInteractable); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UInteractable); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UInteractable)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_GENERATED_UINTERFACE_BODY() \
private: \
	static void StaticRegisterNativesUInteractable(); \
	friend struct Z_Construct_UClass_UInteractable_Statics; \
public: \
	DECLARE_CLASS(UInteractable, UInterface, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Interface), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UInteractable)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_GENERATED_BODY_LEGACY \
		PRAGMA_DISABLE_DEPRECATION_WARNINGS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_GENERATED_UINTERFACE_BODY() \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_STANDARD_CONSTRUCTORS \
	PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_GENERATED_BODY \
	PRAGMA_DISABLE_DEPRECATION_WARNINGS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_GENERATED_UINTERFACE_BODY() \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_ENHANCED_CONSTRUCTORS \
private: \
	PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_INCLASS_IINTERFACE_NO_PURE_DECLS \
protected: \
	virtual ~IInteractable() {} \
public: \
	typedef UInteractable UClassType; \
	typedef IInteractable ThisClass; \
	static void Execute_Interact(UObject* O, UInteractorComponent* Interactor); \
	static void Execute_StartFocus(UObject* O); \
	static void Execute_StopFocus(UObject* O); \
	virtual UObject* _getUObject() const { check(0 && "Missing required implementation."); return nullptr; }


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_INCLASS_IINTERFACE \
protected: \
	virtual ~IInteractable() {} \
public: \
	typedef UInteractable UClassType; \
	typedef IInteractable ThisClass; \
	static void Execute_Interact(UObject* O, UInteractorComponent* Interactor); \
	static void Execute_StartFocus(UObject* O); \
	static void Execute_StopFocus(UObject* O); \
	virtual UObject* _getUObject() const { check(0 && "Missing required implementation."); return nullptr; }


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_7_PROLOG \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_EVENT_PARMS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_15_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_INCLASS_IINTERFACE \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_15_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h_10_INCLASS_IINTERFACE_NO_PURE_DECLS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UInteractable>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Interactable_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
