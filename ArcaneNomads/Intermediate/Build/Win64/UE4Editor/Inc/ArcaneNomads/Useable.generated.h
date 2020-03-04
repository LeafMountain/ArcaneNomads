// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class AActor;
#ifdef ARCANENOMADS_Useable_generated_h
#error "Useable.generated.h already included, missing '#pragma once' in Useable.h"
#endif
#define ARCANENOMADS_Useable_generated_h

#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_RPC_WRAPPERS \
	virtual void Use_Implementation(AActor* anActor) {}; \
 \
	DECLARE_FUNCTION(execUse) \
	{ \
		P_GET_OBJECT(AActor,Z_Param_anActor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Use_Implementation(Z_Param_anActor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
	virtual void Use_Implementation(AActor* anActor) {}; \
 \
	DECLARE_FUNCTION(execUse) \
	{ \
		P_GET_OBJECT(AActor,Z_Param_anActor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Use_Implementation(Z_Param_anActor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_EVENT_PARMS \
	struct Useable_eventUse_Parms \
	{ \
		AActor* anActor; \
	};


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_CALLBACK_WRAPPERS
#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UUseable(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UUseable) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UUseable); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UUseable); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UUseable(UUseable&&); \
	NO_API UUseable(const UUseable&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UUseable(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) : Super(ObjectInitializer) { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UUseable(UUseable&&); \
	NO_API UUseable(const UUseable&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UUseable); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UUseable); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UUseable)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_GENERATED_UINTERFACE_BODY() \
private: \
	static void StaticRegisterNativesUUseable(); \
	friend struct Z_Construct_UClass_UUseable_Statics; \
public: \
	DECLARE_CLASS(UUseable, UInterface, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Interface), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UUseable)


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_GENERATED_BODY_LEGACY \
		PRAGMA_DISABLE_DEPRECATION_WARNINGS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_GENERATED_UINTERFACE_BODY() \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_STANDARD_CONSTRUCTORS \
	PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_GENERATED_BODY \
	PRAGMA_DISABLE_DEPRECATION_WARNINGS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_GENERATED_UINTERFACE_BODY() \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_ENHANCED_CONSTRUCTORS \
private: \
	PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_INCLASS_IINTERFACE_NO_PURE_DECLS \
protected: \
	virtual ~IUseable() {} \
public: \
	typedef UUseable UClassType; \
	typedef IUseable ThisClass; \
	static void Execute_Use(UObject* O, AActor* anActor); \
	virtual UObject* _getUObject() const { check(0 && "Missing required implementation."); return nullptr; }


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_INCLASS_IINTERFACE \
protected: \
	virtual ~IUseable() {} \
public: \
	typedef UUseable UClassType; \
	typedef IUseable ThisClass; \
	static void Execute_Use(UObject* O, AActor* anActor); \
	virtual UObject* _getUObject() const { check(0 && "Missing required implementation."); return nullptr; }


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_7_PROLOG \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_EVENT_PARMS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_15_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_INCLASS_IINTERFACE \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_15_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h_10_INCLASS_IINTERFACE_NO_PURE_DECLS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UUseable>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_InteractionSystem_Useable_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
