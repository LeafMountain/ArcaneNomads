// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef ARCANENOMADS_Weapon_generated_h
#error "Weapon.generated.h already included, missing '#pragma once' in Weapon.h"
#endif
#define ARCANENOMADS_Weapon_generated_h

#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_RPC_WRAPPERS \
	virtual void OnUse_Implementation(); \
 \
	DECLARE_FUNCTION(execOnUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnUse_Implementation(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execStopUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->StopUse(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Use(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	virtual void OnUse_Implementation(); \
 \
	DECLARE_FUNCTION(execOnUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnUse_Implementation(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execStopUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->StopUse(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Use(); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_EVENT_PARMS
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_CALLBACK_WRAPPERS
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAWeapon(); \
	friend struct Z_Construct_UClass_AWeapon_Statics; \
public: \
	DECLARE_CLASS(AWeapon, AActor, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(AWeapon)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_INCLASS \
private: \
	static void StaticRegisterNativesAWeapon(); \
	friend struct Z_Construct_UClass_AWeapon_Statics; \
public: \
	DECLARE_CLASS(AWeapon, AActor, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(AWeapon)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API AWeapon(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(AWeapon) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AWeapon); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AWeapon); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API AWeapon(AWeapon&&); \
	NO_API AWeapon(const AWeapon&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API AWeapon(AWeapon&&); \
	NO_API AWeapon(const AWeapon&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AWeapon); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AWeapon); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(AWeapon)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__MeshComponent() { return STRUCT_OFFSET(AWeapon, MeshComponent); }


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_9_PROLOG \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_EVENT_PARMS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class AWeapon>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Weapon_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
