// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UUserWidget;
#ifdef ARCANENOMADS_UISubsystem_generated_h
#error "UISubsystem.generated.h already included, missing '#pragma once' in UISubsystem.h"
#endif
#define ARCANENOMADS_UISubsystem_generated_h

#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_SPARSE_DATA
#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execCloseTop) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->CloseTop(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execCloseAll) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->CloseAll(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execOpenWidget) \
	{ \
		P_GET_OBJECT(UClass,Z_Param_aWidget); \
		P_GET_UBOOL(Z_Param_unlockMouse); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UUserWidget**)Z_Param__Result=P_THIS->OpenWidget(Z_Param_aWidget,Z_Param_unlockMouse); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execCloseTop) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->CloseTop(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execCloseAll) \
	{ \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->CloseAll(); \
		P_NATIVE_END; \
	} \
 \
	DECLARE_FUNCTION(execOpenWidget) \
	{ \
		P_GET_OBJECT(UClass,Z_Param_aWidget); \
		P_GET_UBOOL(Z_Param_unlockMouse); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		*(UUserWidget**)Z_Param__Result=P_THIS->OpenWidget(Z_Param_aWidget,Z_Param_unlockMouse); \
		P_NATIVE_END; \
	}


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesUUISubsystem(); \
	friend struct Z_Construct_UClass_UUISubsystem_Statics; \
public: \
	DECLARE_CLASS(UUISubsystem, UGameInstanceSubsystem, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UUISubsystem)


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_INCLASS \
private: \
	static void StaticRegisterNativesUUISubsystem(); \
	friend struct Z_Construct_UClass_UUISubsystem_Statics; \
public: \
	DECLARE_CLASS(UUISubsystem, UGameInstanceSubsystem, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/ArcaneNomads"), NO_API) \
	DECLARE_SERIALIZER(UUISubsystem)


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UUISubsystem(const FObjectInitializer& ObjectInitializer = FObjectInitializer::Get()); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(UUISubsystem) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UUISubsystem); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UUISubsystem); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UUISubsystem(UUISubsystem&&); \
	NO_API UUISubsystem(const UUISubsystem&); \
public:


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_ENHANCED_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API UUISubsystem() { }; \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API UUISubsystem(UUISubsystem&&); \
	NO_API UUISubsystem(const UUISubsystem&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, UUISubsystem); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(UUISubsystem); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(UUISubsystem)


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_PRIVATE_PROPERTY_OFFSET
#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_14_PROLOG
#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_RPC_WRAPPERS \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_INCLASS \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_PRIVATE_PROPERTY_OFFSET \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_SPARSE_DATA \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_RPC_WRAPPERS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_INCLASS_NO_PURE_DECLS \
	ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h_17_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> ARCANENOMADS_API UClass* StaticClass<class UUISubsystem>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID ArcaneNomads_Source_ArcaneNomads_UISubsystem_UISubsystem_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
