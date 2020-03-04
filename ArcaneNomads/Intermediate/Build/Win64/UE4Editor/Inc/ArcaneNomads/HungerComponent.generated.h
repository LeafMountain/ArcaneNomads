// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef ARCANENOMADS_HungerComponent_generated_h
#error "HungerComponent.generated.h already included, missing '#pragma once' in HungerComponent.h"
#endif
#define ARCANENOMADS_HungerComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execGetTimeRemaining) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetTimeRemaining(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execSetTimeUntilDepleted) \
	{ \
		P_GET_PROPERTY(UFloatProperty,Z_Param_aTimeInSeconds); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetTimeUntilDepleted(Z_Param_aTimeInSeconds); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execResetDecayMultiplier) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->ResetDecayMultiplier(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execSetDecayMultiplier) \
	{ \
		P_GET_PROPERTY(UFloatProperty,Z_Param_aMultiplier); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetDecayMultiplier(Z_Param_aMultiplier); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetDecayMultiplier) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetDecayMultiplier(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetDecayRate) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetDecayRate(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetHunger) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetHunger(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execGetTimeRemaining) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetTimeRemaining(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execSetTimeUntilDepleted) \
	{ \
		P_GET_PROPERTY(UFloatProperty,Z_Param_aTimeInSeconds); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetTimeUntilDepleted(Z_Param_aTimeInSeconds); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execResetDecayMultiplier) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->ResetDecayMultiplier(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execSetDecayMultiplier) \
	{ \
		P_GET_PROPERTY(UFloatProperty,Z_Param_aMultiplier); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetDecayMultiplier(Z_Param_aMultiplier); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetDecayMultiplier) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetDecayMultiplier(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetDecayRate) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetDecayRate(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetHunger) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetHunger(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUHungerComponnent(); \
	friend struct Z_Construct_UClass_UHungerComponnent_Statics; \
public: \
	DECLARE_CLASS(UHungerComponnent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UHungerComponnent)


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_INCLASS \
private: \
	static void StaticRegisterNativesUHungerComponnent(); \
	friend struct Z_Construct_UClass_UHungerComponnent_Statics; \
public: \
	DECLARE_CLASS(UHungerComponnent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UHungerComponnent)


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UHungerComponnent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UHungerComponnent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UHungerComponnent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UHungerComponnent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UHungerComponnent(UHungerComponnent&&); \
	NO_API UHungerComponnent(const UHungerComponnent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UHungerComponnent(UHungerComponnent&&); \
	NO_API UHungerComponnent(const UHungerComponnent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UHungerComponnent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UHungerComponnent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UHungerComponnent)


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__myTimeUntilDepletedFromFullHealth() { return STRUCT_OFFSET(UHungerComponnent, myTimeUntilDepletedFromFullHealth); }


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_6_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h_9_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UHungerComponnent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_NeedsSystem_HungerComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
