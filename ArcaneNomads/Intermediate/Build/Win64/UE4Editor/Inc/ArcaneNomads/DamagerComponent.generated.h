// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class AActor;
#ifdef ARCANENOMADS_DamagerComponent_generated_h
#error "DamagerComponent.generated.h already included, missing '#pragma once' in DamagerComponent.h"
#endif
#define ARCANENOMADS_DamagerComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execSetOwner) \
	{ \
		P_GET_OBJECT(AActor,Z_Param_Owner); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetOwner(Z_Param_Owner); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execDamage) \
	{ \
		P_GET_OBJECT(AActor,Z_Param_OtherActor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Damage(Z_Param_OtherActor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execSetOwner) \
	{ \
		P_GET_OBJECT(AActor,Z_Param_Owner); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->SetOwner(Z_Param_Owner); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execDamage) \
	{ \
		P_GET_OBJECT(AActor,Z_Param_OtherActor); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Damage(Z_Param_OtherActor); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUDamagerComponent(); \
	friend struct Z_Construct_UClass_UDamagerComponent_Statics; \
public: \
	DECLARE_CLASS(UDamagerComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UDamagerComponent)


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_INCLASS \
private: \
	static void StaticRegisterNativesUDamagerComponent(); \
	friend struct Z_Construct_UClass_UDamagerComponent_Statics; \
public: \
	DECLARE_CLASS(UDamagerComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UDamagerComponent)


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UDamagerComponent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UDamagerComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UDamagerComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UDamagerComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UDamagerComponent(UDamagerComponent&&); \
	NO_API UDamagerComponent(const UDamagerComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UDamagerComponent(UDamagerComponent&&); \
	NO_API UDamagerComponent(const UDamagerComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UDamagerComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UDamagerComponent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UDamagerComponent)


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__DamageValue() { return STRUCT_OFFSET(UDamagerComponent, DamageValue); }


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_7_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h_10_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UDamagerComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_HealthSystem_DamagerComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
