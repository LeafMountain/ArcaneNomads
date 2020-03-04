// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef ARCANENOMADS_EdibleComponent_generated_h
#error "EdibleComponent.generated.h already included, missing '#pragma once' in EdibleComponent.h"
#endif
#define ARCANENOMADS_EdibleComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execGetHungerReduction) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetHungerReduction(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execGetHungerReduction) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetHungerReduction(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUEdibleComponent(); \
	friend struct Z_Construct_UClass_UEdibleComponent_Statics; \
public: \
	DECLARE_CLASS(UEdibleComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UEdibleComponent) \
	virtual UObject* _getUObject() const override { return const_cast<UEdibleComponent*>(this); }


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_INCLASS \
private: \
	static void StaticRegisterNativesUEdibleComponent(); \
	friend struct Z_Construct_UClass_UEdibleComponent_Statics; \
public: \
	DECLARE_CLASS(UEdibleComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UEdibleComponent) \
	virtual UObject* _getUObject() const override { return const_cast<UEdibleComponent*>(this); }


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UEdibleComponent(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UEdibleComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UEdibleComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UEdibleComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UEdibleComponent(UEdibleComponent&&); \
	NO_API UEdibleComponent(const UEdibleComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UEdibleComponent(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) : Super(ObjectInitializer) { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UEdibleComponent(UEdibleComponent&&); \
	NO_API UEdibleComponent(const UEdibleComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UEdibleComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UEdibleComponent); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UEdibleComponent)


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__myHungerReduction() { return STRUCT_OFFSET(UEdibleComponent, myHungerReduction); }


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_7_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h_10_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UEdibleComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_NeedsSystem_EdibleComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
