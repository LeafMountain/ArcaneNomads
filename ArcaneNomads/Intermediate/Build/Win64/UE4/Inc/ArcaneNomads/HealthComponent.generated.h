// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class AActor;
#ifdef ARCANENOMADS_HealthComponent_generated_h
#error "HealthComponent.generated.h already included, missing '#pragma once' in HealthComponent.h"
#endif
#define ARCANENOMADS_HealthComponent_generated_h

#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_8_DELEGATE \
struct _Script_ArcaneNomads_eventHitEventOne_Parms \
{ \
	AActor* Instagator; \
}; \
static inline void FHitEventOne_DelegateWrapper(const FMulticastScriptDelegate& HitEventOne, AActor* Instagator) \
{ \
	_Script_ArcaneNomads_eventHitEventOne_Parms Parms; \
	Parms.Instagator=Instagator; \
	HitEventOne.ProcessMulticastDelegate<UObject>(&Parms); \
}


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_7_DELEGATE \
struct _Script_ArcaneNomads_eventHitEventTwo_Parms \
{ \
	int32 Damage; \
	AActor* Instagator; \
}; \
static inline void FHitEventTwo_DelegateWrapper(const FMulticastScriptDelegate& HitEventTwo, int32 Damage, AActor* Instagator) \
{ \
	_Script_ArcaneNomads_eventHitEventTwo_Parms Parms; \
	Parms.Damage=Damage; \
	Parms.Instagator=Instagator; \
	HitEventTwo.ProcessMulticastDelegate<UObject>(&Parms); \
}


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execAdjustHealth) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_value); \
		P_GET_OBJECT(AActor,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->AdjustHealth(Z_Param_value,Z_Param_Instagator); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execApplyHealing) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_value); \
		P_GET_OBJECT(AActor,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->ApplyHealing(Z_Param_value,Z_Param_Instagator); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execApplyDamage) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_value); \
		P_GET_OBJECT(AActor,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->ApplyDamage(Z_Param_value,Z_Param_Instagator); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetHealthPercentage) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetHealthPercentage(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetMaxHealth) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(int32*)Z_Param__Result=P_THIS->GetMaxHealth(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetCurrentHealth) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(int32*)Z_Param__Result=P_THIS->GetCurrentHealth(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execAdjustHealth) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_value); \
		P_GET_OBJECT(AActor,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->AdjustHealth(Z_Param_value,Z_Param_Instagator); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execApplyHealing) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_value); \
		P_GET_OBJECT(AActor,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->ApplyHealing(Z_Param_value,Z_Param_Instagator); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execApplyDamage) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_value); \
		P_GET_OBJECT(AActor,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->ApplyDamage(Z_Param_value,Z_Param_Instagator); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetHealthPercentage) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(float*)Z_Param__Result=P_THIS->GetHealthPercentage(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetMaxHealth) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(int32*)Z_Param__Result=P_THIS->GetMaxHealth(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execGetCurrentHealth) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(int32*)Z_Param__Result=P_THIS->GetCurrentHealth(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUHealthComponent(); \
	friend struct Z_Construct_UClass_UHealthComponent_Statics; \
public: \
	DECLARE_CLASS(UHealthComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UHealthComponent)


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_INCLASS \
private: \
	static void StaticRegisterNativesUHealthComponent(); \
	friend struct Z_Construct_UClass_UHealthComponent_Statics; \
public: \
	DECLARE_CLASS(UHealthComponent, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UHealthComponent)


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UHealthComponent(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UHealthComponent) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UHealthComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UHealthComponent); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UHealthComponent(UHealthComponent&&); \
	NO_API UHealthComponent(const UHealthComponent&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UHealthComponent(UHealthComponent&&); \
	NO_API UHealthComponent(const UHealthComponent&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UHealthComponent); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UHealthComponent); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UHealthComponent)


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__MaxHealth() { return STRUCT_OFFSET(UHealthComponent, MaxHealth); }


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_11_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h_14_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UHealthComponent>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_HealthSystem_HealthComponent_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
