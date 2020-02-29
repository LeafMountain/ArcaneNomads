// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class AWeapon;
class USceneComponent;
#ifdef ARCANENOMADS_ToolUser_generated_h
#error "ToolUser.generated.h already included, missing '#pragma once' in ToolUser.h"
#endif
#define ARCANENOMADS_ToolUser_generated_h

#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execUseInactivate) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->UseInactivate(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUseActivate) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->UseActivate(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Use(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUnequip) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(AWeapon**)Z_Param__Result=P_THIS->Unequip(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execEquip) \
	{ \
		P_GET_OBJECT(AWeapon,Z_Param_Tool); \
		P_GET_OBJECT(USceneComponent,Z_Param_Parent); \
		P_GET_PROPERTY(UNameProperty,Z_Param_SocketName); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Equip(Z_Param_Tool,Z_Param_Parent,Z_Param_SocketName); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execUseInactivate) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->UseInactivate(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUseActivate) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->UseActivate(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUse) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Use(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execUnequip) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(AWeapon**)Z_Param__Result=P_THIS->Unequip(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execEquip) \
	{ \
		P_GET_OBJECT(AWeapon,Z_Param_Tool); \
		P_GET_OBJECT(USceneComponent,Z_Param_Parent); \
		P_GET_PROPERTY(UNameProperty,Z_Param_SocketName); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->Equip(Z_Param_Tool,Z_Param_Parent,Z_Param_SocketName); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUToolUser(); \
	friend struct Z_Construct_UClass_UToolUser_Statics; \
public: \
	DECLARE_CLASS(UToolUser, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UToolUser)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_INCLASS \
private: \
	static void StaticRegisterNativesUToolUser(); \
	friend struct Z_Construct_UClass_UToolUser_Statics; \
public: \
	DECLARE_CLASS(UToolUser, UActorComponent, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UToolUser)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UToolUser(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UToolUser) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UToolUser); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UToolUser); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UToolUser(UToolUser&&); \
	NO_API UToolUser(const UToolUser&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UToolUser(UToolUser&&); \
	NO_API UToolUser(const UToolUser&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UToolUser); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UToolUser); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UToolUser)


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_PRIVATE_PROPERTY_OFFSET
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_9_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UToolUser>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_WeaponSystem_ToolUser_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
