// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class AWeapon;
#ifdef ARCANENOMADS_Hittable_generated_h
#error "Hittable.generated.h already included, missing '#pragma once' in Hittable.h"
#endif
#define ARCANENOMADS_Hittable_generated_h

#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_RPC_WRAPPERS \
	virtual void OnHit_Implementation(int32 Damage, AWeapon* Instagator) {}; \
 \
	DECLARE_FUNCTION(execOnHit) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_Damage); \
		P_GET_OBJECT(AWeapon,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnHit_Implementation(Z_Param_Damage,Z_Param_Instagator); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_RPC_WRAPPERS_NO_PURE_DECLS \
	virtual void OnHit_Implementation(int32 Damage, AWeapon* Instagator) {}; \
 \
	DECLARE_FUNCTION(execOnHit) \
	{ \
		P_GET_PROPERTY(UIntProperty,Z_Param_Damage); \
		P_GET_OBJECT(AWeapon,Z_Param_Instagator); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnHit_Implementation(Z_Param_Damage,Z_Param_Instagator); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_EVENT_PARMS \
	struct Hittable_eventOnHit_Parms \
	{ \
		int32 Damage; \
		AWeapon* Instagator; \
	};


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_CALLBACK_WRAPPERS
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UHittable(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UHittable) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UHittable); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UHittable); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UHittable(UHittable&&); \
	NO_API UHittable(const UHittable&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UHittable(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()) : Super(ObjectInitializer) { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UHittable(UHittable&&); \
	NO_API UHittable(const UHittable&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UHittable); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UHittable); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UHittable)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_GENERATED_UINTERFACE_BODY() \
private: \
	static void StaticRegisterNativesUHittable(); \
	friend struct Z_Construct_UClass_UHittable_Statics; \
public: \
	DECLARE_CLASS(UHittable, UInterface, COMPILED_IN_FLAGS(CLASS_Abstract | CLASS_Interface), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UHittable)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_GENERATED_BODY_LEGACY \
		PRAGMA_DISABLE_DEPRECATION_WARNINGS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_GENERATED_UINTERFACE_BODY() \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_STANDARD_CONSTRUCTORS \
	PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_GENERATED_BODY \
	PRAGMA_DISABLE_DEPRECATION_WARNINGS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_GENERATED_UINTERFACE_BODY() \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_ENHANCED_CONSTRUCTORS \
private: \
	PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_INCLASS_IINTERFACE_NO_PURE_DECLS \
protected: \
	virtual ~IHittable() {} \
public: \
	typedef UHittable UClassType; \
	typedef IHittable ThisClass; \
	static void Execute_OnHit(UObject* O, int32 Damage, AWeapon* Instagator); \
	virtual UObject* _getUObject() const { check(0 && "Missing required implementation."); return nullptr; }


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_INCLASS_IINTERFACE \
protected: \
	virtual ~IHittable() {} \
public: \
	typedef UHittable UClassType; \
	typedef IHittable ThisClass; \
	static void Execute_OnHit(UObject* O, int32 Damage, AWeapon* Instagator); \
	virtual UObject* _getUObject() const { check(0 && "Missing required implementation."); return nullptr; }


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_5_PROLOG \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_EVENT_PARMS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_13_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_INCLASS_IINTERFACE \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_13_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_CALLBACK_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h_8_INCLASS_IINTERFACE_NO_PURE_DECLS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UHittable>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_WeaponSystem_Hittable_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
