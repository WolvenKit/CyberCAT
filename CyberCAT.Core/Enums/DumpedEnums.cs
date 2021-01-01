using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.DumpedEnums
{

	public enum AIArgumentType
	{
		Bool,
		Int,
		Uint64,
		Enum,
		Float,
		CName,
		TreeRef,
		Vector,
		Object,
		NodeRef,
		GlobalNodeId,
		PuppetRef,
		Serializable,
		TweakDBID
	}

	public enum AICombatSectorType
	{
		ToBackLeft,
		ToBackMid,
		ToBackRight,
		ToLeft,
		ToMid,
		ToRight,
		FromLeft,
		FromMid,
		FromRight,
		FromBackLeft,
		FromBackMid,
		FromBackRight,
		BeyondToLeft,
		BeyondToRight,
		BeyondFromLeft,
		BeyondFromRight,
		Unknown
	}

	public enum AICombatSpaceSize
	{
		Undefined,
		Narrow,
		Medium,
		Huge
	}

	public enum AICommandContextsType
	{
		Default,
		Immediate,
		Movement,
		Workspot,
		Aiming
	}

	public enum AICommandState
	{
		NotExecuting,
		Enqueued,
		Executing,
		Cancelled,
		Interrupted,
		Success,
		Failure
	}

	public enum AICoverExposureMethod
	{
		Standing_Step_Left,
		Standing_Step_Right,
		Standing_Lean_Left,
		Standing_Lean_Right,
		Crouching_Step_Left,
		Crouching_Step_Right,
		Crouching_Lean_Left,
		Crouching_Lean_Right,
		Lean_Over,
		Stand_Up,
		Standing_Blind_Left,
		Standing_Blind_Right,
		Crouching_Blind_Left,
		Crouching_Blind_Right,
		Crouching_Blind_Top,
		Count
	}

	public enum AIEExecutionOutcome
	{
		OUTCOME_FAILURE,
		OUTCOME_SUCCESS,
		OUTCOME_IN_PROGRESS
	}

	public enum AIEExecutionStatus
	{
		STATUS_INVALID,
		STATUS_SUCCESS,
		STATUS_FAILURE,
		STATUS_RUNNING,
		STATUS_ABORTED
	}

	public enum AIEInterruptionImportance
	{
		Undefined,
		Casual,
		Rush,
		Immediate,
		ForcedImmediate
	}

	public enum AIEInterruptionOutcome
	{
		INTERRUPTION_SUCCESS,
		INTERRUPTION_DELAYED,
		INTERRUPTION_FAILED
	}

	public enum AIESharedVarDefinitionType
	{
		SVInt,
		SVFloat,
		SVBool,
		SVName,
		SVTarget,
		SVPosition,
		SVNodeInstance,
		SVGlobalNodeRef
	}

	public enum AIForcedBehaviourPriority
	{
		AboveIdle,
		AboveCombat,
		AboveCriticalState,
		AboveDeath
	}

	public enum AIIWorkspotManagerSpotUsageState
	{
		Reserved,
		Occupied,
		None
	}

	public enum AIParameterizationType
	{
		BehaviorArgument,
		CustomValue,
		CharacterRecord,
		TweakDB,
		ActionRecord,
		Blackboard,
		Delegate
	}

	public enum AIReactionCountOutcome
	{
		Failed,
		Succeded,
		NotFound
	}

	public enum AISignalFlags
	{
		Undefined,
		OverridesSelf,
		InterruptsSamePriorityTask,
		InterruptsForcedBehavior,
		AcceptsAdditives
	}

	public enum AISocketsForRig
	{
		Undefined,
		ManAverage,
		ManBig,
		ManFat,
		WomanAverage,
		WomanBig,
		ChildMale
	}

	public enum AISquadType
	{
		Community,
		Global,
		Security,
		Attitude,
		Combat,
		Follower,
		Unknown
	}

	public enum AIThreatPersistenceStatus
	{
		ThreatNotFound,
		Persistent,
		NotPersistent
	}

	public enum AITrackedStatusType
	{
		Unknown,
		Friendly,
		Neutral,
		Hostile
	}

	public enum AIUninterruptibleActionType
	{
		None,
		Default,
		EnteringCover,
		LeavingCover,
		Count
	}

	public enum AIactionParamsPackageTypes
	{
		Default,
		Reaction,
		StatusEffect,
		Undefined
	}

	public enum AIbehaviorActivationStatus
	{
		NOT_ACTIVATED,
		ACTIVATING,
		ACTIVATED,
		DEACTIVATING
	}

	public enum AIbehaviorCombatModes
	{
		Default,
		LowFPS,
		Background
	}

	public enum AIbehaviorCompletionStatus
	{
		FAILURE,
		SUCCESS
	}

	public enum AIbehaviorConditionOutcomes
	{
		True,
		False,
		Failure
	}

	public enum AIbehaviorDebugNodeStatus
	{
		Undefined,
		NotRunning,
		ForceStopped,
		Running,
		Success,
		Failure
	}

	public enum AIbehaviorEdgeConditionAction
	{
		None,
		Toggle,
		TurnOn,
		TurnOff
	}

	public enum AIbehaviorEntityLODConditions
	{
		Crowd,
		Cinematic,
		WorkspotStatic
	}

	public enum AIbehaviorMaybeNodeAction
	{
		Succeed,
		Fail,
		RepeatChild
	}

	public enum AIbehaviorMovementPolicyTaskFunctions
	{
		SetMovementType,
		SetTargetObject,
		UseFollowSlots,
		SetLocalTargetOffset,
		SetIgnoreNavigation,
		SetStrafingTarget
	}

	public enum AIbehaviorNaryExpressionOperators
	{
		LogicalAnd,
		LogicalOr
	}

	public enum AIbehaviorParallelNodeChildState
	{
		Inactive,
		Active,
		Completed
	}

	public enum AIbehaviorParallelNodeWaitFor
	{
		LeftChild,
		RightChild,
		AllChildren,
		BothChildren,
		AnyChild
	}

	public enum AIbehaviorSignalConditionModes
	{
		CurrentValue,
		StartOfFrameValue,
		RisingEdge,
		FallingEdge,
		AnyEdge
	}

	public enum AIbehaviorStateCompletionStatus
	{
		ForwardBehaviorStatus,
		Failure,
		Success
	}

	public enum AIbehaviorStoryActionType
	{
		Setup,
		Stop
	}

	public enum AIbehaviorSystemVariableExpressionTypes
	{
		IsFPSLow
	}

	public enum AIbehaviorUpdateOutcome
	{
		IN_PROGRESS,
		SUCCESS,
		FAILURE
	}

	public enum AIinfluenceEBumpPolicy
	{
		Static,
		Lean,
		Move
	}

	public enum AdvertisementFormat
	{
		Format_0_7x1,
		Format_1x1,
		Format_1x0_7,
		Format_1x1_5,
		Format_1x2,
		Format_1x3_3,
		Format_1_5x1,
		Format_2x1,
		Format_3_3x1,
		Format_3x4,
		Format_4x3,
		Format_9x16,
		Format_9x21,
		Format_16x9,
		Format_21x9,
		Format_a,
		Format_b,
		Format_c,
		Format_d,
		Format_e,
		Format_f,
		Format_i,
		Format_o,
		Format_k
	}

	public enum AdvertisementLoadMode
	{
		TweakDB,
		Override
	}

	public enum ConfigGraphicsQualityLevel
	{
		Low,
		Medium,
		High,
		Ultra,
		RTXMedium,
		RTXUltra,
		Cinematic,
		Cinematic_RTX,
		CinematicEXR,
		CinematicEXR_RTX,
		SafeMode,
		Console,
		ConsolePro,
		ConsoleEarlyNextGen,
		ConsoleEarlyNextGenQuality,
		GeForceNow,
		IconsGeneration,
		Auto
	}

	public enum ConfigTextureQualityLevel
	{
		Console,
		ConsoleSafe,
		Low,
		Medium,
		High,
		SafeMode,
		Auto
	}

	public enum DynamicTextureDataFormat
	{
		R_Uint8,
		R_Float16,
		R_Float32,
		RG_Float16,
		RG_Float32,
		RGBA_Uint8,
		RGBA_Uint8_SRGB,
		RGBA_Float16,
		RGBA_Float32
	}

	public enum EAIAttitude
	{
		AIA_Friendly,
		AIA_Neutral,
		AIA_Hostile
	}

	public enum EAnimationBufferDataAvailable
	{
		ABDA_None,
		ABDA_Partial,
		ABDA_All
	}

	public enum EAreaLightShape
	{
		ALS_Sphere,
		ALS_Capsule
	}

	public enum EColorChannel
	{
		COLCHANNEL_Red,
		COLCHANNEL_Green,
		COLCHANNEL_Blue,
		COLCHANNEL_Alpha
	}

	public enum EColorMappingFunction
	{
		CMF_Linear,
		CMF_sRGB,
		CMF_ArriLogC
	}

	public enum EColorPrimary
	{
		PRIM_REC709,
		PRIM_DCIP3,
		PRIM_BT2020
	}

	public enum EComparisonType
	{
		Greater,
		GreaterOrEqual,
		Equal,
		NotEqual,
		Less,
		LessOrEqual
	}

	public enum ECookingPlatform
	{
		PLATFORM_None,
		PLATFORM_PC,
		PLATFORM_XboxOne,
		PLATFORM_PS4,
		PLATFORM_WindowsServer,
		PLATFORM_LinuxServer
	}

	public enum ECubeSourceTextureType
	{
		CST_CrossHorizontal,
		CST_CrossVertical,
		CST_Panorama
	}

	public enum ECustomCameraTarget
	{
		ECCTV_All,
		ECCTV_OnlyOffscreen,
		ECCTV_OnlyOnscreen
	}

	public enum ECustomMaterialParam
	{
		ECMP_CustomParam0,
		ECMP_CustomParam1,
		ECMP_CustomParam2,
		ECMP_CustomParam3,
		ECMP_CustomParam4,
		ECMP_CustomParam5,
		ECMP_CustomParam6
	}

	public enum EDecalRenderMode
	{
		DRM_AllStatic,
		DRM_ObjectType,
		DRM_AllDynamic
	}

	public enum EDepthCollisionEffect
	{
		DCE_Bounce,
		DCE_Glide,
		DCE_Kill
	}

	public enum EDynamicDecalSpawnPriority
	{
		RDDS_Normal,
		RDDS_Highest
	}

	public enum EEasingType
	{
		EET_In,
		EET_Out,
		EET_InOut
	}

	public enum EEmitterGroup
	{
		EG_Default,
		EG_Group0,
		EG_Group1,
		EG_Group2,
		EG_Group3,
		EG_Group4,
		EG_Group5,
		EG_Group6,
		EG_Group7,
		EG_Group8,
		EG_Group9,
		EG_Group10,
		EG_Group11,
		EG_Group12,
		EG_Group13,
		EG_Group14,
		EG_Group15
	}

	public enum EEntityHighlightType
	{
		EHE_None,
		EHE_FillAndOutline,
		EHE_FillOnly,
		EHE_OutlineOnly
	}

	public enum EEnvColorGroup
	{
		ECG_Default,
		ECG_Sky,
		ECG_Group0,
		ECG_Group1,
		ECG_Group2,
		ECG_Group3,
		ECG_Group4,
		ECG_Group5,
		ECG_Group6,
		ECG_Group7,
		ECG_Group8,
		ECG_Group9,
		ECG_Group10,
		ECG_Group11,
		ECG_Group12,
		ECG_Group13,
		ECG_Group14,
		ECG_Group15
	}

	public enum EEnvManagerModifier
	{
		EMM_None,
		EMM_WireframeSolid,
		EMM_WireframeSeethrough,
		EMM_Overdraw,
		EMM_OverdrawSeethrough,
		EMM_ParticleOverdraw,
		EMM_ParticleNumLights,
		EMM_DecalOverdraw,
		EMM_LightOverdraw,
		EMM_SceneReferredColor,
		EMM_DisplayReferredColor,
		EMM_GlobalIllumination,
		EMM_SurfaceMaterialID,
		EMM_SurfaceObjectID,
		EMM_SurfaceBaseColor,
		EMM_SurfaceAlbedo,
		EMM_SurfaceSpecularity,
		EMM_SurfaceMetalness,
		EMM_SurfaceRoughness,
		EMM_SurfaceEmissive,
		EMM_SurfaceTranslucency,
		EMM_SurfaceNormalsWorldSpace,
		EMM_SurfaceNormalsViewSpace,
		EMM_SurfaceHairDirection,
		EMM_SurfaceHairID,
		EMM_SurfaceLightBlockerIntensity,
		EMM_GBuffer1RGB,
		EMM_GBuffer1A,
		EMM_ConeAODir,
		EMM_ConeAOAngle,
		EMM_VelocityBuffer,
		EMM_Depth,
		EMM_UvDensity,
		EMM_ToneMappingLuminance,
		EMM_ToneMappingThresholds,
		EMM_LuminanceSpotMeter,
		EMM_IlluminanceMeter,
		EMM_DiffuseLight,
		EMM_SpecularLight,
		EMM_ClayView,
		EMM_PureGreyscaleView,
		EMM_PureWhiteView,
		EMM_PureReflectionView,
		EMM_PureGreyReflectionView,
		EMM_Cascades,
		EMM_MaskShadow,
		EMM_MaskSSAO,
		EMM_MaskTXAA,
		EMM_MaskDistortion,
		EMM_SurfaceCacheID,
		EMM_SurfaceCacheResolution,
		EMM_LightChannels,
		EMM_DebugHitProxies,
		EMM_DebugShadowsMode,
		EMM_RayTracingDebug,
		EMM_SSRResults,
		EMM_SSRFade,
		EMM_DepthOfFieldCoC,
		EMM_MultilayeredMode,
		EMM_MultilayeredProxy,
		EMM_MultilayeredUniqueMasks,
		EMM_MultilayeredMaskWeight,
		EMM_LocalShadowsVariance,
		EMM_LocalShadowsRangesOverlapDynamicsOnly,
		EMM_LocalShadowsRangesOverlapStaticsOnly,
		EMM_LODColoring,
		EMM_TodvisRuntimePreview,
		EMM_TodvisBakePreview,
		EMM_RainMask,
		EMM_VolFogDensity
	}

	public enum EFeatureFlag
	{
		FEATFLAG_Default,
		FEATFLAG_Shadows,
		FEATFLAG_HitProxies,
		FEATFLAG_Selection,
		FEATFLAG_Wireframe,
		FEATFLAG_Overdraw,
		FEATFLAG_VelocityBuffer,
		FEATFLAG_DebugDraw_BlendOff,
		FEATFLAG_DebugDraw_BlendOn,
		FEATFLAG_DynamicDecals,
		FEATFLAG_Highlights,
		FEATFLAG_IndirectInstancedGrass,
		FEATFLAG_DecalsOnStaticObjects,
		FEATFLAG_DecalsOnDynamicObjects,
		FEATFLAG_MaskParticlesInsideCar,
		FEATFLAG_MaskParticlesInsideInterior,
		FEATFLAG_MaskTXAA,
		FEATFLAG_DistantShadows,
		FEATFLAG_FloatTracks,
		FEATFLAG_Rain,
		FEATFLAG_NumLights,
		FEATFLAG_DepthPrepass
	}

	public enum EFreeVectorAxes
	{
		FVA_One,
		FVA_Two,
		FVA_Three,
		FVA_Four
	}

	public enum EInputAction
	{
		IACT_None,
		IACT_Press,
		IACT_Release,
		IACT_Axis
	}

	public enum EInputCustomKey
	{
		ICK_Pad_DigitLeftRight,
		ICK_Pad_DigitUpDown,
		ICK_Count
	}

	public enum EInputKey
	{
		IK_None,
		IK_LeftMouse,
		IK_RightMouse,
		IK_MiddleMouse,
		IK_Unknown04,
		IK_Unknown05,
		IK_Unknown06,
		IK_Unknown07,
		IK_Backspace,
		IK_Tab,
		IK_Unknown0A,
		IK_Unknown0B,
		IK_Unknown0C,
		IK_Enter,
		IK_Unknown0E,
		IK_Unknown0F,
		IK_Shift,
		IK_Ctrl,
		IK_Alt,
		IK_Pause,
		IK_CapsLock,
		IK_Unknown15,
		IK_Unknown16,
		IK_Unknown17,
		IK_Unknown18,
		IK_Unknown19,
		IK_Unknown1A,
		IK_Escape,
		IK_Unknown1C,
		IK_Unknown1D,
		IK_Unknown1E,
		IK_Unknown1F,
		IK_Space,
		IK_PageUp,
		IK_PageDown,
		IK_End,
		IK_Home,
		IK_Left,
		IK_Up,
		IK_Right,
		IK_Down,
		IK_Select,
		IK_Print,
		IK_Execute,
		IK_PrintScrn,
		IK_Insert,
		IK_Delete,
		IK_Help,
		IK_0,
		IK_1,
		IK_2,
		IK_3,
		IK_4,
		IK_5,
		IK_6,
		IK_7,
		IK_8,
		IK_9,
		IK_Unknown3A,
		IK_Unknown3B,
		IK_Unknown3C,
		IK_Unknown3D,
		IK_Unknown3E,
		IK_Unknown3F,
		IK_Unknown40,
		IK_A,
		IK_B,
		IK_C,
		IK_D,
		IK_E,
		IK_F,
		IK_G,
		IK_H,
		IK_I,
		IK_J,
		IK_K,
		IK_L,
		IK_M,
		IK_N,
		IK_O,
		IK_P,
		IK_Q,
		IK_R,
		IK_S,
		IK_T,
		IK_U,
		IK_V,
		IK_W,
		IK_X,
		IK_Y,
		IK_Z,
		IK_Unknown5B,
		IK_Unknown5C,
		IK_Unknown5D,
		IK_Unknown5E,
		IK_Unknown5F,
		IK_NumPad0,
		IK_NumPad1,
		IK_NumPad2,
		IK_NumPad3,
		IK_NumPad4,
		IK_NumPad5,
		IK_NumPad6,
		IK_NumPad7,
		IK_NumPad8,
		IK_NumPad9,
		IK_NumStar,
		IK_NumPlus,
		IK_Separator,
		IK_NumMinus,
		IK_NumPeriod,
		IK_NumSlash,
		IK_F1,
		IK_F2,
		IK_F3,
		IK_F4,
		IK_F5,
		IK_F6,
		IK_F7,
		IK_F8,
		IK_F9,
		IK_F10,
		IK_F11,
		IK_F12,
		IK_F13,
		IK_F14,
		IK_F15,
		IK_F16,
		IK_F17,
		IK_F18,
		IK_F19,
		IK_F20,
		IK_F21,
		IK_F22,
		IK_F23,
		IK_F24,
		IK_Pad_A_CROSS,
		IK_Pad_B_CIRCLE,
		IK_Pad_X_SQUARE,
		IK_Pad_Y_TRIANGLE,
		IK_Pad_Start,
		IK_Pad_Back_Select,
		IK_Pad_DigitUp,
		IK_Pad_DigitDown,
		IK_Pad_DigitLeft,
		IK_Pad_DigitRight,
		IK_Pad_LeftThumb,
		IK_Pad_RightThumb,
		IK_Pad_LeftShoulder,
		IK_Pad_RightShoulder,
		IK_Pad_LeftTrigger,
		IK_Pad_RightTrigger,
		IK_Pad_LeftAxisX,
		IK_Pad_LeftAxisY,
		IK_Pad_RightAxisX,
		IK_Pad_RightAxisY,
		IK_NumLock,
		IK_ScrollLock,
		IK_Unknown9E,
		IK_Unknown9F,
		IK_LShift,
		IK_RShift,
		IK_LControl,
		IK_RControl,
		IK_UnknownA4,
		IK_UnknownA5,
		IK_UnknownA6,
		IK_UnknownA7,
		IK_UnknownA8,
		IK_UnknownA9,
		IK_UnknownAA,
		IK_UnknownAB,
		IK_UnknownAC,
		IK_UnknownAD,
		IK_UnknownAE,
		IK_UnknownAF,
		IK_UnknownB0,
		IK_UnknownB1,
		IK_UnknownB2,
		IK_UnknownB3,
		IK_UnknownB4,
		IK_UnknownB5,
		IK_UnknownB6,
		IK_UnknownB7,
		IK_UnknownB8,
		IK_Unicode,
		IK_Semicolon,
		IK_Equals,
		IK_Comma,
		IK_Minus,
		IK_Period,
		IK_Slash,
		IK_Tilde,
		IK_Mouse4,
		IK_Mouse5,
		IK_Mouse6,
		IK_Mouse7,
		IK_Mouse8,
		IK_UnknownC6,
		IK_UnknownC7,
		IK_Joy1,
		IK_Joy2,
		IK_Joy3,
		IK_Joy4,
		IK_Joy5,
		IK_Joy6,
		IK_Joy7,
		IK_Joy8,
		IK_Joy9,
		IK_Joy10,
		IK_Joy11,
		IK_Joy12,
		IK_Joy13,
		IK_Joy14,
		IK_Joy15,
		IK_Joy16,
		IK_UnknownD8,
		IK_UnknownD9,
		IK_UnknownDA,
		IK_LeftBracket,
		IK_Backslash,
		IK_RightBracket,
		IK_SingleQuote,
		IK_UnknownDF,
		IK_UnknownE0,
		IK_UnknownE1,
		IK_UnknownE2,
		IK_MouseHover,
		IK_MouseX,
		IK_MouseY,
		IK_MouseZ,
		IK_MouseW,
		IK_JoyU,
		IK_JoyV,
		IK_JoySlider1,
		IK_JoySlider2,
		IK_MouseWheelUp,
		IK_MouseWheelDown,
		IK_UnknownEE,
		IK_UnknownEF,
		IK_JoyX,
		IK_JoyY,
		IK_JoyZ,
		IK_JoyR,
		IK_UnknownF4,
		IK_UnknownF5,
		IK_Attn,
		IK_ClearSel,
		IK_ExSel,
		IK_ErEof,
		IK_Play,
		IK_Zoom,
		IK_NoName,
		IK_UnknownFD,
		IK_UnknownFE,
		IK_PS4_OPTIONS,
		IK_PS4_TOUCH_PRESS,
		IK_Pad_Fake_LeftAxis,
		IK_Pad_Fake_RightAxis,
		IK_Pad_Fake_RelativeLeftAxis,
		IK_Last,
		IK_Count,
		IK_Pad_First,
		IK_Pad_Last
	}

	public enum ELightShadowCastingMode
	{
		LSCM_None,
		LSCM_Normal,
		LSCM_OnlyDynamic,
		LSCM_OnlyStatic,
		LSCM_NormalAndContact,
		LSCM_OnlyContact
	}

	public enum ELightShadowSoftnessMode
	{
		LSSM_ExtraSoft,
		LSSM_Soft,
		LSSM_Default,
		LSSM_Sharp,
		LSSM_ExtraSharp
	}

	public enum ELightType
	{
		LT_Point,
		LT_Spot,
		LT_Area
	}

	public enum ELightUnit
	{
		LU_Lumen,
		LU_Watt,
		LU_Lux,
		LU_Nit,
		LU_EV100
	}

	public enum EMaterialModifier
	{
		EMATMOD_HitProxy,
		EMATMOD_WindData,
		EMATMOD_ParticleParams,
		EMATMOD_RemoteCamera,
		EMATMOD_Mirror,
		EMATMOD_CustomStructBuffer,
		EMATMOD_MotionMatrix,
		EMATMOD_ColorAndTexture,
		EMATMOD_MaterialParams,
		EMATMOD_Eye,
		EMATMOD_Skin,
		EMATMOD_Dismemberment,
		EMATMOD_Garments,
		EMATMOD_ShadowsDebugParams,
		EMATMOD_MultilayeredDebug,
		EMATMOD_ParallaxParams,
		EMATMOD_HighlightsParams,
		EMATMOD_DebugColoring,
		EMATMOD_DrawBufferMask,
		EMATMOD_AutoSpawnData,
		EMATMOD_DestructionRegions,
		EMATMOD_VehicleParams,
		EMATMOD_EffectParams,
		EMATMOD_FloatTracks,
		EMATMOD_AutoHideDistance,
		EMATMOD_Rain,
		EMATMOD_PlanarReflections,
		EMATMOD_MAX
	}

	public enum EMaterialPriority
	{
		EMP_Normal,
		EMP_Front
	}

	public enum EMaterialShaderTarget
	{
		MSH_Invalid,
		MSH_VertexShader,
		MSH_PixelShader,
		MSH_MAX
	}

	public enum EMaterialVertexFactory
	{
		MVF_Terrain,
		MVF_MeshStatic,
		MVF_MeshSkinned,
		MVF_MeshExtSkinned,
		MVF_GarmentMeshSkinned,
		MVF_GarmentMeshExtSkinned,
		MVF_MeshSpeedTree,
		MVF_ParticleBilboard,
		MVF_ParticleParallel,
		MVF_ParticleMotionBlur,
		MVF_ParticleSphereAligned,
		MVF_ParticleVerticalFixed,
		MVF_ParticleTrail,
		MVF_ParticleFacingTrail,
		MVF_ParticleScreen,
		MVF_ParticleBeam,
		MVF_ParticleFacingBeam,
		MVF_Decal,
		MVF_Debug,
		MVF_DrawBuffer,
		MVF_Fullscreen,
		MVF_MeshSkinnedVehicle,
		MVF_MeshStaticVehicle,
		MVF_MeshProcedural,
		MVF_MeshDestructible,
		MVF_MeshDestructibleSkinned,
		MVF_MeshSkinnedLightBlockers,
		MVF_MeshExtSkinnedLightBlockers,
		MVF_GarmentMeshSkinnedLightBlockers,
		MVF_GarmentMeshExtSkinnedLightBlockers,
		MVF_MeshSkinnedSingleBone,
		MVF_MeshProxy,
		MVF_MeshWindowProxy
	}

	public enum EMeasurementSystem
	{
		Metric,
		Imperial
	}

	public enum EMeasurementUnit
	{
		Millimeter,
		Centimeter,
		Meter,
		Kilometer,
		Inch,
		Feet,
		Yard,
		Mile,
		NauticalMile,
		SquareMillimeter,
		SquareCentimeter,
		SquareMeter,
		Hectare,
		SquareKilometer,
		SquareInch,
		SquareFeet,
		SquareYard,
		Acre,
		SquareMile,
		CubicCentimer,
		CubicDecimeter,
		CubicMeter,
		Liter,
		Hectoliter,
		CubicInch,
		CubicFeet,
		FluidOunce,
		Pint,
		Gallon,
		Gram,
		Kilogram,
		Tonne,
		Ounce,
		Pound,
		Stone,
		Celcius,
		Fahrenheit,
		MAX
	}

	public enum EMeshParticleOrientationMode
	{
		MPOM_Normal,
		MPOM_MovementDirection,
		MPOM_NoRotation
	}

	public enum EMeshShadowImportanceBias
	{
		MSIB_EvenLessImportant,
		MSIB_LessImportant,
		MSIB_Default,
		MSIB_MoreImportant,
		MSIB_EvenMoreImportant
	}

	public enum EMeshStreamType
	{
		MST_Position_3F,
		MST_SkinningIndices_4U8,
		MST_SkinningWeights_4F,
		MST_SkinningIndicesExt_4U8,
		MST_SkinningWeightsExt_4F,
		MST_Color_U32,
		MST_TexCoord0_2F,
		MST_TexCoord1_2F,
		MST_Normal_3F,
		MST_Tangent_3F,
		MST_Binormal_3F,
		MST_DestructionIndices_2U16,
		MST_Multilayer_1F,
		MST_Index_U16,
		MST_GarmentFlags_U32,
		MST_MorphOffset_3F,
		MST_VehicleDmgNormalFront_3F,
		MST_VehicleDmgNormalSides_3F,
		MST_VehicleDmgPosFront_3F,
		MST_VehicleDmgPosSides_3F,
		MST_WindBranchData_4F,
		MST_BranchData_7F,
		MST_MorphVertexData_3F,
		MST_FoliageBoneId_I16,
		MST_LightBlockerIntensity_1F
	}

	public enum EMeshVertexType
	{
		MVT_StaticMesh,
		MVT_ProceduralMesh,
		MVT_SkinnedMesh,
		MVT_ExtSkinnedMesh,
		MVT_GarmentSkinnedMesh,
		MVT_ExtGarmentSkinnedMesh,
		MVT_SpeedTreeMesh,
		MVT_StaticMeshVehicle,
		MVT_SkinnedMeshVehicle,
		MVT_Terrain,
		MVT_DestructibleMesh,
		MVT_DestructibleMeshSkinned,
		MVT_SkinnedMeshLightBlocker,
		MVT_ExtSkinnedMeshLightBlocker,
		MVT_GarmentSkinnedMeshLightBlocker,
		MVT_ExtGarmentSkinnedMeshLightBlocker,
		MVT_SkinnedMeshSingleBone,
		MVT_ProxyMesh,
		MVT_ProxyWindowMesh
	}

	public enum ENoiseType
	{
		NT_Random,
		NT_Simplex2D,
		NT_Simplex3D
	}

	public enum EParticleEventSpawnObject
	{
		PESO_Particle,
		PESO_Decal
	}

	public enum EParticleEventType
	{
		PET_Any,
		PET_Death,
		PET_OverLife,
		PET_OverDistance,
		PET_Collision
	}

	public enum ERenderDynamicDecalAtlas
	{
		RDDA_1x1,
		RDDA_2x1,
		RDDA_2x2,
		RDDA_4x2,
		RDDA_4x4,
		RDDA_8x4
	}

	public enum ERenderDynamicDecalProjection
	{
		RDDP_Ortho,
		RDDP_Sphere
	}

	public enum ERenderMaterialType
	{
		RMT_Standard,
		RMT_Subsurface,
		RMT_Cloth,
		RMT_Eye,
		RMT_Hair,
		RMT_Foliage
	}

	public enum ERenderMeshStreams
	{
		RMS_PositionSkinning,
		RMS_TexCoords,
		RMS_TangentFrame,
		RMS_Extended,
		RMS_Custom0,
		RMS_BindAll
	}

	public enum ERenderObjectType
	{
		ROT_Static,
		ROT_Terrain,
		ROT_Road,
		ROT_Skinned,
		ROT_Character,
		ROT_Foliage,
		ROT_Grass,
		ROT_Vehicle,
		ROT_Weapon,
		ROT_Particle,
		ROT_Enemy,
		ROT_CustomCharacter1,
		ROT_CustomCharacter2,
		ROT_CustomCharacter3,
		ROT_MainPlayer,
		ROT_NoAO,
		ROT_NoLighting,
		ROT_NoTXAA
	}

	public enum ERenderingMode
	{
		RM_HitProxies,
		RM_Shaded,
		RM_Shaded_NoAmbient,
		RM_GBufferOnly,
		RM_SafeMode,
		RM_OverlayOnly
	}

	public enum ERenderingPlane
	{
		RPl_Scene,
		RPl_Background,
		RPl_Weapon
	}

	public enum ESSAOQualityLevel
	{
		SSAOQUALITY_VeryLow,
		SSAOQUALITY_Low,
		SSAOQUALITY_Medium,
		SSAOQUALITY_High,
		SSAOQUALITY_VeryHigh
	}

	public enum ESaveFormat
	{
		SF_PNG,
		SF_EXR,
		SF_PNG_AND_EXR
	}

	public enum ESystemNotificationTypes
	{
		DiscOperationIndicator,
		GenericNotModal,
		GenericMenuInfo,
		GenericYesNo,
		Generic,
		ExitGame,
		StartNewGame,
		NoDiscSpace,
		OverwriteSaveFile,
		LoadSaveFileInGame,
		LoadSaveFile,
		DeleteSaveFile,
		CorruptedSaveFile,
		NoPlayerProfile,
		GameSaved,
		SaveFailed,
		UnavailableForGuest,
		EnableTelemetry,
		PointOfNoReturn,
		PointOfNoReturnWithReward,
		PointOfNoReturnLootAdded,
		GenericMenuError,
		ControllerReconnected,
		ControllerDisconnected,
		MAX,
		FirstModalHighPriority
	}

	public enum ETextureAddressing
	{
		TA_Wrap,
		TA_Mirror,
		TA_Clamp,
		TA_MirrorOnce,
		TA_Border
	}

	public enum ETextureAnimationMode
	{
		TAM_Speed,
		TAM_LifeTime
	}

	public enum ETextureComparisonFunction
	{
		TCF_None,
		TCF_Less,
		TCF_Equal,
		TCF_LessEqual,
		TCF_Greater,
		TCF_NotEqual,
		TCF_GreaterEqual,
		TCF_Always
	}

	public enum ETextureCompression
	{
		TCM_None,
		TCM_DXTNoAlpha,
		TCM_DXTAlpha,
		TCM_RGBE,
		TCM_Normalmap,
		TCM_Normals_DEPRECATED,
		TCM_NormalsHigh_DEPRECATED,
		TCM_NormalsGloss_DEPRECATED,
		TCM_TileMap,
		TCM_DXTAlphaLinear,
		TCM_QualityR,
		TCM_QualityRG,
		TCM_QualityColor,
		TCM_HalfHDR_Unsigned,
		TCM_HalfHDR_Signed,
		TCM_Max
	}

	public enum ETextureFilteringMag
	{
		TFMag_Point,
		TFMag_Linear
	}

	public enum ETextureFilteringMin
	{
		TFMin_Point,
		TFMin_Linear,
		TFMin_Anisotropic,
		TFMin_AnisotropicLow
	}

	public enum ETextureFilteringMip
	{
		TFMip_None,
		TFMip_Point,
		TFMip_Linear
	}

	public enum ETextureRawFormat
	{
		TRF_Invalid,
		TRF_TrueColor,
		TRF_DeepColor,
		TRF_Grayscale,
		TRF_HDRFloat,
		TRF_HDRHalf,
		TRF_HDRFloatGrayscale,
		TRF_Grayscale_Font,
		TRF_R8G8,
		TRF_R32UI,
		TRF_AlphaGrayscale
	}

	public enum ETimeOfYearSeason
	{
		ETOYS_Spring,
		ETOYS_Summer,
		ETOYS_Autumn,
		ETOYS_Winter
	}

	public enum ETransitionType
	{
		EET_Linear,
		EET_Sine,
		EET_Cubic,
		EET_Quad,
		EET_Quart,
		EET_Quint,
		EET_Expo,
		EET_Circ,
		EET_Back,
		EET_Bounce,
		EET_Elastic
	}

	public enum EntityNotificationType
	{
		DoNotNotifyEntity,
		SendThisEventToEntity,
		SendPSChangedEventToEntity
	}

	public enum FunctionalTestsResultCode
	{
		Valid,
		MalformedEntityDescr,
		EntityNotFound,
		ComponentNotFound,
		InvalidEntityType,
		InvalidComponentType,
		InvalidNodeRef,
		SlotNotFound,
		InventoryError,
		InvalidInputAction,
		InvalidInputActionCallback,
		EmptyContainer
	}

	public enum GIGIOverrideType
	{
		Default,
		Override_True,
		Override_False
	}

	public enum GameplayTier
	{
		Undefined,
		Tier1_FullGameplay,
		Tier2_StagedGameplay,
		Tier3_LimitedGameplay,
		Tier4_FPPCinematic,
		Tier5_Cinematic
	}

	public enum GpuApieBufferUsageType
	{
		BUT_Default,
		BUT_Immutable,
		BUT_ImmutableInPlace,
		BUT_Readback,
		BUT_Dynamic_Legacy,
		BUT_Transient,
		BUT_Mapped,
		BUT_MAX
	}

	public enum GpuWrapApiBufferGroup
	{
		System,
		MeshResource,
		MeshCustom,
		AutoSpawner,
		Debug,
		DPL,
		Weather,
		ReflectionProbe,
		Skinning,
		Lights,
		Video,
		Particles,
		GIManagerLitProbes,
		GIManagerLookup,
		GIManagerInterpolation,
		GIManagerLitBricks,
		GIManagerLights,
		GIManagerEnvVolume,
		GIProxyBrick,
		GIProxySurfel,
		GIProxyProbes,
		GIProxyFactors,
		GIProxyAcceleration,
		Raytracing,
		RaytracingUpload,
		RaytracingAS,
		Decals,
		Instances,
		Materials,
		Multilayer,
		FrameResources,
		Misc,
		MorphTargets,
		MAX
	}

	public enum GpuWrapApiVertexPackingEStreamType
	{
		ST_Invalid,
		ST_PerVertex,
		ST_PerInstance,
		ST_Max
	}

	public enum GpuWrapApiVertexPackingePackingType
	{
		PT_Invalid,
		PT_Float1,
		PT_Float2,
		PT_Float3,
		PT_Float4,
		PT_Float16_2,
		PT_Float16_4,
		PT_UShort1,
		PT_UShort2,
		PT_UShort4,
		PT_UShort4N,
		PT_Short1,
		PT_Short2,
		PT_Short4,
		PT_Short4N,
		PT_UInt1,
		PT_UInt2,
		PT_UInt3,
		PT_UInt4,
		PT_Int1,
		PT_Int2,
		PT_Int3,
		PT_Int4,
		PT_Color,
		PT_UByte1,
		PT_UByte1F,
		PT_UByte4,
		PT_UByte4N,
		PT_Byte4N,
		PT_Dec4,
		PT_Index16,
		PT_Index32,
		PT_Max
	}

	public enum GpuWrapApiVertexPackingePackingUsage
	{
		PS_Invalid,
		PS_SysPosition,
		PS_Position,
		PS_Normal,
		PS_Tangent,
		PS_Binormal,
		PS_TexCoord,
		PS_Color,
		PS_SkinIndices,
		PS_SkinWeights,
		PS_DestructionIndices,
		PS_MultilayerPaint,
		PS_InstanceTransform,
		PS_InstanceLODParams,
		PS_InstanceSkinningData,
		PS_PatchSize,
		PS_PatchBias,
		PS_ExtraData,
		PS_VehicleDmgNormal,
		PS_VehicleDmgPosition,
		PS_PositionDelta,
		PS_LightBlockerIntensity,
		PS_BoneIndex,
		PS_Padding,
		PS_PatchOffset,
		PS_Max
	}

	public enum GpuWrapApieBufferChunkCategory
	{
		BCC_Staging,
		BCC_Vertex,
		BCC_VertexUAV,
		BCC_Index16Bit,
		BCC_Index32Bit,
		BCC_VertexIndex16Bit,
		BCC_Constant,
		BCC_TypedUAV,
		BCC_Structured,
		BCC_StructuredUAV,
		BCC_StructuredAppendUAV,
		BCC_IndirectUAV,
		BCC_Index16BitUAV,
		BCC_Raw,
		BCC_Invalid
	}

	public enum GpuWrapApieIndexBufferChunkType
	{
		IBCT_IndexUInt,
		IBCT_IndexUShort,
		IBCT_Max
	}

	public enum GpuWrapApieTextureFormat
	{
		TEXFMT_A8_Unorm,
		TEXFMT_R8_Unorm,
		TEXFMT_L8_Unorm,
		TEXFMT_R8G8_Unorm,
		TEXFMT_R8G8B8X8_Unorm,
		TEXFMT_R8G8B8A8_Unorm,
		TEXFMT_R8G8B8A8_Unorm_SRGB,
		TEXFMT_R8G8B8A8_Snorm,
		TEXFMT_R16_Unorm,
		TEXFMT_R16_Uint,
		TEXFMT_R32_Uint,
		TEXFMT_R32G32B32A32_Uint,
		TEXFMT_R32G32_Uint,
		TEXFMT_R16G16B16A16_Unorm,
		TEXFMT_R16G16B16A16_Uint,
		TEXFMT_R16G16_Uint,
		TEXFMT_R10G10B10A2_Unorm,
		TEXFMT_R16G16B16A16_Float,
		TEXFMT_R11G11B10_Float,
		TEXFMT_R16G16_Float,
		TEXFMT_R32G32_Float,
		TEXFMT_R32G32B32A32_Float,
		TEXFMT_R32_Float,
		TEXFMT_R16_Float,
		TEXFMT_D24S8,
		TEXFMT_D32FS8,
		TEXFMT_D32F,
		TEXFMT_D16U,
		TEXFMT_BC1,
		TEXFMT_BC1_SRGB,
		TEXFMT_BC2,
		TEXFMT_BC2_SRGB,
		TEXFMT_BC3,
		TEXFMT_BC3_SRGB,
		TEXFMT_BC4,
		TEXFMT_BC5,
		TEXFMT_BC6H_UNSIGNED,
		TEXFMT_BC6H_SIGNED,
		TEXFMT_BC7,
		TEXFMT_BC7_SRGB,
		TEXFMT_R8_Uint,
		TEXFMT_R16G16_Unorm,
		TEXFMT_R16G16_Sint,
		TEXFMT_R16G16_Snorm,
		TEXFMT_B5G6R5_Unorm
	}

	public enum GpuWrapApieTextureGroup
	{
		TEXG_Generic_Color,
		TEXG_Generic_Grayscale,
		TEXG_Generic_Normal,
		TEXG_Generic_Data,
		TEXG_Generic_UI,
		TEXG_Generic_Font,
		TEXG_Generic_LUT,
		TEXG_Generic_MorphBlend,
		TEXG_Multilayer_Color,
		TEXG_Multilayer_Normal,
		TEXG_Multilayer_Grayscale,
		TEXG_Multilayer_Microblend
	}

	public enum GpuWrapApieTextureType
	{
		TEXTYPE_2D,
		TEXTYPE_CUBE,
		TEXTYPE_ARRAY,
		TEXTYPE_3D
	}

	public enum IMaterialDataProviderDescEParameterType
	{
		PT_None,
		PT_Texture,
		PT_Color,
		PT_Cube,
		PT_Vector,
		PT_Scalar,
		PT_Bool,
		PT_TextureArray,
		PT_StructBuffer,
		PT_Cpu_NameU64,
		PT_SkinProfile,
		PT_MultilayerSetup,
		PT_MultilayerMask,
		PT_HairProfile,
		PT_FoliageProfile,
		PT_TerrainSetup,
		PT_Gradient,
		PT_MAX
	}

	public enum InGameConfigChangeReason
	{
		Invalid,
		Accepted,
		Rejected,
		NeedsConfirmation,
		NeedsRestart
	}

	public enum InGameConfigNotificationType
	{
		RestartRequiredConfirmed,
		ChangesApplied,
		ChangesRejected,
		ChangesLoadLastCheckpointApplied,
		Saved,
		ErrorSaving,
		RequiresRestart,
		Loaded,
		LoadCanceled,
		Refresh
	}

	public enum InGameConfigUserSettingsLoadStatus
	{
		NotLoaded,
		InternalError,
		FileIsMissing,
		FileIsCorrupted,
		Loaded,
		ImportedFromOldVersion
	}

	public enum InGameConfigUserSettingsSaveStatus
	{
		NotSaved,
		InternalError,
		Saved
	}

	public enum InGameConfigVarType
	{
		Bool,
		Int,
		Float,
		Name,
		IntList,
		FloatList,
		StringList,
		NameList
	}

	public enum InGameConfigVarUpdatePolicy
	{
		Disabled,
		Immediately,
		ConfirmationRequired,
		RestartRequired,
		LoadLastCheckpointRequired
	}

	public enum LibTreeEParameterType
	{
		PARAM_Bool,
		PARAM_Int32,
		PARAM_Enum,
		PARAM_Float,
		PARAM_CName,
		PARAM_TreeRef,
		PARAM_TreeRefList,
		PARAM_NodeRef,
		PARAM_Vector
	}

	public enum MorphTargetsDiffTextureSize
	{
		TEXTURE_SIZE_1024x1024,
		TEXTURE_SIZE_512x512,
		TEXTURE_SIZE_256x256
	}

	public enum MorphTargetsFaceRegion
	{
		FACE_REGION_EYES,
		FACE_REGION_NOSE,
		FACE_REGION_MOUTH,
		FACE_REGION_JAW,
		FACE_REGION_EARS,
		FACE_REGION_NONE
	}

	public enum NavGenAgentSize
	{
		Human
	}

	public enum NavGenNavmeshImpact
	{
		Ignored,
		Walkable,
		Blocking,
		Road,
		CrowdWalkable,
		Stairs,
		Drones
	}

	public enum PSODescBlendModeFactor
	{
		FAC_Zero,
		FAC_One,
		FAC_SrcColor,
		FAC_InvSrcColor,
		FAC_SrcAlpha,
		FAC_InvSrcAlpha,
		FAC_DestColor,
		FAC_InvDestColor,
		FAC_DestAlpha,
		FAC_InvDestAlpha,
		FAC_BlendFactor,
		FAC_InvBlendFactor,
		FAC_Src1Color,
		FAC_InvSrc1Color,
		FAC_Src1Alpha,
		FAC_InvSrc1Alpha
	}

	public enum PSODescBlendModeOp
	{
		OP_Add,
		OP_Subtract,
		OP_RevSub,
		OP_Min,
		OP_Max,
		OP_Or,
		OP_And,
		OP_Xor,
		OP_nOr,
		OP_nAnd
	}

	public enum PSODescBlendModeWriteMask
	{
		MASK_None,
		MASK_R,
		MASK_G,
		MASK_B,
		MASK_A,
		MASK_RG,
		MASK_RB,
		MASK_RA,
		MASK_GB,
		MASK_GA,
		MASK_BA,
		MASK_RGB,
		MASK_RGA,
		MASK_RBA,
		MASK_GBA,
		MASK_RGBA
	}

	public enum PSODescDepthStencilModeComparisonMode
	{
		COMPARISON_Never,
		COMPARISON_Less,
		COMPARISON_Equal,
		COMPARISON_LessEqual,
		COMPARISON_Greater,
		COMPARISON_NotEqual,
		COMPARISON_GreaterEqual,
		COMPARISON_Always
	}

	public enum PSODescDepthStencilModeStencilOpMode
	{
		STENCILOP_Keep,
		STENCILOP_Zero,
		STENCILOP_Replace,
		STENCILOP_IncreaseSaturate,
		STENCILOP_DecreaseSaturate,
		STENCILOP_Invert,
		STENCILOP_Increase,
		STENCILOP_Decrease
	}

	public enum PSODescPrimitiveTopologyType
	{
		Invalid,
		Point,
		Line,
		Triangle,
		Patch
	}

	public enum PSODescRasterizerModeCullMode
	{
		CULL_None,
		CULL_Front,
		CULL_Back
	}

	public enum PSODescRasterizerModeFrontFaceWinding
	{
		FRONTFACE_CCW,
		FRONTFACE_CW
	}

	public enum PSODescRasterizerModeOffsetMode
	{
		OFFSET_None,
		OFFSET_NormalBias,
		OFFSET_ShadowBias,
		OFFSET_DecalBias
	}

	public enum RenderDecalNormalsBlendingMode
	{
		AlphaBlending,
		Reorient
	}

	public enum RenderDecalOrderPriority
	{
		Priority0,
		Priority1,
		Priority2,
		Priority3
	}

	public enum RenderSceneLayer
	{
		Default,
		Cyberspace,
		WorldMap
	}

	public enum SAnimationBufferBitwiseCompression
	{
		ABBC_None,
		ABBC_24b,
		ABBC_16b
	}

	public enum SAnimationBufferBitwiseCompressionPreset
	{
		ABBCP_Custom,
		ABBCP_VeryHighQuality,
		ABBCP_HighQuality,
		ABBCP_NormalQuality,
		ABBCP_LowQuality,
		ABBCP_VeryLowQuality,
		ABBCP_Raw
	}

	public enum SAnimationBufferDataCompressionMethod
	{
		ABDCM_Invalid,
		ABDCM_Plain,
		ABDCM_Quaternion,
		ABDCM_QuaternionXYZSignedW,
		ABDCM_QuaternionXYZSignedWLastBit,
		ABDCM_Quaternion48b,
		ABDCM_Quaternion40b,
		ABDCM_Quaternion32b,
		ABDCM_Quaternion64bW,
		ABDCM_Quaternion48bW,
		ABDCM_Quaternion40bW
	}

	public enum SAnimationBufferOrientationCompressionMethod
	{
		ABOCM_PackIn64bitsW,
		ABOCM_PackIn48bitsW,
		ABOCM_PackIn40bitsW,
		ABOCM_AsFloat_XYZW,
		ABOCM_AsFloat_XYZSignedW,
		ABOCM_AsFloat_XYZSignedWInLastBit,
		ABOCM_PackIn48bits,
		ABOCM_PackIn40bits,
		ABOCM_PackIn32bits
	}

	public enum SAnimationBufferStreamingOption
	{
		ABSO_NonStreamable,
		ABSO_PartiallyStreamable,
		ABSO_FullyStreamable
	}

	public enum Sample_Enum_4_1
	{
		Sample_Enum_Option_4_1_0,
		Sample_Enum_Option_4_1_1,
		Sample_Enum_Option_4_1_2,
		MyCustomEnumOptionName413
	}

	public enum Sample_Enum_4_4
	{
		Sample_Enum_Option_4_4_0,
		Sample_Enum_Option_4_4_1,
		Sample_Enum_Option_4_4_2
	}

	public enum Sample_Enum_4_5
	{
		Sample_Enum_Option_4_5_0,
		Sample_Enum_Option_4_5_1,
		Sample_Enum_Option_4_5_2
	}

	public enum Sample_Enum_4_6
	{
		Sample_Enum_Option_4_6_0,
		Sample_Enum_Option_4_6_1_with_a_new_name
	}

	public enum Sample_Enum_6_8
	{
	}

	public enum Sample_Namespace_4_2Sample_Enum_4_2
	{
		Sample_Enum_Option_4_2_0,
		Sample_Enum_Option_4_2_1,
		Sample_Enum_Option_4_2_2,
		MyCustomEnumOptionName423
	}

	public enum Sample_Namespace_4_3_0Sample_Namespace_4_3_1Sample_Enum_4_3
	{
		Sample_Enum_Option_4_3_0,
		Sample_Enum_Option_4_3_1,
		Sample_Enum_Option_4_3_2,
		MyCustomEnumOptionName433
	}

	public enum Sample_Replicated_Enum
	{
		One,
		Two,
		Three
	}

	public enum StaticShaderInputLayout
	{
		DebugVertexBase,
		DebugVertexUV,
		DebugVertexUV_Fullscreen,
		NoBuffers_Fullscreen,
		NoBuffers_PointList
	}

	public enum ThrowType
	{
		Charge
	}

	public enum Tier2WalkType
	{
		Undefined,
		Slow,
		Normal,
		Fast
	}

	public enum TrafficGenDynamicImpact
	{
		Ignored,
		Blocking
	}

	public enum TrafficGenMeshImpact
	{
		UseNavigation,
		ForceIgnored,
		ForceBlocking
	}

	public enum UIGameContext
	{
		Default,
		QuickHack,
		Scanning,
		DeviceZoom,
		BraindanceEditor,
		BraindancePlayback,
		VehicleMounted,
		ModalPopup,
		RadialWheel,
		VehicleRace
	}

	public enum UpdateBucketEnum
	{
		Vehicle,
		Character,
		AttachedObject
	}

	public enum animAimState
	{
		Unaimed,
		Aimed
	}

	public enum animAnimEventGenderAlt
	{
		None,
		Female,
		Male
	}

	public enum animAnimNode_SetDrivenKey_InternalsEChannelType
	{
		FloatTrack,
		TransX,
		TransY,
		TransZ,
		RotEulZ_Pitch,
		RotEulX_Roll,
		RotEulY_Yaw,
		ScaleX,
		ScaleY,
		ScaleZ,
		RotQuatX,
		RotQuatY,
		RotQuatZ,
		RotQuatW
	}

	public enum animAnimStateInterpolationType
	{
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut
	}

	public enum animAnimationType
	{
		Normal,
		AdditiveFromRefPose,
		AdditiveFromFirstFrame,
		Additive,
		AdditiveWithoutFirstFrame
	}

	public enum animAxis
	{
		X,
		Y,
		Z,
		NegativeX,
		NegativeY,
		NegativeZ
	}

	public enum animClampType
	{
		None,
		Clamp,
		WrappedClamp
	}

	public enum animCompareFunc
	{
		Equal,
		NotEqual,
		Less,
		LessEqual,
		Greater,
		GreaterEqual
	}

	public enum animConstraintWeightMode
	{
		Static,
		FloatTrack
	}

	public enum animCoverAction
	{
		NoAction,
		LeanLeft,
		LeanRight,
		StepOutLeft,
		StepOutRight,
		LeanOver,
		StepUp,
		EnterCover,
		SlideTo,
		Vault,
		LeaveCover,
		BlindfireLeft,
		BlindfireRight,
		BlindfireOver,
		OverheadStepOutLeft,
		OverheadStepOutRight,
		OverheadStepUp
	}

	public enum animCoverBehavior
	{
		Idle,
		PreAction,
		DoAction,
		PostAction
	}

	public enum animCoverStance
	{
		None,
		LowLeft,
		HighLeft,
		LowRight,
		HighRight
	}

	public enum animCoverState
	{
		LowCover,
		HighCover
	}

	public enum animDyngConstraintLinkType
	{
		KeepFixedDistance,
		KeepVariableDistance,
		Greater,
		Closer
	}

	public enum animDyngParticleProjectionType
	{
		Disabled,
		ShortestPath,
		Directed
	}

	public enum animEAnimGraphAdditiveType
	{
		AGAT_Local,
		AGAT_Ref
	}

	public enum animEAnimGraphCompareFunc
	{
		AGCF_Equal,
		AGCF_NotEqual,
		AGCF_Less,
		AGCF_LessEqual,
		AGCF_Greater,
		AGCF_GreaterEqual
	}

	public enum animEAnimGraphLogicOp
	{
		AGLO_Or,
		AGLO_And
	}

	public enum animEAnimGraphMathInterpolation
	{
		AGMI_LINEAR,
		AGMI_SIN,
		AGMI_BEZIER
	}

	public enum animEAnimGraphMathOp
	{
		AGMO_Add,
		AGMO_Subtract,
		AGMO_Multiply,
		AGMO_Divide,
		AGMO_SafeDivide,
		AGMO_ATan,
		AGMO_AngleDiff,
		AGMO_Length,
		AGMO_Abs
	}

	public enum animEBlendFromPoseMode
	{
		BFPM_AlwaysOnActivation,
		BFPM_RequestedByTag
	}

	public enum animEBlendTracksMode
	{
		AGBT_BasePose,
		AGBT_Interpolate,
		AGBT_Add
	}

	public enum animEBlendTypeLBC
	{
		Linear,
		Smoothstep,
		CustomCurve
	}

	public enum animEDirectionToEuler
	{
		Pitch,
		Yaw,
		Roll
	}

	public enum animEFootPhase
	{
		RightUp,
		RightForward,
		LeftUp,
		LeftForward,
		NotConsidered
	}

	public enum animEInterpolationType
	{
		Lerp,
		Slerp
	}

	public enum animEMotionExtractionCompressionType
	{
		EMECT_LINEAR,
		EMECT_SPLINE_LOW,
		EMECT_SPLINE_MID,
		EMECT_SPLINE_HIGH,
		EMECT_UNCOMPRESSED,
		EMECT_UNCOMPRESSED_ALL_ANGLES,
		EMECT_UNCOMPRESSED_2D,
		EMECT_UNCOMPRESSED_3D_FALLBACKING,
		EMECT_UNCOMPRESSED_ALL_ANGLES_FALLBACKING
	}

	public enum animEResetTypeNode
	{
		RT_Reference,
		RT_Indentity
	}

	public enum animESpace
	{
		Local,
		Model,
		World
	}

	public enum animESpaceMW
	{
		Model,
		World
	}

	public enum animETransformAxis
	{
		X_Axis,
		Y_Axis,
		Z_Axis
	}

	public enum animEVectorWsToMsType
	{
		Position,
		Direction
	}

	public enum animEventFilterType
	{
		Default,
		AlwaysCollect,
		Solo,
		Mute
	}

	public enum animEventSide
	{
		Left,
		Right
	}

	public enum animFacialEmotionTransitionType
	{
		Natural,
		Fast,
		Blend,
		Instant,
		Custom
	}

	public enum animFloatTrackOperationType
	{
		Override,
		Multiply,
		Add,
		Subtract,
		SubtractSwapped,
		WeightComplement
	}

	public enum animHitReactionType
	{
		None,
		Twitch,
		Impact,
		Stagger,
		Pain,
		Knockdown,
		Ragdoll,
		Death,
		Block,
		GuardBreak,
		Parry,
		Bump
	}

	public enum animLeg
	{
		Left,
		Right
	}

	public enum animLocoStateType
	{
		LS_Pre,
		LS_Loop
	}

	public enum animLocomotionDecision
	{
		LD_None,
		LD_Stop,
		LD_MoveTo,
		LD_Move
	}

	public enum animLocomotion_AnimType
	{
		None,
		idle_stand,
		idle_to_idle_0,
		idle_to_idle_090,
		idle_to_idle_270,
		idle_to_idle_180_l,
		idle_to_idle_180_r,
		walk_0,
		walk_left,
		walk_right,
		jog_0,
		jog_left,
		jog_right,
		sprint_0,
		sprint_left,
		sprint_right,
		idle_to_walk_0,
		idle_to_jog_0,
		idle_to_sprint_0,
		walk_to_idle_0,
		jog_to_idle_0,
		sprint_to_idle_0,
		walk_to_idle_0_l_hard,
		walk_to_idle_0_r_hard,
		jog_to_idle_0_l_hard,
		jog_to_idle_0_r_hard,
		sprint_to_idle_0_l_hard,
		sprint_to_idle_0_r_hard,
		walk_to_jog_0,
		walk_to_sprint_0,
		jog_to_walk_0,
		jog_to_sprint_0,
		sprint_to_walk_0,
		sprint_to_jog_0,
		idle_turn_to_walk_090,
		idle_turn_to_walk_180_l,
		idle_turn_to_walk_180_r,
		idle_turn_to_walk_270,
		idle_turn_to_jog_090,
		idle_turn_to_jog_180_l,
		idle_turn_to_jog_180_r,
		idle_turn_to_jog_270,
		idle_turn_to_sprint_090,
		idle_turn_to_sprint_180_l,
		idle_turn_to_sprint_180_r,
		idle_turn_to_sprint_270,
		walk_180,
		jog_180,
		walk_0_to_walk_180_l,
		walk_0_to_walk_180_r,
		walk_180_to_walk_0_l,
		walk_180_to_walk_0_r,
		idle_to_walk_180,
		idle_to_jog_180,
		walk_to_idle_180,
		jog_to_idle_180,
		jog_0_to_jog_180_l,
		jog_0_to_jog_180_r,
		jog_180_to_jog_0_l,
		jog_180_to_jog_0_r,
		jog_to_sprint_180,
		walk_to_jog_180,
		jog_to_walk_180,
		idle_to_walk_090,
		idle_to_walk_270,
		walk_090,
		walk_270,
		walk_to_idle_090,
		walk_to_idle_270,
		walk_0_to_walk_090,
		walk_0_to_walk_270,
		walk_180_to_walk_090,
		walk_180_to_walk_270,
		walk_090_to_walk_0,
		walk_270_to_walk_0,
		walk_090_to_walk_180,
		walk_270_to_walk_180,
		walk_090_to_walk_270_l,
		walk_090_to_walk_270_r,
		walk_270_to_walk_090_l,
		walk_270_to_walk_090_r,
		walk_0_down_stairs,
		walk_0_up_stairs,
		walk_0_down_slope,
		walk_0_up_slope,
		jog_0_down_stairs,
		jog_0_up_stairs,
		jog_0_down_slope,
		jog_0_up_slope,
		sprint_0_down_stairs,
		sprint_0_up_stairs,
		sprint_0_down_slope,
		sprint_0_up_slope,
		walk_090_up_stairs,
		walk_090_down_stairs,
		walk_270_up_stairs,
		walk_270_down_stairs,
		walk_180_up_stairs,
		walk_180_down_stairs,
		idle_step_single_0,
		idle_step_single_090,
		idle_step_single_180,
		idle_step_single_270
	}

	public enum animLocomotion_Style
	{
		LS_Idle,
		LS_Rotation,
		LS_Walk,
		LS_Jog,
		LS_Sprint,
		LS_Any
	}

	public enum animLookAtChestMode
	{
		Default,
		NoHips,
		Horizontal,
		HorizontalNoHips,
		ENUM_SIZE
	}

	public enum animLookAtEyesMode
	{
		Default,
		Horizontal,
		ENUM_SIZE
	}

	public enum animLookAtHeadMode
	{
		Default,
		Horizontal,
		ENUM_SIZE
	}

	public enum animLookAtLeftHandedMode
	{
		Default,
		Horizontal,
		ENUM_SIZE
	}

	public enum animLookAtLimitDegreesType
	{
		Narrow,
		Normal,
		Wide,
		None
	}

	public enum animLookAtLimitDistanceType
	{
		Short,
		Normal,
		Long,
		None
	}

	public enum animLookAtRightHandedMode
	{
		Default,
		Horizontal,
		ENUM_SIZE
	}

	public enum animLookAtStatus
	{
		Active,
		LimitReached,
		TransitionInProgress
	}

	public enum animLookAtStyle
	{
		VerySlow,
		Slow,
		Normal,
		Fast,
		VeryFast
	}

	public enum animLookAtTwoHandedMode
	{
		Default,
		Horizontal,
		ENUM_SIZE
	}

	public enum animMotionTableAction
	{
		MTA_None,
		MTA_Start,
		MTA_Stop,
		MTA_Move,
		MTA_TurnInPlace,
		MTA_TransitionToBackward,
		MTA_BackwardMove,
		MTA_TransitionFromBackward,
		MTA_StrafeLeft,
		MTA_StrafeRight,
		MTA_ForwardToStrafeLeft,
		MTA_ForwardToStrafeRight,
		MTA_StrafeLeftToForward,
		MTA_StrafeRightToForward,
		MTA_BackwardToStrafeLeft,
		MTA_BackwardToStrafeRight,
		MTA_StrafeLeftToBackward,
		MTA_StrafeRightToBackward,
		MTA_BackwardStart,
		MTA_BackwardStop,
		MTA_StrafeLeftStart,
		MTA_StrafeLeftStop,
		MTA_StrafeRightStart,
		MTA_StrafeRightStop,
		MTA_ForwardToWalk,
		MTA_ForwardToJog,
		MTA_ForwardToSprint,
		MTA_HardStopLeftLeg,
		MTA_HardStopRightLeg,
		MTA_RepositionForward,
		MTA_RepositionLeft,
		MTA_RepositionRight,
		MTA_RepositionBackward,
		MTA_Custom,
		MTA_CrowdMove,
		MTA_CrowdMoveSlopes,
		MTA_CrowdMoveStairs,
		MTA_StrafeLeftToStrafeRight,
		MTA_StrafeRightToStrafeLeft,
		MTA_CrowdRelaxedStop,
		MTA_CrowdHardStop,
		MTA_CrowdSprintStop,
		MTA_CrowdFleeStopFront,
		MTA_CrowdFleeStopBack,
		MTA_CrowdRelaxedStart,
		MTA_CrowdFleeStartIdle,
		MTA_CrowdFleeStartMotion,
		MTA_CrowdDirectionalStartFast
	}

	public enum animMotionTableType
	{
		MTT_None,
		MTT_Walk,
		MTT_Jog,
		MTT_Sprint,
		MTT_Custom
	}

	public enum animMotionTag
	{
		MT_Invalid,
		Walk,
		Jog,
		Sprint
	}

	public enum animNodeProfileTimerMode
	{
		Begin,
		End
	}

	public enum animParentStaticSwitchBranch
	{
		None,
		TrueBranch,
		FalseBranch
	}

	public enum animPendulumConstraintType
	{
		Cone,
		HingePlane,
		HalfCone
	}

	public enum animPendulumProjectionType
	{
		Disabled,
		ShortestPathRotational,
		DirectedRotational
	}

	public enum animPositionProjectionType
	{
		Disabled,
		ShortestPath,
		Directional
	}

	public enum animQuaternionInterpolationType
	{
		Linear,
		Spherical
	}

	public enum animSetBoneTransformEntry_SetMethod
	{
		NoSnapping,
		WholeTransform,
		TranslationOnly,
		RotationOnly
	}

	public enum animSpringProjectionType
	{
		Disabled,
		ShortestPath
	}

	public enum animStackTransformsExtender_SnapToBoneMethod
	{
		NoSnapping,
		WholeTransform,
		TranslationOnly,
		RotationOnly
	}

	public enum animStanceState
	{
		Stand,
		Crouch,
		Kneel,
		Cover,
		Swim,
		Crawl
	}

	public enum animStateTag
	{
		ST_Invalid,
		Idle,
		Cover
	}

	public enum animTransformChannel
	{
		PosX,
		PosY,
		PosZ,
		RotX,
		RotY,
		RotZ,
		ScaleX,
		ScaleY,
		ScaleZ
	}

	public enum animVectorCoordinateType
	{
		X,
		Y,
		Z,
		W
	}

	public enum animcompressionBufferTypePreset
	{
		Spline,
		SIMD,
		TestRaw
	}

	public enum animcompressionFrameratePreset
	{
		USE_30_HZ,
		USE_15_HZ,
		USE_10_HZ
	}

	public enum animcompressionQualityPreset
	{
		CINEMATIC_HIGH,
		HIGH,
		MID,
		LOW
	}

	public enum audioAdvertIndoorFilter
	{
		Always,
		OnlyIndoor,
		OnlyOutdoor
	}

	public enum audioAmbientGroupingVariant
	{
		AllEntities,
		IndoorEntities,
		OutdoorEntities,
		AllEntitiesAllDirections,
		IndoorAllDirections,
		OutdoorAllDirections
	}

	public enum audioAudioEventFlags
	{
		NoEventFlags,
		SloMoOnly,
		Music,
		Unique,
		Metadata
	}

	public enum audioAudioVehicleCurve
	{
		ThrottleInput,
		RPM,
		Gear
	}

	public enum audioBreathingTransitionComparator
	{
		Less,
		Equal,
		Greater
	}

	public enum audioBreathingTransitionType
	{
		PlayerSpeed,
		Event,
		AllEventTags,
		AnyEventTag
	}

	public enum audioClassificationMethod
	{
		HasAnyTag,
		HasAllTags,
		NameEquals,
		EventNameEquals,
		HasAllEventTags
	}

	public enum audioConversationSavingStrategy
	{
		Default,
		Save,
		DontSave
	}

	public enum audioDynamicReverbType
	{
		Dynamic,
		StaticSmall,
		EnvironmentSmallStaticMedium,
		DynamicSource
	}

	public enum audioESoundCurveType
	{
		Log3,
		Sine,
		InversedSCurve,
		Linear,
		SCurve,
		Exp1,
		ReciprocalOfSineCurve,
		Exp3
	}

	public enum audioEchoPositionType
	{
		DynamicEnvironment,
		Simple
	}

	public enum audioEnemyState
	{
		InCombat,
		Alerted,
		Afraid,
		Alive,
		Dead
	}


	public enum audioEventActionType
	{
		Play,
		PlayAnimation,
		SetParameter,
		StopSound,
		SetSwitch,
		StopTagged,
		PlayExternal,
		Tag,
		Untag,
		SetAppearanceName,
		SetEntityName,
		AddContainerStreamingPrefetch,
		RemoveContainerStreamingPrefetch
	}

	public enum audioFoleyActionType
	{
		FastHeavy,
		FastMedium,
		FastLight,
		NormalHeavy,
		NormalMedium,
		NormalLight,
		SlowHeavy,
		SlowMedium,
		SlowLight,
		Walk,
		Run
	}

	public enum audioFoleyItemPriority
	{
		P0,
		P1,
		P2,
		P3,
		P4,
		P5,
		P6
	}

	public enum audioFoleyItemType
	{
		Jacket,
		Top,
		Bottom,
		Jewelry
	}

	public enum audioGameplayTier
	{
		Undefined,
		Tier1_FullGameplay,
		Tier2_StagedGameplay,
		Tier3_LimitedGameplay,
		Tier4_FPPCinematic,
		Tier5_Cinematic
	}

	public enum audioMaterialHardnessOverride
	{
		None,
		SetAsSoft,
		SetAsSolid,
		SetAsHard
	}

	public enum audioMeleeHitPerMaterialType
	{
		Light,
		Light_Hard,
		Light_Soft,
		Light_Solid,
		Light_Flesh,
		Light_Robot,
		Normal,
		Normal_Hard,
		Normal_Soft,
		Normal_Solid,
		Normal_Flesh,
		Normal_Robot,
		Heavy,
		Heavy_Hard,
		Heavy_Soft,
		Heavy_Solid,
		Heavy_Flesh,
		Heavy_Robot,
		Slash,
		Slash_Hard,
		Slash_Soft,
		Slash_Solid,
		Slash_Flesh,
		Slash_Robot,
		Cut,
		Cut_Hard,
		Cut_Soft,
		Cut_Solid,
		Cut_Flesh,
		Cut_Robot,
		Stab,
		Stab_Hard,
		Stab_Soft,
		Stab_Solid,
		Stab_Flesh,
		Stab_Robot,
		Finisher,
		Finisher_Hard,
		Finisher_Soft,
		Finisher_Solid,
		Finisher_Flesh,
		Finisher_Robot,
		Weak,
		Weak_Hard,
		Weak_Soft,
		Weak_Solid,
		Weak_Flesh,
		Weak_Robot
	}

	public enum audioMeleeHitType
	{
		Light,
		Normal,
		Heavy,
		Slash,
		Cut,
		Stab,
		Finisher,
		Weak
	}

	public enum audioMeleeMaterialType
	{
		Hard,
		Soft,
		Solid,
		Flesh,
		Robot
	}

	public enum audioMixParamsAction
	{
		Mull,
		MullPercent,
		MullComplemtement,
		MullComplemtementPercent,
		Add
	}

	public enum audioMixingActionType
	{
		VoContext,
		EmitterTag,
		SoundTag,
		ActorName,
		DisableCombatVo,
		GlobalParameter
	}

	public enum audioMusicSyncType
	{
		Beat,
		Bar,
		Grid,
		User,
		EntryCue,
		ExitCue,
		Transition
	}

	public enum audioNumberComparer
	{
		Equal,
		NotEqual,
		Greater,
		GreaterOrEqual,
		Lower,
		LowerOrEqual
	}

	public enum audioNumberOperation
	{
		SetEqual,
		Add,
		Subtract,
		MultiplyBy,
		DivideBy
	}

	public enum audioObstructionTestPattern
	{
		Direct,
		Cone
	}

	public enum audioObstructionTestType
	{
		SingleShot,
		Continuous
	}

	public enum audioRadioSoundType
	{
		Song,
		AnnouncementScene
	}

	public enum audioRadioSpeakerType
	{
		Stanley,
		MaximumMike,
		PoliceDispatch
	}

	public enum audioReflectionVariant
	{
		WorldSpaceFixedDrections,
		LocalSpaceFixedDirections,
		FindingMaximumFaceAlignemnt,
		LocalSpaceSideDirections,
		FindingMaximumFaceAligment2Sides
	}

	public enum audioVoBarkType
	{
		None,
		Curse,
		Morale,
		Combat_Aggro,
		Combat_Despair,
		Stealth_Curious
	}

	public enum audioVoCpoCharacter
	{
		None,
		Solo,
		Assassin,
		Techie,
		Netrunner
	}

	public enum audioVoGruntInterruptMode
	{
		DontInterrupt,
		PlayOnlyOnInterrupt,
		CanInterrupt
	}

	public enum audioVoGruntType
	{
		None,
		PainShort,
		PainLong,
		AgroShort,
		AgroLong,
		Effort,
		LongFall,
		Death,
		SilentDeath,
		Grapple,
		GrappleMovement,
		EnvironmentalKnockdown,
		Bump,
		Curious,
		Fear,
		Jump,
		EffortLong,
		DeathShort,
		Greet,
		LaughHard,
		LaughSoft,
		Phone,
		BraindanceExcited,
		BraindanceFearful,
		BraindanceNeutral,
		BraindanceSexual
	}

	public enum audioWeaponBulletType
	{
		standard,
		sniper,
		shot,
		rail,
		automatic,
		smart,
		smart_sniper,
		hmg
	}

	public enum audioWeaponShellCasingDirection
	{
		rightFront,
		rightBack,
		leftFront,
		leftBack
	}

	public enum audioWeaponShellCasingMode
	{
		none,
		onShoot,
		onReload
	}

	public enum audioWeaponShellCasingType
	{
		standard,
		large,
		cartridge
	}

	public enum audioWeaponTailEnvironment
	{
		InteriorDefault,
		InteriorWide,
		ExteriorWide,
		ExteriorUrbanNarrow,
		ExteriorUrbanStreet,
		ExteriorUrbanStreetWide,
		ExteriorUrbanOpen,
		ExteriorUrbanEnclosed,
		ExteriorBadlandsOpen,
		ExteriorBadlandsCanyon
	}

	public enum audiobreathingEventTag
	{
		Walk,
		Jog,
		Run,
		Sneak,
		Cloth,
		FootStepRegular,
		FootStepSprint,
		LandingRegular,
		LandingHard,
		LandingVeryHard,
		Climb,
		Jump,
		Player,
		Stop,
		Drop_Body,
		Pick_Up_Body,
		Standing_Event
	}

	public enum audiobreathingLoopBehavior
	{
		TimedBreathing,
		BreathEvery2ndStep,
		BreathEveryStep,
		HoldingBreath
	}

	public enum audiottsvoicesFemale
	{
		Olivia,
		Emily,
		Jessica,
		Sophie,
		Elizabeth,
		Carolina,
		Sarah
	}

	public enum audiottsvoicesMale
	{
		Andrew,
		Oliver,
		Jack,
		Harry,
		Simon,
		Charlie,
		Thomas
	}

	public enum audiottsvoicesPolishFemale
	{
		Iwona,
		Paulina
	}

	public enum audiottsvoicesPolishMale
	{
		Mateusz,
		Pawel
	}



	public enum communityESquadType
	{
		Global,
		Community,
		Security,
		Unknown
	}

	public enum curveEInterpolationType
	{
		EIT_Constant,
		EIT_Linear,
		EIT_BezierQuadratic,
		EIT_BezierCubic,
		EIT_Hermite
	}

	public enum curveESegmentsLinkType
	{
		ESLT_Normal,
		ESLT_Smooth,
		ESLT_SmoothSymmetric
	}

	public enum entAnimParamSlotFunction
	{
		RenderingPlane,
		Visibility
	}

	public enum entAppearanceStatus
	{
		None,
		Proxy,
		Appearance
	}

	public enum entAttachmentTarget
	{
		Transform,
		TargetPosition
	}

	public enum entAudioDismembermentPart
	{
		Head,
		Leg,
		Arm
	}

	public enum entColliderComponentSimulationType
	{
		Kinematic,
		Dynamic
	}

	public enum entDebug_ShapeType
	{
		Sphere,
		Box,
		Capsule,
		Cylinder
	}

	public enum entEBindingDirection
	{
		BindToSource,
		BindToDestination
	}

	public enum entEntitySpawnPriority
	{
		Background,
		Normal,
		Immediate,
		Paramount,
		Critical
	}

	public enum entEntityUserComponentResolutionMode
	{
		Select,
		Suppress
	}

	public enum entMeshComponentLODMode
	{
		AlwaysVisible,
		Appearance,
		AppearanceProxy
	}

	public enum entRenderToTextureMode
	{
		Shaded,
		GBufferOnly
	}

	public enum entRepellingShape
	{
		Sphere,
		Capsule
	}

	public enum entRepellingType
	{
		Debris,
		BigObjects,
		WindImpulse
	}

	public enum entTemplateComponentResolveMode
	{
		AutoSelect,
		Select,
		Suppress
	}

	public enum entVertexAnimationMapperSourceType
	{
		FloatTrack,
		TranslationX,
		TranslationY,
		TranslationZ,
		RotationQuatX,
		RotationQuatY,
		RotationQuatZ,
		RotationQuatW
	}

	public enum entVisibilityParamSource
	{
		PhantomEntitySystem
	}

	public enum entVisualControllerComponentForcedLodDistance
	{
		Default,
		Background,
		Regular,
		Cinematic,
		Vehicle,
		CinematicVehicle
	}

	public enum entdismembermentResourceSetE
	{
		NONE,
		BARE,
		BARE1,
		BARE2,
		BARE3,
		GARMENT,
		GARMENT1,
		GARMENT2,
		GARMENT3,
		CYBER,
		CYBER1,
		CYBER2,
		CYBER3,
		MIXED,
		MIXED1,
		MIXED2,
		MIXED3
	}

	public enum entdismembermentSimulationTypeE
	{
		NONE,
		DANGLE
	}

	public enum entragdollActivationRequestType
	{
		Default,
		Animated,
		Forced
	}

	public enum envUtilsNeighborMode
	{
		eCLOSEST,
		eONLY_GLOBAL,
		eONLY_SELF,
		eFILL_SURROUNDING
	}

	public enum envUtilsReflectionProbeAmbientContributionMode
	{
		eNO_AMBIENT_CONTRIBUTION,
		eALLOW_AMBIENT_CONTRIBUTION,
		eOVERRIDE_GI_AMBIENT
	}

	public enum gameAIDirectorTensionEventType
	{
		Time,
		Progress,
		DealingDamage,
		TakingDamage,
		Kill
	}

	public enum gameAggregationType
	{
		AND,
		OR
	}

	public enum gameAppearanceSource
	{
		EntityResource,
		PopulationSpawner,
		CommunityEntry,
		CommunityAppearancePicker,
		TweakDBRecord,
		VisualTag,
		Invalid
	}

	public enum gameBinkVideoAction
	{
		Undefined,
		Start,
		Stop
	}

	public enum gameBoolSignalAction
	{
		None,
		TurnOn,
		TurnOff
	}

	public enum gameCameraCurve
	{
		CentricPitchOfSpeed,
		CentricVerticalOffsetOfSpeed,
		BoomLengthOfSpeed,
		BoomLengthOfAcc,
		BoomPitchOfSpeed,
		BoomPitchOfGlobalVehiclePitch,
		BoomYawOfTurnCoeff,
		BoomYawRotateRateOfSpeed,
		FOVOfSpeed,
		PivotOffsetXOfTurnCoeff,
		PivotOffsetZOfTurnCoeff,
		COUNT
	}

	public enum gameCityAreaType
	{
		Undefined,
		PublicZone,
		SafeZone,
		RestrictedZone,
		DangerousZone
	}

	public enum gameCombinedStatOperation
	{
		Addition,
		Subtraction,
		Multiplication,
		Division,
		Modulo,
		Invert,
		Count,
		Invalid
	}

	public enum gameComparisonType
	{
		EQUAL,
		NOT_EQUAL,
		LESS,
		GREATER,
		LESS_OR_EQUAL,
		GREATER_OR_EQUAL
	}

	public enum gameContactType
	{
		Caller,
		Texter
	}

	public enum gameCoverHeight
	{
		Invalid,
		Low,
		High
	}

	public enum gameCrowdCreationDataMergeMode
	{
		Average,
		Override
	}

	public enum gameCrowdEntryType
	{
		Pedestrian,
		Vehicle,
		AV
	}

	public enum gameDamageCallbackType
	{
		HitTriggered,
		HitReceived,
		PipelineProcessed,
		COUNT,
		INVALID
	}

	public enum gameDamageListenerPipelineType
	{
		None,
		Damage,
		ProjectedDamage,
		All
	}

	public enum gameDamagePipelineStage
	{
		PreProcess,
		Process,
		PostProcess,
		COUNT,
		INVALID
	}

	public enum gameDebugViewETextAlignment
	{
		Left,
		Center,
		Right
	}

	public enum gameDelayContext
	{
		Standard_TD,
		Standard_ND,
		Quest_TD,
		SpawnManager_ND
	}

	public enum gameDifficulty
	{
		Easy,
		Hard,
		VeryHard,
		Story
	}

	public enum gameDismBodyPart
	{
		LEFT_LEG,
		RIGHT_LEG,
		LEFT_ARM,
		RIGHT_ARM,
		HEAD,
		BODY
	}

	public enum gameDismWoundType
	{
		CLEAN,
		COARSE,
		HOLE
	}

	public enum gameEActionFlags
	{
		NONE,
		USE_ANIMATION,
		USE_MOVEMENT
	}

	public enum gameEActionStatus
	{
		STATUS_INVALID,
		STATUS_BOUND,
		STATUS_READY,
		STATUS_PROGRESS,
		STATUS_COMPLETE,
		STATUS_FAILURE
	}

	public enum gameEAreaShape
	{
		NONE,
		SPHERE,
		CUBE,
		COUNT
	}

	public enum gameEAreaType
	{
		NONE,
		LOCATION,
		AFFILIATION,
		COUNT
	}

	public enum gameECharacterStance
	{
		Stance_Stand,
		Stance_Crouch,
		Stance_Kneel,
		Stance_Cover,
		Stance_Standing_Cover,
		Stance_Crouching_Cover
	}

	public enum gameEContinuousMode
	{
		None,
		Start,
		Stop
	}

	public enum gameEEquipmentManagerState
	{
		InfiniteAmmo
	}

	public enum gameEHotkey
	{
		INVALID,
		DPAD_UP,
		DPAD_DOWN,
		DPAD_RIGHT,
		RB
	}

	public enum gameEInventoryFlags
	{
		MustSave
	}

	public enum gameELootGenerationType
	{
		DropChance,
		NumberBased,
		Weights,
		Count
	}

	public enum gameEMaterialZone
	{
		Zero,
		One,
		Two,
		Three
	}

	public enum gameEPrerequisiteType
	{
		None,
		NestedPrereq,
		StatValue,
		StatPoolValue,
		HealthAbsolute,
		HealthPercent,
		ItemInInventory,
		ItemEquipped,
		ItemCount,
		QuestAchieved,
		WasScanned,
		Attitude,
		Count
	}

	public enum gameESlotState
	{
		Taken,
		Empty,
		Available
	}

	public enum gameEStatFlags
	{
		Bool,
		EquipOnPlayer,
		EquipOnNPC,
		ExcludeRootCombination
	}

	public enum gameEStatProviderDataSource
	{
		gameItemData,
		InventoryItemData,
		InnerItemData,
		Invalid
	}

	public enum gameEffectAction_KillFXAction
	{
		Stop,
		BreakLoop
	}

	public enum gameEffectExecutor_AnimFeatureApplyTo
	{
		Target,
		Instigator
	}

	public enum gameEffectHitDataType
	{
		Entity,
		Node,
		Static
	}

	public enum gameEffectObjectFilter_AxisRangeAxis
	{
		X,
		Y,
		Z
	}

	public enum gameEffectObjectFilter_HitTypeAction
	{
		Accept,
		Reject
	}

	public enum gameEffectTriggerPositioningType
	{
		PlayerRoot,
		CameraRoot,
		AtSpawn,
		XYCameraZPlayer,
		XYPlayerZCamera,
		XYCameraZTerrain,
		XYPlayerZTerrain
	}

	public enum gameEffectTriggerRotationType
	{
		None,
		AtSpawn,
		Continuous
	}

	public enum gameEnemyStealthAwarenessState
	{
		Relaxed,
		Aware,
		Alerted,
		Combat
	}

	public enum gameEntityReferenceType
	{
		EntityRef,
		Tag,
		SlotID,
		SceneActorContextName
	}

	public enum gameEntitySpawnerEventType
	{
		Spawn,
		Despawn,
		Death
	}

	public enum gameEquipAnimationType
	{
		Default,
		Instant,
		FirstEquip
	}

	public enum gameEquipmentSetType
	{
		Offensive,
		Defensive,
		Cyberware
	}

	public enum gameFearStage
	{
		Relaxed,
		Stressed,
		Alarmed,
		Panic
	}

	public enum gameGOGRewardsSystemErrors
	{
		None,
		RequestFailed,
		TemporaryFailure,
		NoInternetConnection,
		NotSignedInGalaxy,
		NotSignedInLauncher
	}

	public enum gameGOGRewardsSystemStatus
	{
		Uninitialized,
		GeneratingCPID,
		CheckingRegistrationStatus,
		RegistrationPending,
		Registered,
		Error
	}

	public enum gameGameVersion
	{
		CP77_Initial,
		CP77_Development,
		CP77_GoldMaster,
		CP77_ActualGoldMaster,
		CP77_AlmostPatchDay0,
		CP77_PatchDay0,
		CP77_PatchDay0_Hotfix1,
		CP77_PatchDay0_Hotfix2,
		CP77_PatchDay0_Hotfix2_V2,
		CP77_PatchDay0_Hotfix3,
		CP77_PatchDay0_Hotfix4,
		CP77_Patch1,
		Current
	}

	public enum gameGameplayEventFlag
	{
		Ai,
		Trigger,
		Component,
		Script
	}

	public enum gameGlobalTierSubtype
	{
		Quest,
		Supervisor
	}

	public enum gameGodModeType
	{
		Immortal,
		Invulnerable,
		Mortal
	}

	public enum gameGrenadeThrowStartType
	{
		Invalid,
		LeftSide,
		RightSide,
		Top,
		Count
	}

	public enum gameInitalChoiceStage
	{
		None,
		LifePath,
		Gender,
		Customizations,
		Attributes,
		Finished
	}

	public enum gameInventoryItemAttachmentType
	{
		Generic,
		Dedicated
	}

	public enum gameInventoryItemShape
	{
		SingleSlot,
		DoubleSlot
	}

	public enum gameItemComparisonState
	{
		Default,
		NoChange,
		Better,
		Worse
	}

	public enum gameItemDisplayContext
	{
		None,
		Vendor,
		Tooltip,
		VendorPlayer,
		GearPanel,
		Backpack,
		DPAD_RADIAL,
		Attachment,
		Ripperdoc
	}

	public enum gameItemEquipContexts
	{
		LastWeaponEquipped,
		LastUsedMeleeWeapon,
		LastUsedRangedWeapon,
		Gadget,
		MeleeCyberware,
		LauncherCyberware,
		Fists
	}

	public enum gameItemIconGender
	{
		Female,
		Male
	}

	public enum gameItemUnequipContexts
	{
		AllWeapons,
		HeadClothing,
		FaceClothing,
		OuterChestClothing,
		InnerChestClothing,
		LegClothing,
		FootClothing,
		AllClothing,
		RightHandWeapon,
		LeftHandWeapon,
		AllQuestItems,
		AllItems
	}

	public enum gameJournalBriefingContentType
	{
		MapLocation,
		VideoContent,
		Paperdoll
	}

	public enum gameJournalCallbackOption
	{
		DoNotFire,
		Fire
	}

	public enum gameJournalChangeType
	{
		Undefined,
		Direct,
		Indirect,
		IndirectDependent
	}

	public enum gameJournalEntryState
	{
		Undefined,
		Inactive,
		Active,
		Succeeded,
		Failed
	}

	public enum gameJournalEntryUserState
	{
		Undefined,
		Inactive,
		Active,
		Succeeded,
		Failed,
		Read,
		Open
	}

	public enum gameJournalListenerType
	{
		State,
		Visited,
		Tracked,
		Untracked,
		Counter
	}

	public enum gameJournalNotifyOption
	{
		Undefined,
		DoNotNotify,
		Notify
	}

	public enum gameJournalQuestType
	{
		MainQuest,
		SideQuest,
		MinorQuest,
		StreetStory,
		Contract,
		VehicleQuest
	}

	public enum gameKillType
	{
		Normal,
		Defeat
	}

	public enum gameLoSMode
	{
		Invalid,
		Keep,
		Avoid
	}

	public enum gameLootItemType
	{
		Default,
		Quest,
		Shard
	}

	public enum gameMessageSender
	{
		NPC,
		Player
	}

	public enum gameMountDescriptorMountType
	{
		Unmounted,
		KeepState,
		Vehicle,
		MovingPlatform
	}

	public enum gameMountingObjectType
	{
		Invalid,
		Object,
		Vehicle,
		Puppet,
		Platform
	}

	public enum gameMountingRelationshipType
	{
		Invalid,
		Parent,
		Child
	}

	public enum gameMountingSlotRole
	{
		Invalid,
		Driver,
		Passenger
	}

	public enum gameMovingPlatformLoopType
	{
		NoLooping,
		Bounce,
		Repeat
	}

	public enum gameMovingPlatformMovementInitializationType
	{
		Time,
		Speed
	}

	public enum gameMuppetComparisonReportItemType
	{
		Different,
		WithinTolerance,
		Equal
	}

	public enum gameMuppetDebugCommand
	{
		None,
		Kill,
		KillAll
	}

	public enum gameMuppetInputActionType
	{
		Unknown,
		Impulse,
		Press
	}

	public enum gameMuppetMoveStyle
	{
		Invalid,
		Walk,
		Sprint,
		Crouch,
		WalkAim,
		GravityOnly
	}

	public enum gamePSMBodyCarrying
	{
		Any,
		Default,
		PickUp,
		Carry,
		Dispose,
		Drop
	}

	public enum gamePSMBodyCarryingStyle
	{
		Any,
		Default,
		Friendly,
		Strong
	}

	public enum gamePSMCombat
	{
		Any,
		Default,
		InCombat,
		OutOfCombat,
		Stealth
	}

	public enum gamePSMCover
	{
		Any,
		Default,
		InCover,
		Peek,
		Lean,
		OutOfCover
	}

	public enum gamePSMFallStates
	{
		Default,
		RegularFall,
		SafeFall,
		FastFall,
		VeryFastFall,
		DeathFall
	}

	public enum gamePSMHighLevel
	{
		Any,
		Default,
		SceneTier1,
		SceneTier2,
		SceneTier3,
		SceneTier4,
		SceneTier5
	}

	public enum gamePSMLandingState
	{
		Default,
		RegularLand,
		HardLand,
		VeryHardLand,
		DeathLand,
		SuperheroLand,
		SuperheroLandRecovery
	}

	public enum gamePSMLocomotionStates
	{
		Any,
		Default,
		Crouch,
		Sprint,
		Kereznikov,
		Jump
	}

	public enum gamePSMMelee
	{
		Any,
		Default,
		Attack,
		Block
	}

	public enum gamePSMSwimming
	{
		Any,
		Default,
		Surface,
		Diving
	}

	public enum gamePSMTakedown
	{
		Any,
		Default,
		EnteringGrapple,
		Grapple,
		Leap,
		Takedown
	}

	public enum gamePSMTimeDilation
	{
		Any,
		Default,
		Sandevistan
	}

	public enum gamePSMUpperBodyStates
	{
		Any,
		Default,
		SwitchItems,
		SwitchCyberware,
		Reload,
		Aim
	}

	public enum gamePSMVehicle
	{
		Any,
		Default,
		Driving,
		Combat,
		Passenger,
		Transition,
		Turret,
		DriverCombat,
		Scene
	}

	public enum gamePSMVision
	{
		Any,
		Default,
		Focus
	}

	public enum gamePSMWeaponStates
	{
		Any,
		Default,
		NoAmmo,
		Ready,
		Safe
	}

	public enum gamePSMZones
	{
		Any,
		Default,
		Public,
		Safe,
		Restricted,
		Dangerous
	}

	public enum gamePlatformMovementState
	{
		Stopped,
		Paused,
		MovingUp,
		MovingDown
	}

	public enum gamePlayerCoverDirection
	{
		None,
		Up,
		Left,
		Right
	}

	public enum gamePlayerCoverMode
	{
		None,
		Auto,
		Manual
	}

	public enum gamePlayerObstacleSystemQueryType
	{
		Climb_Vault,
		Covers,
		AverageNormal
	}

	public enum gamePlayerStateMachine
	{
		Locomotion,
		UpperBody,
		Weapon,
		HighLevel,
		Projectile,
		Vision,
		TimeDilation,
		CoverAction,
		IconicItem,
		Combat,
		Vehicle,
		Takedown
	}

	public enum gamePopulationEntityPriority
	{
		Quest,
		Community,
		Crowd
	}

	public enum gamePopupPosition
	{
		Undefined,
		UpperRight,
		UpperLeft,
		LowerLeft,
		LowerRight,
		Center
	}

	public enum gamePuppetVehicleState
	{
		IdleMounted,
		IdleStand,
		CombatSeated,
		CombatWindowed,
		Turret,
		GunnerSlot
	}

	public enum gameQuestGuidanceMarkerPathfindingType
	{
		Auto,
		Navmesh,
		Traffic
	}

	public enum gameRegular1v1FinisherScenarioPivotSetting
	{
		AttackerSlidesAndRotates_TargetStandsStill,
		AttackerStandsStill_TargetSlidesAndRotates
	}

	public enum gameReprimandMappinAnimationState
	{
		None,
		Normal,
		Fast
	}

	public enum gameSaveLockReason
	{
		Nothing,
		Combat,
		Scene,
		Quest,
		Script,
		Boundary,
		MainMenu,
		LoadingScreen,
		PlayerStateMachine,
		PlayerState,
		Tier,
		NotEnoughSlots,
		NotEnoughSpace,
		PlayerOnMovingPlatform
	}

	public enum gameScanningMode
	{
		Inactive,
		Light,
		Heavy
	}

	public enum gameScanningState
	{
		Default,
		Started,
		Stopped,
		Complete,
		ShallowComplete,
		Reset
	}

	public enum gameSceneAnimationMotionActionParamsActionPlayDirection
	{
		Forward,
		Backward
	}

	public enum gameSceneAnimationMotionActionParamsEasingType
	{
		Linear,
		SinusoidalEaseInOut,
		QuadraticEaseIn,
		QuadraticEaseOut,
		CubicEaseInOut,
		CubicEaseIn,
		CubicEaseOut
	}

	public enum gameSceneAnimationMotionActionParamsMotionType
	{
		Rid,
		Anim
	}

	public enum gameSceneAnimationMotionActionParamsPlacementMode
	{
		Blend,
		TeleportToStart,
		PlayAtActorPosition
	}

	public enum gameScriptedBlackboardStorage
	{
		Default
	}

	public enum gameSharedInventoryTag
	{
		None,
		PlayerStash
	}

	public enum gameSmartObjectInstanceEntryType
	{
		UseEntryAnimation,
		UseLocomotion
	}

	public enum gameSmartObjectPointType
	{
		Entry,
		Exit,
		Action
	}

	public enum gameSmartObjectType
	{
		Default,
		LadderUp,
		LadderDown,
		JumpOnSameLevel,
		Jump3mUp,
		Jump3mDown,
		Climb110cmUp,
		Climb110cmDown,
		Climb200cmUp,
		Climb200cmDown,
		Climb300cmUp,
		Climb300cmDown,
		Vault10cm,
		Vault40cm,
		Vault100cm,
		ChargedJump400cmUp,
		ChargedJump400cmDown,
		ChargedJump600cmUp,
		ChargedJump600cmDown,
		ChargedJump800cmUp,
		ChargedJump800cmDown,
		ThrusterJumpUp,
		ThrusterJumpDown,
		Climb400cmDown
	}
	public enum gameStatIDType
	{
		EntityID,
		ItemID,
		Invalid
	}

	public enum gameStatModifierType
	{
		Additive,
		AdditiveMultiplier,
		Multiplier,
		Count,
		Invalid
	}

	public enum gameStatObjectsRelation
	{
		Self,
		Owner,
		Root,
		Parent,
		Target,
		Player,
		Instigator,
		Count,
		Invalid
	}

	public enum gameStatPoolDataBonusType
	{
		None,
		Persistent,
		NonPersistent
	}

	public enum gameStatPoolDataStatPoolModificationStatus
	{
		Regeneration,
		Decay,
		NoModification
	}

	public enum gameStatPoolDataValueChangeMode
	{
		Normal,
		IncreasingOnly,
		DecreasingOnly,
		NonZero
	}

	public enum gameStatPoolModificationTypes
	{
		Regeneration,
		Decay
	}

	public enum gameStatPoolModifierProperty
	{
		RangeBegin,
		RangeEnd,
		StartDelay,
		ValuePerSec,
		Enabled,
		DelayOnChange,
		Count
	}

	public enum gameStatsBundleOwnerType
	{
		None,
		Cleared,
		UniqueItem,
		StackableItem,
		InnerItem,
		Entity,
		Stub,
		Reinitialized,
		Count,
		Invalid
	}

	public enum gameStoryTier
	{
		Gameplay,
		Cinematic
	}

	public enum gameTargetingSet
	{
		Visible,
		Frustum,
		Complete,
		None
	}

	public enum gameTelemetryDamageSituation
	{
		Irrelevant,
		EnemyToPlayer,
		EnemyToCompanion,
		PlayerToEnemy,
		CompanionToEnemy
	}

	public enum gameTelemetryMilestoneType
	{
		StartFact,
		ImportantFact,
		Reward,
		EndFact,
		EndReward,
		Invalid
	}

	public enum gameTickableEventState
	{
		Idle,
		FirstTick,
		NormalTick,
		LastTick,
		Canceled
	}

	public enum gameTransformAnimation_MoveOnSplineRotationMode
	{
		Disabled,
		Yaw,
		PitchAndYaw
	}

	public enum gameTransformAnimation_RotateOnAxisAxis
	{
		X,
		Y,
		Z
	}

	public enum gameTutorialBracketType
	{
		WidgetArea,
		CustomArea
	}

	public enum gameVehicleCommonCurve
	{
		RPMLimit,
		ForcedBrakeForce,
		COUNT
	}

	public enum gameVehicleCurve
	{
		SpeedToWheelMaxTurn,
		InputToWheelMaxTurn,
		SpeedToWheelTurnSpeed,
		InputToWheelTurnSpeed,
		COUNT
	}

	public enum gameVideoType
	{
		Tutorial_720x405,
		Tutorial_1024x576,
		Tutorial_1280x720,
		Tutorial_1360x768,
		Unknown
	}

	public enum gameVisionModePatternType
	{
		Default,
		Netrunner
	}

	public enum gameVisionModeType
	{
		Default,
		Focus
	}

	public enum gameWorkspotSlidingBehaviour
	{
		PlayAtResourcePosition,
		DontPlayAtResourcePosition,
		SlideActorAndRotateDevice
	}

	public enum gameaudioeventsSurfaceDirection
	{
		Normal,
		WallLeft,
		WallRight
	}

	public enum gamecheatsystemFlag
	{
		God_Immortal,
		God_Invulnerable,
		Resurrect,
		IgnoreTimeDilation,
		BypassMagazine,
		InfiniteAmmo,
		Kill,
		Invisible
	}

	public enum gamedataAIActionSecurityAreaType
	{
		DANGEROUS,
		DISABLED,
		RESTRICTED,
		SAFE,
		Count,
		Invalid
	}

	public enum gamedataAIActionSecurityNotificationType
	{
		COMBAT,
		DEESCALATE,
		DEFAULT,
		ILLEGAL_ACTION,
		REPRIMAND_ESCALATE,
		REPRIMAND_SUCCESSFUL,
		SECURITY_GATE,
		Count,
		Invalid
	}

	public enum gamedataAIActionTarget
	{
		AssignedVehicle,
		CombatTarget,
		CommandCover,
		CommandMovementDestination,
		ConsideredCover,
		CurrentCover,
		CurrentNetrunnerProxy,
		CustomWorldPosition,
		DesiredCover,
		FriendlyTarget,
		FurthestNavigableSquadmate,
		FurthestSquadmate,
		FurthestThreat,
		HostileOfficer,
		MountedVehicle,
		MovementDestination,
		NearestDefeatedSquadmate,
		NearestNavigableSquadmate,
		NearestSquadmate,
		NearestThreat,
		NetrunnerProxy,
		ObjectOfInterest,
		Owner,
		Player,
		PointOfInterest,
		RingBackDestination,
		RingBackLeftDestination,
		RingBackRightDestination,
		RingFrontDestination,
		RingFrontLeftDestination,
		RingFrontRightDestination,
		RingLeftDestination,
		RingRightDestination,
		SelectedCover,
		SpawnPosition,
		SquadOfficer,
		StimSource,
		StimTarget,
		TargetDevice,
		TargetItem,
		TopFriendly,
		TopThreat,
		VisibleFurthestThreat,
		VisibleNearestThreat,
		VisibleTopThreat,
		Count,
		Invalid
	}

	public enum gamedataAIActionType
	{
		BackUp,
		BattleCry,
		Block,
		CallOff,
		Charge,
		Crouch,
		Dash,
		GrenadeThrow,
		GroupReaction,
		Investigate,
		Melee,
		Peek,
		Quickhack,
		Reprimand,
		Search,
		Shoot,
		Sync,
		TakeCover,
		Takedown,
		Taunt,
		Count,
		Invalid
	}

	public enum gamedataAIAdditionalTraceType
	{
		Chest,
		Hip,
		Knee,
		Undefined,
		Count,
		Invalid
	}

	public enum gamedataAIDirectorEntryStartType
	{
		Default,
		DespawnAllEnemies,
		DespawnExcessedEnemies,
		WaitUntilNoEnemies,
		WaitUntilSameOrLessAmountOfEnemies,
		Count,
		Invalid
	}

	public enum gamedataAIExposureMethodType
	{
		BlindFire,
		Lean,
		StepOut,
		Count,
		Invalid
	}

	public enum gamedataAIRingType
	{
		Approach,
		Close,
		Default,
		Defend,
		Extreme,
		Far,
		LatestActive,
		Medium,
		Melee,
		Support,
		Undefined,
		Count,
		Invalid
	}

	public enum gamedataAIRole
	{
		Follower,
		Patrol,
		Count,
		Invalid
	}

	public enum gamedataAISmartCompositeType
	{
		Selector,
		SelectorWithMemory,
		SelectorWithSmartMemory,
		Sequence,
		SequenceWithMemory,
		SequenceWithSmartMemory,
		Count,
		Invalid
	}

	public enum gamedataAISquadType
	{
		Attitude,
		Community,
		Global,
		Security,
		Unknown,
		Count,
		Invalid
	}

	public enum gamedataAITacticType
	{
		Assault,
		Defend,
		Flank,
		Medivac,
		Panic,
		Regroup,
		Retreat,
		Snipe,
		Suppress,
		Count,
		Invalid
	}

	public enum gamedataAITicketType
	{
		BackUp,
		BattleCry,
		Block,
		CallOff,
		CatchUp,
		Charge,
		CloseRing,
		CloseRing1stFilter,
		CloseRing2ndFilter,
		Crouch,
		DefaultRing,
		Equip,
		EquipMelee,
		ExtremeRing,
		ExtremeRing1stFilter,
		ExtremeRing2ndFilter,
		FarRing,
		FarRing1stFilter,
		FarRing2ndFilter,
		GoToCover,
		GrenadeThrow,
		GroupReaction,
		Investigate,
		MediumRing,
		MediumRing1stFilter,
		MediumRing2ndFilter,
		Melee,
		MeleeApproach,
		MeleeRing,
		MeleeRing1stFilter,
		MeleeRing2ndFilter,
		MeleeSupport,
		Peek,
		QuickMelee,
		Quickhack,
		Reload,
		Reprimand,
		Search,
		Shoot,
		SimpleCombat,
		SimpleCombatMovement,
		Strafe,
		StrafeEvade,
		Sync,
		TakeCover,
		Takedown,
		Taunt,
		TauntBackground,
		Count,
		Invalid
	}

	public enum gamedataAchievement
	{
		Bladerunner,
		BornToBeWild,
		Breathtaking,
		BushidoAndChill,
		Cyberjunkie,
		Denied,
		FollowingTheRiver,
		Fortuneteller,
		Gearhead,
		GetMeThereScottie,
		GunKata,
		Gunslinger,
		HandyMan,
		IAmMaxTac,
		LikeFatherLikeSon,
		LittleTokyo,
		MasterRunner,
		MaxPain,
		MustBeTheRats,
		NeverFadeAway,
		NoMansLand,
		NotTheMobile,
		QueenOfTheHighway,
		Roleplayer,
		Specialist,
		Temperance,
		ThatIsSoHardForTheKnees,
		TheDevil,
		TheFool,
		TheHermit,
		TheHightPriestess,
		TheLovers,
		TheStar,
		TheSun,
		TheWheelOfFortune,
		TheWorld,
		ThisIsPacifica,
		TradeUnion,
		TrueSoldier,
		TrueWarrior,
		TwoHeadsOneBullet,
		UnderPressure,
		VForVendetta,
		YipMan,
		YouKnowWhoIAm,
		Count,
		Invalid
	}

	public enum gamedataAffiliation
	{
		AfterlifeMercs,
		Aldecaldos,
		Animals,
		Arasaka,
		Biotechnica,
		CityCouncil,
		Civilian,
		KangTao,
		Maelstrom,
		Militech,
		NCPD,
		NetWatch,
		News54,
		RecordingAgency,
		SSI,
		Scavengers,
		SixthStreet,
		SouthCalifornia,
		TheMox,
		TraumaTeam,
		TygerClaws,
		Unaffiliated,
		UnaffiliatedCorpo,
		Unknown,
		Valentinos,
		VoodooBoys,
		Wraiths,
		Count,
		Invalid
	}

	public enum gamedataAimAssistType
	{
		HeadTarget,
		LegTarget,
		MechanicalTarget,
		Melee,
		None,
		QuickHack,
		Scanning,
		Shooting,
		ShootingLimbCyber,
		Count,
		Invalid
	}

	public enum gamedataArchetypeType
	{
		AndroidMeleeT1,
		AndroidMeleeT2,
		AndroidRangedT2,
		FastMeleeT2,
		FastMeleeT3,
		FastRangedT2,
		FastRangedT3,
		FastShotgunnerT2,
		FastShotgunnerT3,
		FastSniperT3,
		FriendlyGenericRangedT3,
		GenericMeleeT1,
		GenericMeleeT2,
		GenericRangedT1,
		GenericRangedT2,
		GenericRangedT3,
		HeavyMeleeT2,
		HeavyMeleeT3,
		HeavyRangedT2,
		HeavyRangedT3,
		NetrunnerT1,
		NetrunnerT2,
		NetrunnerT3,
		ShotgunnerT2,
		ShotgunnerT3,
		SniperT2,
		TechieT2,
		TechieT3,
		Count,
		Invalid
	}

	public enum gamedataAttackSubtype
	{
		BlockAttack,
		ComboAttack,
		CrouchAttack,
		DeflectAttack,
		EquipAttack,
		FinalAttack,
		JumpAttack,
		SafeAttack,
		SprintAttack,
		ThrowAttack,
		Count,
		Invalid
	}

	public enum gamedataAttackType
	{
		ChargedWhipAttack,
		Direct,
		Effect,
		Explosion,
		GuardBreak,
		Hack,
		Melee,
		PressureWave,
		QuickMelee,
		Ranged,
		Reflect,
		StrongMelee,
		Thrown,
		WhipAttack,
		Count,
		Invalid
	}

	public enum gamedataBuildType
	{
		CombatNetrunner0,
		CombatNetrunner10,
		CombatNetrunner15,
		CombatNetrunner18,
		CombatNetrunner20,
		CombatNetrunner25,
		CombatNetrunner30,
		CombatNetrunner35,
		CombatNetrunner40,
		CombatNetrunner5,
		CombatNetrunner50,
		CorporateStarting,
		E32019NetrunnerPhase1,
		E32019StrongSoloPhase1,
		FunctionalTestsProgressionBuildTest,
		FunctionalTestsStartingBuild,
		GYMcclBuild,
		GymSmoketestMaxedBuild,
		HandsOnStarting,
		ItemPass_BaseBuild,
		ItemPass_FactionMeleeMods,
		ItemPass_FactionRangedMods,
		ItemPass_IconicMods,
		ItemPass_LegendaryMods,
		ItemPass_PowerMods,
		ItemPass_SmartMods,
		ItemPass_StandardMods,
		ItemPass_TechMods,
		JohnnyQ101,
		JohnnyQ108,
		JohnnyQ204,
		MaxSkillsAllWeapons,
		MeleeCombat0,
		MeleeCombat10,
		MeleeCombat15,
		MeleeCombat20,
		MeleeCombat25,
		MeleeCombat30,
		MeleeCombat35,
		MeleeCombat40,
		MeleeCombat45,
		MeleeCombat5,
		MeleeCombat50,
		NomadStarting,
		RangedCombat0,
		RangedCombat10,
		RangedCombat15,
		RangedCombat20,
		RangedCombat25,
		RangedCombat30,
		RangedCombat35,
		RangedCombat40,
		RangedCombat45,
		RangedCombat5,
		RangedCombat50,
		StartingBuild,
		StreetKidStarting,
		UIStressTest,
		mech_netrunner,
		q003_royce_netrunner,
		q003_royce_noBuild,
		q003_royce_solo,
		q110_sasquatch_netrunner,
		q110_sasquatch_noBuild,
		q110_sasquatch_solo,
		q112_oda_netrunner,
		q112_oda_noBuild,
		q112_oda_solo,
		q113_smasher_melee,
		q113_smasher_netrunner,
		q113_smasher_noBuild,
		q113_smasher_solo,
		CpoAssassinBuild,
		CpoDefaultBuild,
		CpoNetrunnerBuild,
		CpoSoloBuild,
		CpoTechieBuild,
		Count,
		Invalid
	}

	public enum gamedataChargeStep
	{
		Idle,
		Charging,
		Charged,
		Overcharging,
		Discharging
	}

	public enum gamedataChoiceCaptionPartType
	{
		Blueline,
		Icon,
		QuickhackCost,
		Tag,
		Text,
		Count,
		Invalid
	}

	public enum gamedataCompanionDistancePreset
	{
		Close,
		Far,
		Medium,
		VeryFar,
		Count,
		Invalid
	}

	public enum gamedataConsumableBaseName
	{
		Alcohol,
		BonesMcCoy70,
		CarryCapacityBooster,
		Drinkable,
		Edible,
		FirstAidWhiff,
		HealthBooster,
		MemoryBooster,
		OxyBooster,
		StaminaBooster,
		Count,
		Invalid
	}

	public enum gamedataConsumableType
	{
		Drug,
		Medical,
		Count,
		Invalid
	}

	public enum gamedataDamageType
	{
		Chemical,
		Electric,
		Physical,
		Thermal,
		Count,
		Invalid
	}

	public enum gamedataDataNodeType
	{
		File,
		Group,
		Variable,
		Value,
		SimpleValue,
		ComplexValue
	}

	public enum gamedataDefenseMode
	{
		DefendAll,
		DefendMelee,
		DefendRanged,
		NoDefend,
		Count,
		Invalid
	}

	public enum gamedataDevelopmentPointType
	{
		Attribute,
		Primary,
		Secondary,
		Count,
		Invalid
	}

	public enum gamedataDistrict
	{
		ArasakaWaterfront,
		ArasakaWaterfront_AbandonedWarehouse,
		ArasakaWaterfront_KonpekiPlaza,
		Arroyo,
		Arroyo_Arasaka_Warehouse,
		Arroyo_ClairesGarage,
		Arroyo_CytechFactory,
		Arroyo_Kendachi,
		Arroyo_KenmoreCafe,
		Arroyo_LasPalapas,
		Arroyo_Red_Dirt,
		Arroyo_TireEmpire,
		Badlands,
		Badlands_BiotechnicaFlats,
		Badlands_DryCreek,
		Badlands_JacksonPlains,
		Badlands_LagunaBend,
		Badlands_LasPalapas,
		Badlands_RattlesnakeCreek,
		Badlands_RedPeaks,
		Badlands_RockyRidge,
		Badlands_SantaClara,
		Badlands_SierraSonora,
		Badlands_SoCalBorderCrossing,
		Badlands_VasquezPass,
		Badlands_Yucca,
		Badlands_YuccaGarage,
		Badlands_YuccaRadioTower,
		CharterHill,
		CharterHill_PowerPlant,
		CityCenter,
		Coastview,
		Coastview_BattysHotel,
		Coastview_ButcherShop,
		Coastview_GrandImperialMall,
		Coastview_RundownApartment,
		Coastview_VDBChapel,
		Coastview_VDBMaglev,
		Coastview_q110Cyberspace,
		CorpoPlaza,
		CorpoPlaza_ArasakaTowerAtrium,
		CorpoPlaza_ArasakaTowerCEOFloor,
		CorpoPlaza_ArasakaTowerJenkins,
		CorpoPlaza_ArasakaTowerJungle,
		CorpoPlaza_ArasakaTowerLobby,
		CorpoPlaza_ArasakaTowerNest,
		CorpoPlaza_ArasakaTowerSaburoOffice,
		CorpoPlaza_ArasakaTowerUnlistedFloors,
		CorpoPlaza_ArasakaTowerUpperAtrium,
		CorpoPlaza_q201Cyberspace,
		Downtown,
		Downtown_Jinguji,
		Downtown_TheHammer,
		Glen,
		Glen_Embers,
		Glen_MusicStore,
		Glen_NCPDLab,
		Glen_WichedTires,
		Heywood,
		JapanTown,
		JapanTown_Clouds,
		JapanTown_DarkMatter,
		JapanTown_Fingers,
		JapanTown_FourthWallBdStudio,
		JapanTown_HiromisApartment,
		JapanTown_MegabuildingH8,
		JapanTown_VR_Tutorial,
		JapanTown_Wakakos_Pachinko_Parlor,
		Kabuki,
		Kabuki_JudysApartment,
		Kabuki_LizziesBar,
		Kabuki_NoTellMotel,
		LagunaBend_LakeHut,
		LittleChina,
		LittleChina_Afterlife,
		LittleChina_MistysShop,
		LittleChina_Q101Cyberspace,
		LittleChina_RiotClub,
		LittleChina_TomsDiner,
		LittleChina_VApartment,
		LittleChina_VictorsClinic,
		NorthBadlands,
		NorthOaks,
		NorthOaks_Arasaka_Estate,
		NorthOaks_Columbarium,
		NorthOaks_Denny_Estate,
		NorthOaks_Kerry_Estate,
		Northside,
		Northside_All_Foods,
		Northside_CleanCut,
		Northside_Totentaz,
		Northside_WNS,
		Pacifica,
		RanchoCoronado,
		RanchoCoronado_Caliente,
		RanchoCoronado_GunORama,
		RanchoCoronado_Piez,
		RanchoCoronado_Softsys,
		RanchoCoronado_Stylishly,
		SantoDomingo,
		SouthBadlands,
		SouthBadlands_EdgewoodFarm,
		SouthBadlands_PoppyFarm,
		SouthBadlands_TrailerPark,
		SouthBadlands_q201SpaceStation,
		VistaDelRey,
		Vista_del_Rey_Delamain,
		Vista_del_Rey_LaCatrina,
		Vista_del_rey_Abandoned_Apartment_Building,
		Vista_del_rey_ElCoyoteCojo,
		Watson,
		Wellsprings,
		WestWindEstate,
		Westbrook,
		Count,
		Invalid
	}

	public enum gamedataEquipmentArea
	{
		AbilityCW,
		ArmsCW,
		BaseFists,
		BotCPU,
		BotChassisModule,
		BotMainModule,
		BotSoftware,
		CardiovascularSystemCW,
		Consumable,
		CyberwareWheel,
		EyesCW,
		Face,
		Feet,
		FrontalCortexCW,
		Gadget,
		HandsCW,
		Head,
		ImmuneSystemCW,
		InnerChest,
		IntegumentarySystemCW,
		LeftArm,
		Legs,
		LegsCW,
		MusculoskeletalSystemCW,
		NervousSystemCW,
		OuterChest,
		Outfit,
		PersonalLink,
		PlayerTattoo,
		Quest,
		QuickSlot,
		QuickWheel,
		RightArm,
		SilverhandArm,
		Splinter,
		SystemReplacementCW,
		UnderwearBottom,
		UnderwearTop,
		VDefaultHandgun,
		Weapon,
		WeaponHeavy,
		WeaponLeft,
		WeaponWheel,
		Count,
		Invalid
	}

	public enum gamedataEthnicity
	{
		African,
		AfricanAmerican,
		AmericanEnglish,
		Arabic,
		Brasilian,
		BritishEnglish,
		Caribbean,
		Chinese,
		Default,
		Indian,
		Japanese,
		Mexican,
		NativeAmerican,
		Russian,
		Count,
		Invalid
	}

	public enum gamedataFxAction
	{
		EnterCharge,
		EnterDischarge,
		EnterLowAmmo,
		EnterNoAmmo,
		EnterOverheat,
		EnterReload,
		ExitCharge,
		ExitDischarge,
		ExitLowAmmo,
		ExitNoAmmo,
		ExitOverheat,
		ExitReload,
		MeleeBlock,
		MeleeHit,
		Shoot,
		SilencedShoot,
		Count,
		Invalid
	}

	public enum gamedataFxActionType
	{
		BreakLoop,
		Kill,
		Start,
		Count,
		Invalid
	}

	public enum gamedataGender
	{
		Default,
		Female,
		Male,
		Count,
		Invalid
	}

	public enum gamedataGrenadeDeliveryMethodType
	{
		Homing,
		Regular,
		Sticky,
		Count,
		Invalid
	}

	public enum gamedataGroupNodeGroupVariableDeriveInfo
	{
		FullyDerived,
		TypeDerived,
		ValueChanged,
		NotDerived
	}

	public enum gamedataGroupNodeInheritanceState
	{
		Unresolved,
		Resolving,
		Resolved
	}

	public enum gamedataHitPrereqConditionType
	{
		AgentMoving,
		AmmoState,
		AttackSubType,
		AttackType,
		BodyPart,
		DamageOverTimeType,
		DamageType,
		DistanceCovered,
		HitFlag,
		InstigatorType,
		SameTarget,
		SourceType,
		StatPool,
		StatPoolComparison,
		StatusEffectPresent,
		TargetKilled,
		TargetNPCRarity,
		TargetNPCType,
		TargetType,
		WeaponType,
		WoundedTriggered,
		Count,
		Invalid
	}

	public enum gamedataImprovementRelation
	{
		Direct,
		Inverse,
		None,
		Count,
		Invalid
	}

	public enum gamedataItemCategory
	{
		Clothing,
		Consumable,
		Cyberware,
		Gadget,
		General,
		Part,
		Weapon,
		Count,
		Invalid
	}

	public enum gamedataItemStructure
	{
		BlueprintStackable,
		Stackable,
		Unique,
		Count,
		Invalid
	}

	public enum gamedataItemType
	{
		Clo_Face,
		Clo_Feet,
		Clo_Head,
		Clo_InnerChest,
		Clo_Legs,
		Clo_OuterChest,
		Clo_Outfit,
		Con_Ammo,
		Con_Edible,
		Con_Inhaler,
		Con_Injector,
		Con_LongLasting,
		Con_Skillbook,
		Cyb_Ability,
		Cyb_Launcher,
		Cyb_MantisBlades,
		Cyb_NanoWires,
		Cyb_StrongArms,
		Fla_Launcher,
		Fla_Rifle,
		Fla_Shock,
		Fla_Support,
		Gad_Grenade,
		Gen_CraftingMaterial,
		Gen_DataBank,
		Gen_Junk,
		Gen_Keycard,
		Gen_Misc,
		Gen_Readable,
		GrenadeDelivery,
		Grenade_Core,
		Prt_Capacitor,
		Prt_FabricEnhancer,
		Prt_Fragment,
		Prt_Magazine,
		Prt_Mod,
		Prt_Muzzle,
		Prt_Program,
		Prt_Receiver,
		Prt_Scope,
		Prt_ScopeRail,
		Prt_Stock,
		Prt_TargetingSystem,
		Wea_AssaultRifle,
		Wea_Fists,
		Wea_Hammer,
		Wea_Handgun,
		Wea_HeavyMachineGun,
		Wea_Katana,
		Wea_Knife,
		Wea_LightMachineGun,
		Wea_LongBlade,
		Wea_Melee,
		Wea_OneHandedClub,
		Wea_PrecisionRifle,
		Wea_Revolver,
		Wea_Rifle,
		Wea_ShortBlade,
		Wea_Shotgun,
		Wea_ShotgunDual,
		Wea_SniperRifle,
		Wea_SubmachineGun,
		Wea_TwoHandedClub,
		Count,
		Invalid
	}

	public enum gamedataLifePath
	{
		Corporate,
		Nomad,
		StreetKid,
		Count,
		Invalid
	}

	public enum gamedataLocomotionMode
	{
		Moving,
		Static,
		Count,
		Invalid
	}

	public enum gamedataMappinPhase
	{
		CompletedPhase,
		DefaultPhase,
		DiscoveredPhase,
		UndiscoveredPhase,
		Count,
		Invalid
	}

	public enum gamedataMappinVariant
	{
		ActionDealDamageVariant,
		ActionFastSoloVariant,
		ActionGenericInteractionVariant,
		ActionNetrunnerAccessPointVariant,
		ActionNetrunnerVariant,
		ActionScanVariant,
		ActionSoloVariant,
		ActionTechieVariant,
		AimVariant,
		AllowVariant,
		ApartmentVariant,
		ArrowVariant,
		BackOutVariant,
		BountyHuntVariant,
		CallVariant,
		ChangeToFriendlyVariant,
		ClientInDistressVariant,
		ConversationVariant,
		ConvoyVariant,
		CoolVariant,
		CourierVariant,
		CustomPositionVariant,
		CyberspaceNPC,
		CyberspaceObject,
		DefaultInteractionVariant,
		DefaultQuestVariant,
		DefaultVariant,
		DistractVariant,
		DropboxVariant,
		DynamicEventVariant,
		EffectAlarmVariant,
		EffectControlNetworkVariant,
		EffectControlOtherDeviceVariant,
		EffectControlSelfVariant,
		EffectCutPowerVariant,
		EffectDistractVariant,
		EffectDropPointVariant,
		EffectExplodeLethalVariant,
		EffectExplodeNonLethalVariant,
		EffectFallVariant,
		EffectGrantInformationVariant,
		EffectHideBodyVariant,
		EffectLootVariant,
		EffectOpenPathVariant,
		EffectPushVariant,
		EffectServicePointVariant,
		EffectShootVariant,
		EffectSpreadGasVariant,
		EffectStoreItemsVariant,
		ExclamationMarkVariant,
		FailedCrossingVariant,
		FastTravelVariant,
		FixerVariant,
		FocusClueVariant,
		GPSForcedPathVariant,
		GPSPortalVariant,
		GangWatchVariant,
		GenericRoleVariant,
		GetInVariant,
		GetUpVariant,
		GrenadeVariant,
		GunSuicideVariant,
		HandVariant,
		HazardWarningVariant,
		HiddenStashVariant,
		HitVariant,
		HuntForPsychoVariant,
		ImportantInteractionVariant,
		InvalidVariant,
		JackInVariant,
		JamWeaponVariant,
		LifepathCorpoVariant,
		LifepathNomadVariant,
		LifepathStreetKidVariant,
		LootVariant,
		MinorActivityVariant,
		NPCVariant,
		NetrunnerAccessPointVariant,
		NetrunnerSoloTechieVariant,
		NetrunnerSoloVariant,
		NetrunnerTechieVariant,
		NetrunnerVariant,
		NonLethalTakedownVariant,
		OffVariant,
		OpenVendorVariant,
		OutpostVariant,
		PhoneCallVariant,
		QuestGiverVariant,
		QuestionMarkVariant,
		QuickHackVariant,
		ReflexesVariant,
		ResourceVariant,
		RetrievingVariant,
		SOSsignalVariant,
		SabotageVariant,
		ServicePointBarVariant,
		ServicePointClothesVariant,
		ServicePointCyberwareVariant,
		ServicePointDropPointVariant,
		ServicePointFoodVariant,
		ServicePointGunsVariant,
		ServicePointJunkVariant,
		ServicePointMedsVariant,
		ServicePointMeleeTrainerVariant,
		ServicePointNetTrainerVariant,
		ServicePointProstituteVariant,
		ServicePointRipperdocVariant,
		ServicePointTechVariant,
		SitVariant,
		SmugglersDenVariant,
		SoloTechieVariant,
		SoloVariant,
		SpeechVariant,
		TakeControlVariant,
		TakeDownVariant,
		TarotVariant,
		TechieVariant,
		ThieveryVariant,
		UseVariant,
		VehicleVariant,
		WanderingMerchantVariant,
		CPO_PingDoorVariant,
		CPO_PingGoHereVariant,
		CPO_PingLootVariant,
		CPO_RemotePlayerVariant,
		Count,
		Invalid
	}

	public enum gamedataMeleeAttackDirection
	{
		Center,
		DownToUp,
		LeftDownToRightUp,
		LeftToRight,
		LeftUpToRightDown,
		RightDownToLeftUp,
		RightToLeft,
		RightUpToLeftDown,
		UpToDown,
		Count,
		Invalid
	}

	public enum gamedataMetaQuest
	{
		MetaQuest1,
		MetaQuest2,
		MetaQuest3,
		Count,
		Invalid
	}

	public enum gamedataMovementType
	{
		Run,
		Sprint,
		Strafe,
		Walk,
		Count,
		Invalid
	}

	public enum gamedataNPCBehaviorState
	{
		State1,
		State2,
		State3,
		State4,
		State5,
		Count,
		Invalid
	}

	public enum gamedataNPCHighLevelState
	{
		Alerted,
		Any,
		Combat,
		Dead,
		Fear,
		Relaxed,
		Stealth,
		Unconscious,
		Wounded,
		Count,
		Invalid
	}

	public enum gamedataNPCQuestAffiliation
	{
		General,
		MainQuest,
		MinorActivity,
		MinorQuest,
		SideQuest,
		StreetStory,
		Count,
		Invalid
	}

	public enum gamedataNPCRarity
	{
		Boss,
		Elite,
		Normal,
		Officer,
		Rare,
		Trash,
		Weak,
		Count,
		Invalid
	}

	public enum gamedataNPCStanceState
	{
		Any,
		Cover,
		Crouch,
		Stand,
		Swim,
		Vehicle,
		VehicleWindow,
		Count,
		Invalid
	}

	public enum gamedataNPCType
	{
		Android,
		Any,
		Drone,
		Human,
		Mech,
		Spiderbot,
		Count,
		Invalid
	}

	public enum gamedataNPCUpperBodyState
	{
		Aim,
		Any,
		Attack,
		ChargedAttack,
		Defend,
		Equip,
		Normal,
		Parry,
		Reload,
		Shoot,
		Taunt,
		Count,
		Invalid
	}

	public enum gamedataObjectActionReference
	{
		Instigator,
		Source,
		Target,
		Count,
		Invalid
	}

	public enum gamedataObjectActionType
	{
		DeviceQuickHack,
		Direct,
		Item,
		MinigameUpload,
		Payment,
		PuppetQuickHack,
		Remote,
		Count,
		Invalid
	}

	public enum gamedataOutput
	{
		AskToFollowOrder,
		AskToHolster,
		BackOff,
		BodyInvestigate,
		Bump,
		CallGuard,
		CallPolice,
		DeviceInvestigate,
		Dodge,
		DodgeToSide,
		FearInPlace,
		Flee,
		Ignore,
		Intruder,
		Investigate,
		LookAt,
		Panic,
		PlayerCall,
		Reprimand,
		SquadCall,
		Surrender,
		TurnAt,
		WalkAway,
		Count,
		Invalid
	}

	public enum gamedataParentAttachmentType
	{
		Animated,
		Skinned,
		Slot,
		Count,
		Invalid
	}

	public enum gamedataPerkArea
	{
		Assault_Area_01,
		Assault_Area_02,
		Assault_Area_03,
		Assault_Area_04,
		Assault_Area_05,
		Assault_Area_06,
		Assault_Area_07,
		Assault_Area_08,
		Assault_Area_09,
		Assault_Area_10,
		Athletics_Area_01,
		Athletics_Area_02,
		Athletics_Area_03,
		Athletics_Area_04,
		Athletics_Area_05,
		Athletics_Area_06,
		Athletics_Area_07,
		Athletics_Area_08,
		Athletics_Area_09,
		Athletics_Area_10,
		Brawling_Area_01,
		Brawling_Area_02,
		Brawling_Area_03,
		Brawling_Area_04,
		Brawling_Area_05,
		Brawling_Area_06,
		Brawling_Area_07,
		Brawling_Area_08,
		ColdBlood_Area_01,
		ColdBlood_Area_02,
		ColdBlood_Area_03,
		ColdBlood_Area_04,
		ColdBlood_Area_05,
		ColdBlood_Area_06,
		ColdBlood_Area_07,
		ColdBlood_Area_08,
		ColdBlood_Area_09,
		ColdBlood_Area_10,
		CombatHacking_Area_01,
		CombatHacking_Area_02,
		CombatHacking_Area_03,
		CombatHacking_Area_04,
		CombatHacking_Area_05,
		CombatHacking_Area_06,
		CombatHacking_Area_07,
		CombatHacking_Area_08,
		CombatHacking_Area_09,
		CombatHacking_Area_10,
		Crafting_Area_01,
		Crafting_Area_02,
		Crafting_Area_03,
		Crafting_Area_04,
		Crafting_Area_05,
		Crafting_Area_06,
		Crafting_Area_07,
		Crafting_Area_08,
		Crafting_Area_09,
		Crafting_Area_10,
		Demolition_Area_01,
		Demolition_Area_02,
		Demolition_Area_03,
		Demolition_Area_04,
		Demolition_Area_05,
		Demolition_Area_06,
		Demolition_Area_07,
		Demolition_Area_08,
		Demolition_Area_09,
		Demolition_Area_10,
		Engineering_Area_01,
		Engineering_Area_02,
		Engineering_Area_03,
		Engineering_Area_04,
		Engineering_Area_05,
		Engineering_Area_06,
		Engineering_Area_07,
		Engineering_Area_08,
		Engineering_Area_09,
		Engineering_Area_10,
		Gunslinger_Area_01,
		Gunslinger_Area_02,
		Gunslinger_Area_03,
		Gunslinger_Area_04,
		Gunslinger_Area_05,
		Gunslinger_Area_06,
		Gunslinger_Area_07,
		Gunslinger_Area_08,
		Gunslinger_Area_09,
		Gunslinger_Area_10,
		Hacking_Area_01,
		Hacking_Area_02,
		Hacking_Area_03,
		Hacking_Area_04,
		Hacking_Area_05,
		Hacking_Area_06,
		Hacking_Area_07,
		Hacking_Area_08,
		Hacking_Area_09,
		Hacking_Area_10,
		Kenjutsu_Area_01,
		Kenjutsu_Area_02,
		Kenjutsu_Area_03,
		Kenjutsu_Area_04,
		Kenjutsu_Area_05,
		Kenjutsu_Area_06,
		Kenjutsu_Area_07,
		Kenjutsu_Area_08,
		Stealth_Area_01,
		Stealth_Area_02,
		Stealth_Area_03,
		Stealth_Area_04,
		Stealth_Area_05,
		Stealth_Area_06,
		Stealth_Area_07,
		Stealth_Area_08,
		Stealth_Area_09,
		Stealth_Area_10,
		Count,
		Invalid
	}

	public enum gamedataPerkType
	{
		Assault_Area_01_Perk_1,
		Assault_Area_01_Perk_2,
		Assault_Area_02_Perk_1,
		Assault_Area_02_Perk_2,
		Assault_Area_03_Perk_1,
		Assault_Area_03_Perk_2,
		Assault_Area_04_Perk_1,
		Assault_Area_04_Perk_2,
		Assault_Area_05_Perk_1,
		Assault_Area_05_Perk_2,
		Assault_Area_06_Perk_1,
		Assault_Area_06_Perk_2,
		Assault_Area_07_Perk_1,
		Assault_Area_07_Perk_2,
		Assault_Area_08_Perk_1,
		Assault_Area_08_Perk_2,
		Assault_Area_09_Perk_1,
		Assault_Area_09_Perk_2,
		Assault_Area_10_Perk_1,
		Athletics_Area_01_Perk_1,
		Athletics_Area_01_Perk_2,
		Athletics_Area_02_Perk_1,
		Athletics_Area_02_Perk_2,
		Athletics_Area_03_Perk_1,
		Athletics_Area_03_Perk_2,
		Athletics_Area_04_Perk_1,
		Athletics_Area_04_Perk_2,
		Athletics_Area_05_Perk_1,
		Athletics_Area_05_Perk_2,
		Athletics_Area_05_Perk_3,
		Athletics_Area_06_Perk_1,
		Athletics_Area_06_Perk_2,
		Athletics_Area_06_Perk_3,
		Athletics_Area_07_Perk_1,
		Athletics_Area_07_Perk_2,
		Athletics_Area_08_Perk_1,
		Athletics_Area_08_Perk_2,
		Athletics_Area_09_Perk_1,
		Athletics_Area_10_Perk_1,
		Athletics_Area_10_Perk_2,
		Brawling_Area_01_Perk_1,
		Brawling_Area_01_Perk_2,
		Brawling_Area_02_Perk_1,
		Brawling_Area_02_Perk_2,
		Brawling_Area_03_Perk_1,
		Brawling_Area_03_Perk_2,
		Brawling_Area_04_Perk_1,
		Brawling_Area_04_Perk_2,
		Brawling_Area_05_Perk_1,
		Brawling_Area_05_Perk_2,
		Brawling_Area_06_Perk_1,
		Brawling_Area_06_Perk_2,
		Brawling_Area_07_Perk_1,
		Brawling_Area_07_Perk_2,
		Brawling_Area_08_Perk_1,
		Brawling_Area_08_Perk_2,
		ColdBlood_Area_01_Perk_1,
		ColdBlood_Area_02_Perk_1,
		ColdBlood_Area_02_Perk_2,
		ColdBlood_Area_03_Perk_1,
		ColdBlood_Area_03_Perk_2,
		ColdBlood_Area_04_Perk_1,
		ColdBlood_Area_04_Perk_2,
		ColdBlood_Area_05_Perk_1,
		ColdBlood_Area_05_Perk_2,
		ColdBlood_Area_06_Perk_1,
		ColdBlood_Area_06_Perk_2,
		ColdBlood_Area_06_Perk_3,
		ColdBlood_Area_07_Perk_1,
		ColdBlood_Area_07_Perk_2,
		ColdBlood_Area_08_Perk_1,
		ColdBlood_Area_08_Perk_2,
		ColdBlood_Area_09_Perk_1,
		ColdBlood_Area_10_Perk_1,
		CombatHacking_Area_01_Perk_1,
		CombatHacking_Area_01_Perk_2,
		CombatHacking_Area_02_Perk_1,
		CombatHacking_Area_02_Perk_2,
		CombatHacking_Area_02_Perk_3,
		CombatHacking_Area_03_Perk_1,
		CombatHacking_Area_03_Perk_2,
		CombatHacking_Area_04_Perk_1,
		CombatHacking_Area_05_Perk_1,
		CombatHacking_Area_06_Perk_1,
		CombatHacking_Area_06_Perk_2,
		CombatHacking_Area_06_Perk_3,
		CombatHacking_Area_07_Perk_1,
		CombatHacking_Area_08_Perk_1,
		CombatHacking_Area_08_Perk_2,
		CombatHacking_Area_09_Perk_1,
		CombatHacking_Area_10_Perk_1,
		CombatHacking_Area_10_Perk_2,
		Crafting_Area_01_Perk_1,
		Crafting_Area_01_Perk_2,
		Crafting_Area_02_Perk_1,
		Crafting_Area_02_Perk_2,
		Crafting_Area_03_Perk_1,
		Crafting_Area_04_Perk_1,
		Crafting_Area_04_Perk_2,
		Crafting_Area_05_Perk_1,
		Crafting_Area_05_Perk_2,
		Crafting_Area_06_Perk_1,
		Crafting_Area_06_Perk_2,
		Crafting_Area_06_Perk_3,
		Crafting_Area_07_Perk_1,
		Crafting_Area_07_Perk_2,
		Crafting_Area_08_Perk_1,
		Crafting_Area_08_Perk_2,
		Crafting_Area_09_Perk_1,
		Crafting_Area_10_Perk_1,
		Demolition_Area_01_Perk_1,
		Demolition_Area_02_Perk_1,
		Demolition_Area_02_Perk_2,
		Demolition_Area_03_Perk_1,
		Demolition_Area_03_Perk_2,
		Demolition_Area_04_Perk_1,
		Demolition_Area_04_Perk_2,
		Demolition_Area_05_Perk_1,
		Demolition_Area_05_Perk_2,
		Demolition_Area_06_Perk_1,
		Demolition_Area_06_Perk_2,
		Demolition_Area_07_Perk_1,
		Demolition_Area_07_Perk_2,
		Demolition_Area_08_Perk_1,
		Demolition_Area_08_Perk_2,
		Demolition_Area_09_Perk_1,
		Demolition_Area_09_Perk_2,
		Demolition_Area_10_Perk_1,
		Demolition_Area_10_Perk_2,
		Engineering_Area_01_Perk_1,
		Engineering_Area_01_Perk_2,
		Engineering_Area_02_Perk_1,
		Engineering_Area_02_Perk_2,
		Engineering_Area_03_Perk_1,
		Engineering_Area_04_Perk_1,
		Engineering_Area_04_Perk_2,
		Engineering_Area_04_Perk_3,
		Engineering_Area_05_Perk_1,
		Engineering_Area_05_Perk_2,
		Engineering_Area_06_Perk_1,
		Engineering_Area_06_Perk_2,
		Engineering_Area_07_Perk_1,
		Engineering_Area_07_Perk_2,
		Engineering_Area_07_Perk_3,
		Engineering_Area_08_Perk_1,
		Engineering_Area_08_Perk_2,
		Engineering_Area_09_Perk_1,
		Engineering_Area_10_Perk_1,
		Engineering_Area_10_Perk_2,
		Gunslinger_Area_01_Perk_1,
		Gunslinger_Area_01_Perk_2,
		Gunslinger_Area_02_Perk_1,
		Gunslinger_Area_02_Perk_2,
		Gunslinger_Area_03_Perk_1,
		Gunslinger_Area_03_Perk_2,
		Gunslinger_Area_04_Perk_1,
		Gunslinger_Area_04_Perk_2,
		Gunslinger_Area_04_Perk_3,
		Gunslinger_Area_05_Perk_1,
		Gunslinger_Area_05_Perk_2,
		Gunslinger_Area_06_Perk_1,
		Gunslinger_Area_06_Perk_2,
		Gunslinger_Area_07_Perk_1,
		Gunslinger_Area_07_Perk_2,
		Gunslinger_Area_08_Perk_1,
		Gunslinger_Area_08_Perk_2,
		Gunslinger_Area_09_Perk_1,
		Gunslinger_Area_10_Perk_1,
		Hacking_Area_01_Perk_1,
		Hacking_Area_01_Perk_2,
		Hacking_Area_02_Perk_1,
		Hacking_Area_02_Perk_2,
		Hacking_Area_03_Perk_1,
		Hacking_Area_03_Perk_2,
		Hacking_Area_04_Perk_1,
		Hacking_Area_04_Perk_2,
		Hacking_Area_05_Perk_1,
		Hacking_Area_06_Perk_1,
		Hacking_Area_06_Perk_2,
		Hacking_Area_07_Perk_1,
		Hacking_Area_07_Perk_2,
		Hacking_Area_08_Perk_1,
		Hacking_Area_08_Perk_2,
		Hacking_Area_09_Perk_1,
		Hacking_Area_09_Perk_2,
		Hacking_Area_10_Perk_1,
		Hacking_Area_10_Perk_2,
		Kenjutsu_Area_01_Perk_1,
		Kenjutsu_Area_01_Perk_2,
		Kenjutsu_Area_02_Perk_1,
		Kenjutsu_Area_02_Perk_2,
		Kenjutsu_Area_03_Perk_1,
		Kenjutsu_Area_03_Perk_2,
		Kenjutsu_Area_04_Perk_1,
		Kenjutsu_Area_04_Perk_2,
		Kenjutsu_Area_05_Perk_1,
		Kenjutsu_Area_05_Perk_2,
		Kenjutsu_Area_06_Perk_1,
		Kenjutsu_Area_06_Perk_2,
		Kenjutsu_Area_07_Perk_1,
		Kenjutsu_Area_07_Perk_2,
		Kenjutsu_Area_08_Perk_1,
		Kenjutsu_Area_08_Perk_2,
		Stealth_Area_01_Perk_1,
		Stealth_Area_01_Perk_2,
		Stealth_Area_02_Perk_1,
		Stealth_Area_02_Perk_2,
		Stealth_Area_02_Perk_3,
		Stealth_Area_03_Perk_1,
		Stealth_Area_03_Perk_2,
		Stealth_Area_03_Perk_3,
		Stealth_Area_04_Perk_1,
		Stealth_Area_04_Perk_2,
		Stealth_Area_05_Perk_1,
		Stealth_Area_05_Perk_2,
		Stealth_Area_05_Perk_3,
		Stealth_Area_06_Perk_1,
		Stealth_Area_06_Perk_2,
		Stealth_Area_07_Perk_1,
		Stealth_Area_07_Perk_2,
		Stealth_Area_07_Perk_3,
		Stealth_Area_08_Perk_1,
		Stealth_Area_08_Perk_2,
		Stealth_Area_08_Perk_3,
		Stealth_Area_09_Perk_1,
		Stealth_Area_09_Perk_2,
		Stealth_Area_09_Perk_3,
		Stealth_Area_10_Perk_1,
		Count,
		Invalid
	}

	public enum gamedataPerkUtility
	{
		ActiveUtility,
		PassiveUtility,
		TriggeredUtility,
		Count,
		Invalid
	}

	public enum gamedataPingType
	{
		Device,
		Door,
		Elevator,
		Junction,
		Location,
		Loot,
		Trap,
		Count,
		Invalid
	}

	public enum gamedataPlayerBuild
	{
		Cool,
		Netrunner,
		Reflexes,
		Solo,
		Techie,
		Count,
		Invalid
	}

	public enum gamedataPlayerPossesion
	{
		Default,
		Johnny,
		Count,
		Invalid
	}

	public enum gamedataProficiencyType
	{
		Assault,
		Athletics,
		Brawling,
		ColdBlood,
		CombatHacking,
		Crafting,
		Demolition,
		Engineering,
		Gunslinger,
		Hacking,
		Kenjutsu,
		Level,
		Stealth,
		StreetCred,
		Count,
		Invalid
	}

	public enum gamedataProjectileLaunchMode
	{
		Regular,
		Tracking,
		Count,
		Invalid
	}

	public enum gamedataProjectileOnCollisionAction
	{
		Bounce,
		Pierce,
		Stop,
		StopAndStick,
		StopAndStickPerpendicular,
		Count,
		Invalid
	}

	public enum gamedataQuality
	{
		Common,
		Epic,
		Iconic,
		Legendary,
		Random,
		Rare,
		Uncommon,
		Count,
		Invalid
	}

	public enum gamedataReactionPresetType
	{
		Child,
		Civilian_Guard,
		Civilian_Neutral,
		Civilian_Passive,
		Corpo_Aggressive,
		Corpo_Passive,
		Follower,
		Ganger_Aggressive,
		Ganger_Passive,
		InVehicle_Aggressive,
		InVehicle_Civilian,
		InVehicle_Passive,
		Lore_Aggressive,
		Lore_Civilian,
		Lore_Passive,
		Mechanical_Aggressive,
		Mechanical_NonCombat,
		Mechanical_Passive,
		NoReaction,
		Police_Aggressive,
		Police_Passive,
		Sleep_Aggressive,
		Sleep_Civilian,
		Sleep_Passive,
		Count,
		Invalid
	}

	public enum gamedataSenseObjectType
	{
		Camera,
		Deadbody,
		Follower,
		Npc,
		Player,
		Turret,
		Undefined,
		Count,
		Invalid
	}

	public enum gamedataSimpleValueNodeValueType
	{
		String,
		Number,
		Bool,
		Ident
	}

	public enum gamedataSpawnableObjectPriority
	{
		Crowd,
		Quest,
		Regular,
		Count,
		Invalid
	}

	public enum gamedataStatPoolType
	{
		Adrenaline,
		Aggressiveness,
		BleedingTrigger,
		BurningTrigger,
		CPUPower,
		CallReinforcementProgress,
		Durability,
		E3_BossWeakSpotHealth,
		ElectrocutedTrigger,
		Fear,
		Health,
		LeftArmHealth,
		LeftLegHealth,
		Memory,
		Oxygen,
		PhoneCallDuration,
		PoisonTrigger,
		QuickHackDuration,
		QuickHackUpload,
		ReprimandEscalation,
		RightLegHealth,
		Stamina,
		StunTrigger,
		UnlockProgress,
		WeakspotHealth,
		WeaponCharge,
		WeaponOverheat,
		CPOShockedTrigger,
		CPO_Armor,
		CPO_NPC_Importance,
		Count,
		Invalid
	}
	public enum gamedataStatType
	{
		Acceleration,
		Accuracy,
		Adrenaline,
		AimFOV,
		AimInTime,
		AimOffset,
		AimOutTime,
		AllowMovementInput,
		AllowRotation,
		Armor,
		Assault,
		AssaultMastery,
		AssaultTrait01Stat,
		Athletics,
		AthleticsMastery,
		AthleticsTrait01Stat,
		AttackPenetration,
		AttackSpeed,
		AttackSpeedPercent,
		AttacksNumber,
		AttacksPerSecond,
		AttacksPerSecondBase,
		AudioLocomotionStimRangeMultiplier,
		AudioStimRangeMultiplier,
		AutoReveal,
		AutocraftDuration,
		AutomaticReplenishment,
		AutomaticUploadPerk,
		BaseChargeTime,
		BaseDamage,
		BaseDamageMax,
		BaseDamageMin,
		BerserkArmorBonus,
		BerserkCooldownBase,
		BerserkCooldownReduction,
		BerserkDurationBase,
		BerserkHealthRegenBonus,
		BerserkMeleeDamageBonus,
		BerserkRecoilReduction,
		BerserkResistancesBonus,
		BerserkShockwaveDamage,
		BerserkShockwaveRangeBonus,
		BerserkSwayReduction,
		BleedingApplicationRate,
		BleedingImmunity,
		BlindImmunity,
		BlindResistance,
		BlockFactor,
		BlockLocomotionWhenLeaningOutOfCover,
		BlockReduction,
		BonusChargeDamage,
		BonusDPS,
		BonusDamageAgainstElites,
		BonusDamageAgainstMechanicals,
		BonusDamageAgainstRares,
		BonusQuickHackDamage,
		BonusRicochetDamage,
		Brake,
		BrakeDot,
		Brawling,
		BrawlingMastery,
		BrawlingTrait01Stat,
		BufferSize,
		BulletMagnetismDefaultAngle,
		BulletMagnetismHighVelocityAngle,
		BurningApplicationRate,
		BurningImmunity,
		BurningRegenStamina,
		CPUPower,
		CallReinforcement,
		CameraShutdownExtension,
		CanAerialTakedown,
		CanAimWhileDodging,
		CanAskToFollowOrder,
		CanAskToHolsterWeapon,
		CanAutomaticallyDisassembleJunk,
		CanAutomaticallyRestoreKnives,
		CanBleedingCriticallyHit,
		CanBleedingSlowTarget,
		CanBlindQuickHack,
		CanBlock,
		CanBreatheUnderwater,
		CanBuffCamoQuickHack,
		CanBuffMechanicalsOnTakeControl,
		CanBuffSturdinessQuickHack,
		CanBurningCriticallyHit,
		CanCallDrones,
		CanCallReinforcements,
		CanCatchUp,
		CanCatchUpDistance,
		CanCharge,
		CanChargedShoot,
		CanCloseCombat,
		CanCommsCallInQuickHack,
		CanCommsCallOutQuickHack,
		CanCommsNoiseQuickHack,
		CanControlFullyChargedWeapon,
		CanCraftEpicItems,
		CanCraftFromInventory,
		CanCraftLegendaryItems,
		CanCraftRareItems,
		CanCraftTechAmmunition,
		CanCrouch,
		CanCyberwareMalfunctionQuickHack,
		CanDash,
		CanDataMineQuickHack,
		CanDealFullDamageToArmored,
		CanDeathQuickHack,
		CanDisassemble,
		CanDisassembleConsumables,
		CanDisassembleGadgets,
		CanDropWeapon,
		CanElectrocuteNullifyStats,
		CanElectrocuteRoot,
		CanExitWSOnSoundStimuli,
		CanExplodeQuickHack,
		CanFastTravelWhileEncumbered,
		CanFullyChargeWeapon,
		CanGrab,
		CanGrappleAndroids,
		CanGrappleSilently,
		CanGrenadeLaunch,
		CanGrenadeQuickHack,
		CanGrenadesCriticallyHit,
		CanGrenadesDealExternalDamage,
		CanGuardBreak,
		CanHeartattackQuickHack,
		CanIgnoreArmorDamageReduction,
		CanIgnoreStamina,
		CanInstallTechMods,
		CanJamWeaponQuickHack,
		CanJump,
		CanLandSilently,
		CanLegendaryCraftedWeaponsBeBoosted,
		CanLocomotionMalfunctionQuickHack,
		CanMadnessQuickHack,
		CanMalfunctionQuickHack,
		CanMeleeBerserk,
		CanMeleeDash,
		CanMeleeInfinitelyCombo,
		CanMeleeLeap,
		CanMeleeLeapTakedown,
		CanOverchargeWeapon,
		CanOverheatQuickHack,
		CanOverloadQuickHack,
		CanOverrideAttitudeQuickHack,
		CanOverrideAuthorizationQuickHack,
		CanParry,
		CanPickUpBodyAfterTakedown,
		CanPickUpWeapon,
		CanPingQuickHack,
		CanPlayerBoostConsumables,
		CanPlayerBoostGrenades,
		CanPoisonLowerArmor,
		CanPoisonSlow,
		CanPreciseShoot,
		CanPushBack,
		CanPushFromGrapple,
		CanQuickHackCriticallyHit,
		CanQuickMeleeStagger,
		CanQuickhack,
		CanQuickhackHealPuppet,
		CanQuickhackTransferBetweenEnemies,
		CanRegenInCombat,
		CanRemoveModsFromClothing,
		CanRemoveModsFromWeapons,
		CanResurrectAllies,
		CanRetrieveModsFromDisassemble,
		CanRunSilently,
		CanSandevistanSprintHarass,
		CanScrapPartsFromMechanicals,
		CanSeeGrenadeRadius,
		CanSeeRicochetVisuals,
		CanSeeThroughWalls,
		CanShareThreatsWithPlayer,
		CanShootWhileCarryingBody,
		CanShootWhileDodging,
		CanShootWhileGrappling,
		CanShootWhileMoving,
		CanShootWhileVaulting,
		CanSilentKill,
		CanSmartShoot,
		CanSprint,
		CanSprintHarass,
		CanSprintWhileCarryingBody,
		CanSuicideQuickHack,
		CanSwitchWeapon,
		CanTakeControlQuickHack,
		CanTakedownLethally,
		CanTakedownSilently,
		CanTaunt,
		CanThrowWeapon,
		CanUpgradeFromInventory,
		CanUpgradeToLegendaryQuality,
		CanUseAntiStun,
		CanUseBiohazardGrenades,
		CanUseCloseRing,
		CanUseCombatStims,
		CanUseConsumables,
		CanUseCoolingSystem,
		CanUseCovers,
		CanUseCuttingGrenades,
		CanUseEMPGrenades,
		CanUseExtremeRing,
		CanUseFarRing,
		CanUseFlashbangGrenades,
		CanUseFragGrenades,
		CanUseGrenades,
		CanUseHolographicCamo,
		CanUseIncendiaryGrenades,
		CanUseLeftHand,
		CanUseLegs,
		CanUseMantisBlades,
		CanUseMediumRing,
		CanUseMeleeRing,
		CanUseOpticalCamo,
		CanUsePainInhibitors,
		CanUsePersonalSoundSilencer,
		CanUseProjectileLauncher,
		CanUseReconGrenades,
		CanUseRetractableShield,
		CanUseRightHand,
		CanUseShootingSpots,
		CanUseStaticCamo,
		CanUseStrongArms,
		CanUseTakedowns,
		CanUseTerrainCamo,
		CanUseZoom,
		CanWalkSilently,
		CanWallStick,
		CanWeaponBlock,
		CanWeaponBlockAttack,
		CanWeaponComboAttack,
		CanWeaponCriticallyHit,
		CanWeaponCrouchAttack,
		CanWeaponDash,
		CanWeaponDeflect,
		CanWeaponIgnoreArmor,
		CanWeaponInfinitlyCombo,
		CanWeaponJumpAttack,
		CanWeaponLeap,
		CanWeaponMalfunctionQuickHack,
		CanWeaponReload,
		CanWeaponReloadWhileInactive,
		CanWeaponReloadWhileSliding,
		CanWeaponReloadWhileSprinting,
		CanWeaponReloadWhileVaulting,
		CanWeaponSafeAttack,
		CanWeaponShoot,
		CanWeaponShootWhileSliding,
		CanWeaponShootWhileSprinting,
		CanWeaponShootWhileVaulting,
		CanWeaponSnapToLimbs,
		CanWeaponSprintAttack,
		CanWeaponStrongAttack,
		CanWeaponTriggerHeadshot,
		CannotBeDetectedWhileSubmerged,
		CannotBeHealed,
		CannotSprintHarass,
		CarryCapacity,
		CausingPanicReducesUltimateHacksCost,
		Charge,
		ChargeDischargeTime,
		ChargeFullMultiplier,
		ChargeMaxTimeInChargedState,
		ChargeMultiplier,
		ChargeReadyPercentage,
		ChargeShouldFireWhenReady,
		ChargeTime,
		ChemicalDamage,
		ChemicalDamageMax,
		ChemicalDamageMin,
		ChemicalDamagePercent,
		ChemicalResistance,
		ClimbSpeedModifier,
		ClipTimesCycle,
		ClipTimesCycleBase,
		ClipTimesCyclePlusReload,
		ClipTimesCyclePlusReloadBase,
		CloudComputingTraps,
		ColdBlood,
		ColdBloodBuffBonus,
		ColdBloodMastery,
		ColdBloodMaxDuration,
		ColdBloodMaxStacks,
		ColdBloodTrait01,
		CombatHacking,
		CombatHackingMastery,
		CommsNoiseJamOnQuickhack,
		Cool,
		Crafting,
		CraftingBonusArmorValue,
		CraftingBonusConsumableDuration,
		CraftingBonusGrenadeDamage,
		CraftingBonusWeaponDamage,
		CraftingCostReduction,
		CraftingItemLevelBoost,
		CraftingMastery,
		CraftingMaterialDropChance,
		CraftingMaterialRandomGrantChance,
		CraftingMaterialRetrieveChance,
		CraftingTrait01,
		CritChance,
		CritChanceTimeCritDamage,
		CritDPSBonus,
		CritDamage,
		CyberwareCooldownReduction,
		CycleTime,
		CycleTimeAimBlockDuration,
		CycleTimeAimBlockStart,
		CycleTimeBase,
		CycleTimeBonus,
		CycleTimeShootingMult,
		CycleTimeShootingMultPeriod,
		CycleTime_Burst,
		CycleTime_BurstMaxCharge,
		CycleTime_BurstSecondary,
		CycleTriggerModeTime,
		DPS,
		DamageFalloffDisabled,
		DamageHackSpread,
		DamagePerHit,
		DamageReductionDamageOverTime,
		DamageReductionExplosion,
		DashAttackStaminaCostReduction,
		DataLeakTraps,
		DealsChemicalDamage,
		DealsElectricDamage,
		DealsPhysicalDamage,
		DealsThermalDamage,
		Deceleration,
		DefeatedHeadDamageThreshold,
		DefeatedLArmDamageThreshold,
		DefeatedLLegDamageThreshold,
		DefeatedRArmDamageThreshold,
		DefeatedRLegDamageThreshold,
		DefeatingEnemiesReduceHacksCost,
		Demolition,
		DemolitionMastery,
		DemolitionTrait01Stat,
		Detection,
		DeviceMemoryCostReduction,
		DisableCyberwareOnBurning,
		DisassemblingIngredientsDoubleBonus,
		DisassemblingMaterialQualityObtainChance,
		DismHeadDamageThreshold,
		DismLArmDamageThreshold,
		DismLLegDamageThreshold,
		DismRArmDamageThreshold,
		DismRLegDamageThreshold,
		DoNotCheckFriendlyFireMadnessPassive,
		DummyResistanceStat,
		Durability,
		DurationBonusBleeding,
		DurationBonusBurning,
		DurationBonusElectrified,
		DurationBonusPoisoned,
		DurationBonusQuickhack,
		DurationBonusStun,
		EMPImmunity,
		EffectiveDPS,
		EffectiveDamagePerHit,
		EffectiveDamagePerHitMax,
		EffectiveDamagePerHitMin,
		EffectiveDamagePerHitTimesAttacksPerSecond,
		EffectiveRange,
		ElectricDamage,
		ElectricDamageMax,
		ElectricDamageMin,
		ElectricDamagePercent,
		ElectricResistance,
		ElectrocuteImmunity,
		ElectrocutedApplicationRate,
		ElementalDamagePerHit,
		ElementalResistanceMultiplier,
		EmptyReloadTime,
		Engineering,
		EngineeringMastery,
		EngineeringTrait01,
		EquipActionDuration_Corpo,
		EquipActionDuration_Gang,
		EquipAnimationDuration_Corpo,
		EquipAnimationDuration_Gang,
		EquipDuration,
		EquipDuration_First,
		EquipItemTime_Corpo,
		EquipItemTime_Gang,
		Evasion,
		ExplosionKillsRecudeUltimateHacksCost,
		FFInputLock,
		FallDamageReduction,
		FearOnQuickHackKill,
		FullAutoOnFullCharge,
		Gunslinger,
		GunslingerMastery,
		GunslingerTrait01Stat,
		HackedEnemiesGetDamagedByFriendlyFire,
		HackedEnemyArmorReduction,
		Hacking,
		HackingMastery,
		HackingPenetration,
		HackingResistance,
		HackingResistanceUltimate,
		HasAdditionalSplinterSlot,
		HasAheadTargeting,
		HasAirHover,
		HasAirThrusters,
		HasAutoReloader,
		HasAutomaticReplenishment,
		HasAutomaticTagging,
		HasBerserk,
		HasBleedImmunity,
		HasBlindImmunity,
		HasBoostedCortex,
		HasBurningBuffs,
		HasCameraLinking,
		HasChargeJump,
		HasCritImmunity,
		HasCyberdeck,
		HasCybereye,
		HasDodge,
		HasDodgeAir,
		HasDoubleJump,
		HasElectricCoating,
		HasElectroPlating,
		HasExtendedHitReactionImmunity,
		HasFireproofSkin,
		HasGPS,
		HasGlowingTattoos,
		HasGraphiteTissue,
		HasHackingInteractions,
		HasHealingReapplication,
		HasHealthMonitorBomb,
		HasHostileHackImmunity,
		HasICELevelBooster,
		HasInfravision,
		HasJuiceInjector,
		HasKerenzikov,
		HasKerenzikovSlide,
		HasKers,
		HasLinkToBountySystem,
		HasLoweringPerception,
		HasMadnessLvl4Passive,
		HasMajorQuickhackResistance,
		HasMechanicalControl,
		HasMeleeImmunity,
		HasMeleeTargeting,
		HasMetabolicEnhancer,
		HasPoisonHeal,
		HasPoisonImmunity,
		HasPowerGrip,
		HasQuickhackResistance,
		HasRemoteBotAccessPointBreach,
		HasSandevistan,
		HasSandevistanTier1,
		HasSandevistanTier2,
		HasSandevistanTier3,
		HasSecondHeart,
		HasSelfHealingSkin,
		HasSmartLink,
		HasSpiderBotControl,
		HasStunImmunity,
		HasSubdermalArmor,
		HasSuperheroFall,
		HasThermovision,
		HasTimedImmunity,
		HasToxicCleanser,
		HasWallRunSkill,
		HeadshotDamageMultiplier,
		HeadshotImmunity,
		Health,
		HealthInCombatRegenDelayOnChange,
		HealthInCombatRegenEnabled,
		HealthInCombatRegenEndThreshold,
		HealthInCombatRegenRate,
		HealthInCombatRegenRateAdd,
		HealthInCombatRegenRateBase,
		HealthInCombatRegenRateMult,
		HealthInCombatRegenStartThreshold,
		HealthInCombatStartDelay,
		HealthMonitorCooldownDuration,
		HealthOutOfCombatRegenDelayOnChange,
		HealthOutOfCombatRegenEnabled,
		HealthOutOfCombatRegenEndThreshold,
		HealthOutOfCombatRegenRate,
		HealthOutOfCombatRegenRateAdd,
		HealthOutOfCombatRegenRateBase,
		HealthOutOfCombatRegenRateMult,
		HealthOutOfCombatRegenStartThreshold,
		Hearing,
		HeavyAttacksNumber,
		HighlightAccessPoint,
		HitDismembermentFactor,
		HitReactionDamageHealthFactor,
		HitReactionFactor,
		HitTimerAfterDefeated,
		HitTimerAfterImpact,
		HitTimerAfterImpactMelee,
		HitTimerAfterKnockdown,
		HitTimerAfterPain,
		HitTimerAfterStagger,
		HitTimerAfterStaggerMelee,
		HitWoundsFactor,
		HoldDuration,
		HoldEnterDuration,
		HoldTimeoutDuration,
		HolographicSkinCooldownDuration,
		HolographicSkinDuration,
		IconicItemUpgraded,
		ImpactDamageThreshold,
		ImpactDamageThresholdImpulse,
		ImpactDamageThresholdInCover,
		Intelligence,
		IsAggressive,
		IsBalanced,
		IsBlocking,
		IsCautious,
		IsDefensive,
		IsDeflecting,
		IsDodgeStaminaFree,
		IsDodging,
		IsFastMeleeArchetype,
		IsFastRangedArchetype,
		IsGenericMeleeArchetype,
		IsGenericRangedArchetype,
		IsHeavyRangedArchetype,
		IsInvulnerable,
		IsItemBroken,
		IsItemCracked,
		IsItemCrafted,
		IsItemIconic,
		IsItemUpgraded,
		IsManBig,
		IsManMassive,
		IsMechanical,
		IsNetrunnerArchetype,
		IsNotSlowedDuringADS,
		IsNotSlowedDuringBlock,
		IsNotSlowedDuringReload,
		IsReckless,
		IsShotgunnerArchetype,
		IsSniperArchetype,
		IsSprintStaminaFree,
		IsStrongMeleeArchetype,
		IsTechieArchetype,
		IsTier1Archetype,
		IsTier2Archetype,
		IsTier3Archetype,
		IsTier4Archetype,
		IsWeakspot,
		IsWeaponLethal,
		ItemArmor,
		ItemLevel,
		ItemRequiresElectroPlating,
		ItemRequiresPowerGrip,
		ItemRequiresSmartLink,
		JumpHeight,
		Kenjutsu,
		KenjutsuMastery,
		KenjutsuTrait01Stat,
		KnockdownDamageThreshold,
		KnockdownDamageThresholdImpulse,
		KnockdownDamageThresholdInCover,
		KnockdownImmunity,
		KnockdownImpulse,
		Level,
		LimbHealth,
		LinearDirectionUpdateMax,
		LinearDirectionUpdateMaxADS,
		LinearDirectionUpdateMin,
		LinearDirectionUpdateMinADS,
		LowerActiveCooldownOnDefeat,
		LowerHackingResistanceOnHack,
		MagazineCapacity,
		MagazineCapacityBase,
		MagazineCapacityBonus,
		MaxDuration,
		MaxPercentDamageTakenPerHit,
		MaxSpeed,
		MaxStacks,
		MaxStacksBonusBleeding,
		MaxStacksBonusBurning,
		MechanicalsBuffDPSBonus,
		MeleeAttackDuration,
		Memory,
		MemoryCostModifier,
		MemoryCostReduction,
		MemoryInCombatRegenDelayOnChange,
		MemoryInCombatRegenEnabled,
		MemoryInCombatRegenEndThreshold,
		MemoryInCombatRegenRate,
		MemoryInCombatRegenRateAdd,
		MemoryInCombatRegenRateBase,
		MemoryInCombatRegenRateMult,
		MemoryInCombatRegenStartThreshold,
		MemoryInCombatStartDelay,
		MemoryOutOfCombatRegenDelayOnChange,
		MemoryOutOfCombatRegenEnabled,
		MemoryOutOfCombatRegenEndThreshold,
		MemoryOutOfCombatRegenRate,
		MemoryOutOfCombatRegenRateAdd,
		MemoryOutOfCombatRegenRateBase,
		MemoryOutOfCombatRegenRateMult,
		MemoryOutOfCombatRegenStartThreshold,
		MemoryOutOfCombatStartDelay,
		MemoryTrackerCooldownDuration,
		MinSpeed,
		MinigameBufferExtension,
		MinigameMaterialsEarned,
		MinigameMemoryRegenPerk,
		MinigameMoneyMultiplier,
		MinigameNextInstanceBufferExtensionPerk,
		MinigameShardChanceMultiplier,
		MinigameTimeLimitExtension,
		MinigameTrapsPossibilityChance,
		NPCAnimationTime,
		NPCCorpoEquipItemDuration,
		NPCCorpoUnequipItemDuration,
		NPCDamage,
		NPCEquipItemDuration,
		NPCGangEquipItemDuration,
		NPCGangUnequipItemDuration,
		NPCLoopDuration,
		NPCRecoverDuration,
		NPCStartupDuration,
		NPCUnequipItemDuration,
		NPCUploadTime,
		NoJam,
		NumShotsInBurst,
		NumShotsInBurstMaxCharge,
		NumShotsInBurstSecondary,
		NumShotsToFire,
		NumberIgnoredTraps,
		Overheat,
		Oxygen,
		PartArmor,
		PenetrationHealth,
		PersonalityAggressive,
		PersonalityCuriosity,
		PersonalityDisgust,
		PersonalityFear,
		PersonalityFunny,
		PersonalityJoy,
		PersonalitySad,
		PersonalityShock,
		PersonalitySurprise,
		PhoneCallDuration,
		PhysicalDamage,
		PhysicalDamageMax,
		PhysicalDamageMin,
		PhysicalDamagePercent,
		PhysicalImpulse,
		PhysicalResistance,
		PoisonImmunity,
		PoisonRegenHealth,
		PoisonedApplicationRate,
		PowerLevel,
		PreFireTime,
		PrefersCovers,
		PrefersShootingSpots,
		Price,
		ProjectilesPerShot,
		ProjectilesPerShotBase,
		ProjectilesPerShotBonus,
		Quality,
		Quantity,
		QuickHackDuration,
		QuickHackDurationExtension,
		QuickHackImmunity,
		QuickHackResistancesMod,
		QuickHackSpreadDistance,
		QuickHackSpreadNumber,
		QuickHackSuddenDeathChance,
		QuickHackUpload,
		QuickhackExtraDamageMultiplier,
		QuickhackShield,
		QuickhacksCooldownReduction,
		RandomCurveInput,
		Range,
		Recoil,
		RecoilAllowSway,
		RecoilAlternateDir,
		RecoilAlternateDirADS,
		RecoilAngle,
		RecoilAngleADS,
		RecoilAnimation,
		RecoilChargeMult,
		RecoilChargeMultADS,
		RecoilCycleSize,
		RecoilCycleSizeADS,
		RecoilCycleTime,
		RecoilCycleTimeADS,
		RecoilDelay,
		RecoilDir,
		RecoilDirADS,
		RecoilDirPlanCycleRandDir,
		RecoilDirPlanCycleRandDirADS,
		RecoilDirPlanCycleRandRangeDir,
		RecoilDirPlanCycleRandRangeDirADS,
		RecoilDirPlanSequence,
		RecoilDirPlanSequenceADS,
		RecoilDriftRandomRangeMax,
		RecoilDriftRandomRangeMin,
		RecoilEnableCycleX,
		RecoilEnableCycleXADS,
		RecoilEnableCycleY,
		RecoilEnableCycleYADS,
		RecoilEnableLinearX,
		RecoilEnableLinearXADS,
		RecoilEnableLinearY,
		RecoilEnableLinearYADS,
		RecoilEnableScaleX,
		RecoilEnableScaleXADS,
		RecoilEnableScaleY,
		RecoilEnableScaleYADS,
		RecoilFullChargeMult,
		RecoilFullChargeMultADS,
		RecoilHoldDuration,
		RecoilHoldDurationADS,
		RecoilKickMax,
		RecoilKickMaxADS,
		RecoilKickMin,
		RecoilKickMinADS,
		RecoilMagForFullDrift,
		RecoilMaxLength,
		RecoilMaxLengthADS,
		RecoilRecoveryMinSpeed,
		RecoilRecoveryMinSpeedADS,
		RecoilRecoverySpeed,
		RecoilRecoverySpeedADS,
		RecoilRecoveryTime,
		RecoilRecoveryTimeADS,
		RecoilScaleMax,
		RecoilScaleMaxADS,
		RecoilScaleTime,
		RecoilScaleTimeADS,
		RecoilSpeed,
		RecoilSpeedADS,
		RecoilTime,
		RecoilTimeADS,
		RecoilUseDifferentStatsInADS,
		Reflexes,
		RefreshesPingOnQuickhack,
		RegenerateHPMinigamePerk,
		ReloadAmount,
		ReloadEndTime,
		ReloadTime,
		ReloadTimeBase,
		ReloadTimeBonus,
		RemoveAllStacksWhenDurationEnds,
		RemoveColdBloodStacksOneByOne,
		RemoveSprintOnQuickhack,
		ReprimandEscalation,
		RestoreMemoryOnDefeat,
		RevealNetrunnerWhenHacked,
		RicochetChance,
		RicochetCount,
		RicochetMaxAngle,
		RicochetMinAngle,
		RicochetTargetSearchAngle,
		SandevistanDashShoot,
		ScanDepth,
		ScanTimeReduction,
		ScopeFOV,
		ScopeOffset,
		ScrapItemChance,
		SharedCacheTraps,
		ShootingOffsetAI,
		ShortCircuitOnCriticalHit,
		ShorterChains,
		ShotDelay,
		SlideWhenLeaningOutOfCover,
		SmartGunAddSpiralTrajectory,
		SmartGunAdsLockingAnglePitch,
		SmartGunAdsLockingAngleYaw,
		SmartGunAdsMaxLockedTargets,
		SmartGunAdsTagLockAnglePitch,
		SmartGunAdsTagLockAngleYaw,
		SmartGunAdsTargetableAnglePitch,
		SmartGunAdsTargetableAngleYaw,
		SmartGunAdsTimeToLock,
		SmartGunAdsTimeToUnlock,
		SmartGunEvenDistributionPeriod,
		SmartGunHipLockingAnglePitch,
		SmartGunHipLockingAngleYaw,
		SmartGunHipMaxLockedTargets,
		SmartGunHipTagLockAnglePitch,
		SmartGunHipTagLockAngleYaw,
		SmartGunHipTargetableAnglePitch,
		SmartGunHipTargetableAngleYaw,
		SmartGunHipTimeToLock,
		SmartGunHipTimeToUnlock,
		SmartGunHitProbability,
		SmartGunHitProbabilityMultiplier,
		SmartGunMissDelay,
		SmartGunMissRadius,
		SmartGunNPCApplySpreadAtHitplane,
		SmartGunNPCLockOnTime,
		SmartGunNPCLockTimeout,
		SmartGunNPCLockingAnglePitch,
		SmartGunNPCLockingAngleYaw,
		SmartGunNPCProjectileStartingOrientationAngleOffset,
		SmartGunNPCProjectileVelocity,
		SmartGunNPCShootProjectilesOnlyStraight,
		SmartGunNPCSpreadMultiplier,
		SmartGunNPCTrajectoryCurvatureMultiplier,
		SmartGunPlayerProjectileVelocity,
		SmartGunProjectileVelocityVariance,
		SmartGunSpiralCycleTimeMax,
		SmartGunSpiralCycleTimeMin,
		SmartGunSpiralRadius,
		SmartGunSpiralRampDistanceEnd,
		SmartGunSpiralRampDistanceStart,
		SmartGunSpiralRandomizeDirection,
		SmartGunSpreadMultiplier,
		SmartGunStartingAccuracy,
		SmartGunTargetAcquisitionRange,
		SmartGunTimeToMaxAccuracy,
		SmartGunTimeToRemoveOccludedTarget,
		SmartGunTrackAllBodyparts,
		SmartGunTrackHeadComponents,
		SmartGunTrackLegComponents,
		SmartGunTrackMechanicalComponents,
		SmartGunTrackMultipleEntitiesInADS,
		SmartGunUseEvenDistributionTargeting,
		SmartGunUseTagLockTargeting,
		SmartGunUseTimeBasedAccuracy,
		SmartTargetingDisruptionProbability,
		SpecialDamage,
		SpeedBoost,
		SpeedBoostMaxSpeed,
		Spread,
		SpreadAdsChangePerShot,
		SpreadAdsChargeMult,
		SpreadAdsDefaultX,
		SpreadAdsDefaultY,
		SpreadAdsFastSpeedMax,
		SpreadAdsFastSpeedMaxAdd,
		SpreadAdsFastSpeedMin,
		SpreadAdsFastSpeedMinAdd,
		SpreadAdsFullChargeMult,
		SpreadAdsMaxX,
		SpreadAdsMaxY,
		SpreadAdsMinX,
		SpreadAdsMinY,
		SpreadAnimation,
		SpreadChangePerShot,
		SpreadChargeMult,
		SpreadCrouchDefaultMult,
		SpreadCrouchMaxMult,
		SpreadDefaultX,
		SpreadDefaultY,
		SpreadEvenDistributionJitterSize,
		SpreadEvenDistributionRowCount,
		SpreadFastSpeedMax,
		SpreadFastSpeedMaxAdd,
		SpreadFastSpeedMin,
		SpreadFastSpeedMinAdd,
		SpreadFullChargeMult,
		SpreadMaxAI,
		SpreadMaxX,
		SpreadMaxY,
		SpreadMinX,
		SpreadMinY,
		SpreadRandomizeOriginPoint,
		SpreadResetSpeed,
		SpreadResetTimeThreshold,
		SpreadUseCircularSpread,
		SpreadUseEvenDistribution,
		SpreadUseInAds,
		SpreadZeroOnFirstShot,
		StaggerDamageThreshold,
		StaggerDamageThresholdImpulse,
		StaggerDamageThresholdInCover,
		Stamina,
		StaminaCostReduction,
		StaminaCostToBlock,
		StaminaDamage,
		StaminaRegenDelayOnChange,
		StaminaRegenEnabled,
		StaminaRegenEndThrehold,
		StaminaRegenRate,
		StaminaRegenRateAdd,
		StaminaRegenRateBase,
		StaminaRegenRateMult,
		StaminaRegenStartDelay,
		StaminaRegenStartThreshold,
		StaminaSprintDecayRate,
		StatModifierGroupLimit,
		Stealth,
		StealthHacksCostReduction,
		StealthHitDamageMultiplier,
		StealthMastery,
		StealthTrait01Stat,
		StealthWeakspotDamageMultiplier,
		StreetCred,
		Strength,
		StunImmunity,
		Sway,
		SwayCenterMaximumAngleOffset,
		SwayCurvatureMaximumFactor,
		SwayCurvatureMinimumFactor,
		SwayInitialOffsetRandomFactor,
		SwayResetOnAimStart,
		SwaySideBottomAngleLimit,
		SwaySideMaximumAngleDistance,
		SwaySideMinimumAngleDistance,
		SwaySideStepChangeMaximumFactor,
		SwaySideStepChangeMinimumFactor,
		SwaySideTopAngleLimit,
		SwayStartBlendTime,
		SwayStartDelay,
		SwayTraversalTime,
		TBHsBaseCoefficient,
		TBHsBaseSourceMultiplierCoefficient,
		TBHsCoverTraceLoSIncreaseSpeed,
		TBHsMinimumLineOfSightTime,
		TBHsSensesTraceLoSIncreaseSpeed,
		TBHsVisibilityCooldown,
		TechBaseChargeThreshold,
		TechMaxChargeThreshold,
		TechOverChargeThreshold,
		TechPierceChargeLevel,
		TechPierceEnabled,
		TechnicalAbility,
		ThermalDamage,
		ThermalDamageMax,
		ThermalDamageMin,
		ThermalDamagePercent,
		ThermalResistance,
		ThreeOrMoreProgramsCooldownRedPerk,
		ThreeOrMoreProgramsMemoryRegPerk,
		TimeDilationGenericDuration,
		TimeDilationGenericTimeScale,
		TimeDilationKerenzikovDuration,
		TimeDilationKerenzikovPlayerTimeScale,
		TimeDilationKerenzikovTimeScale,
		TimeDilationOnDodgesCooldownDuration,
		TimeDilationOnDodgesDuration,
		TimeDilationOnDodgesTimeScale,
		TimeDilationOnHealthDropCooldownDuration,
		TimeDilationOnHealthDropDuration,
		TimeDilationOnHealthDropTimeScale,
		TimeDilationSandevistanCooldownBase,
		TimeDilationSandevistanCooldownReduction,
		TimeDilationSandevistanDuration,
		TimeDilationSandevistanTimeScale,
		TimeDilationWhenEnteringCombatCooldownDuration,
		TimeDilationWhenEnteringCombatDuration,
		TimeDilationWhenEnteringCombatTimeScale,
		TriggerDismembermentChance,
		TriggerWoundedChance,
		TurretFriendlyExtension,
		TurretShutdownExtension,
		UltimateHackSpread,
		UltimateHacksCostReduction,
		UltimateMemoryCostReduction,
		UnconsciousImmunity,
		UnequipAnimationDuration_Corpo,
		UnequipAnimationDuration_Gang,
		UnequipDuration,
		UnequipDuration_Corpo,
		UnequipDuration_Gang,
		UnequipItemTime_Corpo,
		UnequipItemTime_Gang,
		UnlockProgress,
		UpgradingCostReduction,
		UpgradingMaterialDropChance,
		UpgradingMaterialRandomGrantChance,
		UpgradingMaterialRetrieveChance,
		UploadQuickHackMod,
		Visibility,
		VisualStimRangeMultiplier,
		VulnerabilityExtension,
		WallRunHorSpeedToEnterMin,
		WallRunStrafeAngleMax,
		WallRunTimeMax,
		WallRunVertSpeedToEnterMax,
		WasItemUpgraded,
		WasQuickHacked,
		WeakspotDamageMultiplier,
		WeaponHasAutoloader,
		WeaponNoise,
		WeaponPosAdsX,
		WeaponPosAdsY,
		WeaponPosAdsZ,
		WeaponPosX,
		WeaponPosY,
		WeaponPosZ,
		WeaponRotAdsX,
		WeaponRotAdsY,
		WeaponRotAdsZ,
		WeaponRotX,
		WeaponRotY,
		WeaponRotZ,
		Weight,
		WoundHeadDamageThreshold,
		WoundLArmDamageThreshold,
		WoundLLegDamageThreshold,
		WoundRArmDamageThreshold,
		WoundRLegDamageThreshold,
		ZoomLevel,
		CPO_Armor,
		CPO_NPC_Importance,
		Count,
		Invalid
	}

	public enum gamedataStatusEffectAIBehaviorFlag
	{
		AcceptsAdditives,
		InterruptsForcedBehavior,
		InterruptsSamePriorityTask,
		None,
		OverridesSelf,
		Count,
		Invalid
	}

	public enum gamedataStatusEffectAIBehaviorType
	{
		Basic,
		None,
		Stoppable,
		Unstoppable,
		Count,
		Invalid
	}

	public enum gamedataStatusEffectType
	{
		AndroidTurnOff,
		AndroidTurnOn,
		Berserk,
		Berserker,
		Bleeding,
		Blind,
		BlockCoverVisibilityReduction,
		BrainMelt,
		Burning,
		Cloaked,
		CommsCall,
		CommsNoise,
		Crippled,
		DamageBurst,
		Deafened,
		Defeated,
		DefeatedWithRecover,
		EMP,
		Electrocuted,
		Exhausted,
		ForceShoot,
		Grapple,
		Jam,
		JamCommuniations,
		Kill,
		Knockdown,
		Madness,
		MeleeInvulnerability,
		Misc,
		MuteAudioStims,
		NetwatcherHackStage1,
		NetwatcherHackStage2,
		NetwatcherHackStage3,
		Overheat,
		Overload,
		Pain,
		PassiveBuff,
		PassiveDebuff,
		PlayerCooldown,
		Poisoned,
		QuickHackFreezeLocomotion,
		QuickHackStaggerCyberware,
		QuickHackStaggerLocomotion,
		QuickHackStaggerWeapon,
		Quickhack,
		Regeneration,
		Sandevistan,
		SetFriendly,
		Sleep,
		Stagger,
		StrongArmsActive,
		Stunned,
		SuicideHack,
		SystemCollapse,
		Unconscious,
		UncontrolledMovement,
		VehicleKnockdown,
		WeakspotOverload,
		Wounded,
		CPOShocked,
		Count,
		Invalid
	}

	public enum gamedataStatusEffectVariation
	{
		Bike,
		Default,
		Vehicle,
		Count,
		Invalid
	}

	public enum gamedataStimPriority
	{
		High,
		Low,
		Count,
		Invalid
	}

	public enum gamedataStimPropagation
	{
		Audio,
		Visual,
		Count,
		Invalid
	}

	public enum gamedataStimType
	{
		AimingAt,
		Alarm,
		AreaEffect,
		AskToFollowOrder,
		Attention,
		AudioEnemyPing,
		Bullet,
		Bump,
		Call,
		CarAlarm,
		CarryBody,
		Combat,
		CombatCall,
		CombatHit,
		CombatWhistle,
		CrimeWitness,
		CrowdIllegalAction,
		DeadBody,
		DeviceExplosion,
		Distract,
		DodgeVehicle,
		Driving,
		Dying,
		EnvironmentalHazard,
		Explosion,
		FootStepRegular,
		FootStepSprint,
		GrenadeLanded,
		Gunshot,
		Hacked,
		HijackVehicle,
		IllegalAction,
		IllegalInteraction,
		LandingHard,
		LandingRegular,
		LandingVeryHard,
		MeleeAttack,
		MeleeHit,
		OpeningDoor,
		ProjectileDistraction,
		Provoke,
		Reload,
		Reprimand,
		ReprimandFinalWarning,
		Scream,
		SecurityBreach,
		SilencedGunshot,
		SilentAlarm,
		SoundDistraction,
		SpreadFear,
		StopedAiming,
		Terror,
		TooCloseDistance,
		VehicleHit,
		VehicleHorn,
		VisualDistract,
		WarningDistance,
		WeaponDisplayed,
		WeaponHolstered,
		WeaponSafe,
		Whistle,
		Count,
		Invalid
	}

	public enum gamedataSubCharacter
	{
		Flathead,
		Count,
		Invalid
	}

	public enum gamedataTrackingMode
	{
		BeliefPosition,
		LastKnownPosition,
		RealPosition,
		SharedBeliefPosition,
		SharedLastKnownPosition,
		Count,
		Invalid
	}

	public enum gamedataTraitType
	{
		AssaultTrait01,
		AthleticsTrait01,
		BrawlingTrait01,
		ColdBloodTrait01,
		CombatHackingTrait01,
		CraftingTrait01,
		DemolitionTrait01,
		EngineeringTrait01,
		GunslingerTrait01,
		HackingTrait01,
		KenjutsuTrait01,
		StealthTrait01,
		Count,
		Invalid
	}

	public enum gamedataTriggerMode
	{
		Burst,
		Charge,
		FullAuto,
		Lock,
		SemiAuto,
		Windup,
		Count,
		Invalid
	}

	public enum gamedataTweakDBType
	{
		Invalid,
		ForeignKey,
		Int,
		Float,
		Bool,
		String,
		CName,
		ResRef,
		LocKey,
		Color,
		Vector2,
		Vector3,
		EulerAngles,
		Quaternion
	}

	public enum gamedataUICondition
	{
		InEyesSubMenu,
		InHandsSubMenu,
		InSubMenu,
		Visible,
		Count,
		Invalid
	}

	public enum gamedataUIIconCensorFlag
	{
		Drugs,
		Gore,
		Homosexuality,
		None,
		Nudity,
		OverSexualised,
		Religion,
		Suggestive,
		Count,
		Invalid
	}

	public enum gamedataUINameplateDisplayType
	{
		AfterScan,
		Always,
		Default,
		Never,
		Count,
		Invalid
	}

	public enum gamedataVariableNodeVariableValueDeriveInfo
	{
		NotDerived,
		ArrayAddition
	}

	public enum gamedataVehicleManufacturer
	{
		Arch,
		Archer,
		Aurochs,
		Brennan,
		Chevillon,
		Delamain,
		Herrera,
		Kaukaz,
		Makigai,
		Militech,
		Mizutani,
		Porsche,
		Quadra,
		Rayfield,
		Seamurai,
		Thorton,
		Villefort,
		Yaiba,
		Zetatech,
		Count,
		Invalid
	}

	public enum gamedataVehicleModel
	{
		Aerondight,
		Alvarado,
		Basilisk,
		Bratsk,
		Colby,
		Columbus,
		Cortes,
		Emperor,
		Galena,
		GalenaNomad,
		Kusanagi,
		Mackinaw,
		Maimai,
		Octant,
		Shion,
		Supron,
		Thrax,
		Turbo,
		Type66,
		Zeya,
		Count,
		Invalid
	}

	public enum gamedataVehicleType
	{
		Bike,
		Car,
		Panzer,
		Count,
		Invalid
	}

	public enum gamedataVendorType
	{
		Armorsmith,
		Clothes,
		Clothing,
		Cyberware,
		Drinks,
		DropPoint,
		Food,
		GrilledFood,
		Gunsmith,
		Junk,
		Kiosk,
		Market,
		Medical,
		PackedFood,
		RipperDoc,
		SkillTrainer,
		Tech,
		TechJunk,
		VendingMachine,
		Count,
		Invalid
	}

	public enum gamedataWeaponEvolution
	{
		Blade,
		Blunt,
		None,
		Power,
		Smart,
		Tech,
		Count,
		Invalid
	}

	public enum gamedataWeaponManufacturer
	{
		Corporation,
		Street,
		Count,
		Invalid
	}

	public enum gamedataWorkspotActionType
	{
		DeviceInvestigation,
		FearHide,
		LookAround,
		Count,
		Invalid
	}

	public enum gamedataWorkspotCategory
	{
		Any,
		Eating,
		Nervous,
		Sitting,
		Sleeping,
		Smoking,
		Count,
		Invalid
	}

	public enum gamedataWorkspotReactionType
	{
		Anger,
		BumpLeftBack,
		BumpLeftFront,
		BumpRightBack,
		BumpRightFront,
		Curious,
		Fear,
		Count,
		Invalid
	}

	public enum gamedataWorldMapFilter
	{
		All,
		DropPoint,
		FastTravel,
		NoFilter,
		Quest,
		ServicePoint,
		Story,
		Count,
		Invalid
	}

	public enum gamedeviceActionPropertyFlags
	{
		None,
		IsUsedByQuest
	}

	public enum gamedeviceRequestType
	{
		None,
		External,
		Remote,
		Direct,
		Internal
	}

	public enum gameeventsDeathDirection
	{
		Undefined,
		Left,
		Backward,
		Right,
		Forward
	}

	public enum gameinfluenceCollisionTestOutcome
	{
		NoCell,
		Empty,
		Full
	}

	public enum gameinfluenceEBoundingBoxType
	{
		Colider,
		Custom
	}

	public enum gameinfluenceTestLineResult
	{
		Fail,
		Success,
		Unknown
	}

	public enum gameinputActionType
	{
		BUTTON_PRESSED,
		BUTTON_RELEASED,
		BUTTON_HOLD_PROGRESS,
		BUTTON_HOLD_COMPLETE,
		BUTTON_MULTITAP_BEGIN_LAST,
		BUTTON_MULTITAP_END_LAST,
		AXIS_CHANGE,
		RELATIVE_CHANGE,
		TOGGLE_PRESSED,
		TOGGLE_RELEASED,
		REPEAT
	}

	public enum gameinteractionsBumpIntensity
	{
		Invalid,
		Light,
		Medium,
		Heavy,
		Strafe
	}

	public enum gameinteractionsBumpLocation
	{
		Invalid,
		Front,
		Back
	}

	public enum gameinteractionsBumpSide
	{
		Invalid,
		Left,
		Right
	}

	public enum gameinteractionsBumpType
	{
		Workspot,
		Crowd
	}

	public enum gameinteractionsChoiceLookAtType
	{
		Root,
		Slot,
		Orb
	}

	public enum gameinteractionsChoiceType
	{
		QuestImportant,
		AlreadyRead,
		Inactive,
		CheckSuccess,
		CheckFailed,
		InnerDialog,
		PossessedDialog,
		TimedDialog,
		Blueline,
		Pay,
		Selected,
		Illegal
	}

	public enum gameinteractionsEBinaryOperator
	{
		EBinaryOperator_and,
		EBinaryOperator_or
	}

	public enum gameinteractionsEGroupType
	{
		EGT_default,
		EGT_noInput,
		EGT_hint
	}

	public enum gameinteractionsEInteractionEventType
	{
		EIET_activate,
		EIET_deactivate
	}

	public enum gameinteractionsELookAtTarget
	{
		Entity,
		Component
	}

	public enum gameinteractionsELookAtTest
	{
		Targeting,
		Interaction
	}

	public enum gameinteractionsELootChoiceType
	{
		Available,
		Unavailable,
		Invisible
	}

	public enum gameinteractionsELootVisualiserControlOperation
	{
		Locked
	}

	public enum gameinteractionsEPredicateType
	{
		EPredicateFunction_true,
		EPredicateFunction_distanceFromScreenCentre,
		EPredicateFunction_containedInShapes,
		EPredicateFunction_onScreenTest,
		EPredicateFunction_visibleTarget,
		EPredicateFunction_lookAt,
		EPredicateFunction_lookAtComponent,
		EPredicateFunction_logicalLookAt,
		EPredicateFunction_obstructedLookAt
	}

	public enum gameinteractionsEUnaryOperator
	{
		EUnaryOperator_empty,
		EUnaryOperator_not
	}

	public enum gameinteractionsReactionState
	{
		Idle,
		Starting,
		InInteraction,
		Finishing,
		Canceling
	}

	public enum gameinteractionsvisEVisualizerActivityState
	{
		None,
		Visible,
		Available,
		Active
	}

	public enum gameinteractionsvisEVisualizerDefinitionFlags
	{
		None,
		Fading,
		HeadlineSelection,
		QuestImportant,
		CPO_Mode
	}

	public enum gameinteractionsvisEVisualizerRuntimeFlags
	{
		None,
		Locked,
		Failsafe,
		Dbg_Active
	}

	public enum gameinteractionsvisEVisualizerType
	{
		Device,
		Dialog,
		Loot,
		Invalid
	}

	public enum gameinteractionsvisInteractionType
	{
		LookAt,
		Proximity
	}

	public enum gamemappinsMappinTargetType
	{
		World,
		Minimap,
		Map
	}

	public enum gamemappinsVerticalPositioning
	{
		Above,
		Same,
		Below
	}

	public enum gameprojectileELaunchMode
	{
		Default,
		FromLogic,
		FromVisuals
	}

	public enum gameprojectileOnCollisionAction
	{
		None,
		Stop,
		Bounce,
		StopAndStick,
		StopAndStickPerpendicular,
		Pierce
	}

	public enum gameprojectileParabolicUnknownVariable
	{
		TargetPoint,
		VelocityValue,
		Accel
	}

	public enum gamesmartGunTargetState
	{
		Visible,
		Targetable,
		Locking,
		Locked,
		Unlocking
	}

	public enum gamestateMachineParameterAspect
	{
		Temporary,
		Permanent,
		Conditional
	}

	public enum gametargetingSystemETargetFilterStatus
	{
		Stop,
		Continue
	}

	public enum gametargetingSystemScriptFilter
	{
		Melee,
		Shooting,
		Scanning,
		QuickHack,
		ShootingLimbCyber,
		HeadTarget,
		LegTarget,
		MechanicalTarget
	}

	public enum gametargetingSystemSearchFilterMaskValue
	{
		Obj_Player,
		Obj_Puppet,
		Obj_Sensor,
		Obj_Device,
		Obj_Other,
		Att_Friendly,
		Att_Hostile,
		Att_Neutral,
		Sp_AimAssistEnabled,
		Sp_Aggressive,
		St_Alive,
		St_Dead,
		St_NotDefeated,
		St_Defeated,
		St_Conscious,
		St_Unconscious,
		St_TurnedOn,
		St_TurnedOff,
		St_QuickHackable,
		St_AliveAndActive
	}

	public enum gameuiAuthorisationNotificationType
	{
		Unknown,
		GotKeycard,
		AccessGranted
	}

	public enum gameuiBaseMenuGameControllerPuppetGenderInfo
	{
		Male,
		Female,
		ShouldBeDetermined
	}

	public enum gameuiBinkVideoStatus
	{
		Idle,
		NotStarted,
		Initializing,
		Playing,
		Finished,
		OutOfFrustum,
		Stopped,
		Error
	}

	public enum gameuiCharacterCustomizationActionType
	{
		Activate,
		Deactivate,
		EquipItem,
		UnequipItem
	}

	public enum gameuiCharacterCustomizationPart
	{
		Head,
		Body,
		Arms
	}

	public enum gameuiCharacterCustomization_BrokenNoseStage
	{
		CCBN_Disabled,
		CCBN_Stage1,
		CCBN_Stage2
	}

	public enum gameuiChoiceIndicatorType
	{
		Default,
		Speech,
		Call,
		Arrow,
		Hand,
		Loot,
		Quest,
		FastTravel,
		Solo,
		Netrunner,
		Techie
	}

	public enum gameuiChoiceListVisualizerType
	{
		Interaction,
		Dialog
	}

	public enum gameuiCyberspaceElementType
	{
		CyberspaceNPC,
		CyberspaceFakeObject
	}

	public enum gameuiDamageDigitsMode
	{
		Off,
		Individual,
		Accumulated,
		Both
	}

	public enum gameuiDamageDigitsStickingMode
	{
		None,
		Individual,
		Accumulated,
		Both
	}

	public enum gameuiDamageIndicatorMode
	{
		Off,
		DamageOnly,
		On
	}

	public enum gameuiEBraindanceLayer
	{
		Visual,
		Audio,
		Thermal
	}

	public enum gameuiEClueDescriptorMode
	{
		Invalid,
		Add,
		Finish
	}

	public enum gameuiEIconOrientation
	{
		Upright,
		Entity
	}

	public enum gameuiETooltipPlacement
	{
		LeftCenter,
		RightCenter,
		LeftTop,
		RightTop
	}

	public enum gameuiEWorldMapCameraMode
	{
		TopDown,
		Free,
		ZoomLevels,
		COUNT
	}

	public enum gameuiEWorldMapDistrictView
	{
		None,
		Districts,
		SubDistricts
	}

	public enum gameuiGenericNotificationType
	{
		Generic,
		QuestUpdate,
		Vendor,
		ZoneAlert,
		VehicleAlert,
		PreventionBounty,
		ProgressionView
	}

	public enum gameuiHackingMinigameState
	{
		Unknown,
		InProgress,
		Succeeded,
		Failed
	}

	public enum gameuiHitType
	{
		Miss,
		Glance,
		Hit,
		CriticalHit,
		CriticalHit_x2
	}

	public enum gameuiMappinGroupState
	{
		Ungrouped,
		Grouped,
		GroupedCollection,
		GroupedHidden
	}

	public enum gameweaponReloadStatus
	{
		Standard,
		Interrupted
	}

	public enum genLevelRandomizerDataSource
	{
		Entries,
		Markers
	}

	public enum grsDeathmatchStatus
	{
		Waiting,
		AdditionalWaiting,
		Starting,
		InGame,
		Ending,
		Sumup
	}

	public enum grsHeistStatus
	{
		Waiting,
		Starting,
		Lobby,
		InGame,
		Ending,
		Victory,
		Failure
	}

	public enum gsmStateError
	{
		StateError_OK,
		StateError_SettingsCorrupted,
		StateError_SettingsCorrupted_Save,
		StateError_ProfileCorrupted,
		StateError_ProfileCorrupted_Save,
		StateError_CannotInitializeContext,
		StateError_CantInitializeSession,
		StateError_CantLoadSave_CantLoadFile,
		StateError_CantLoadSave_CantCreateLoadStream,
		StateError_CantLoadSave_CensorshipLevelMismatch,
		StateError_CantLoadSave_CensorshipOptionalNudity,
		StateError_CantLoadSave_VersionMismatch,
		StateError_CantLoadSave_Corrupted,
		StateError_CantLoadSave_SessionDescInvalid
	}

	public enum inkBrushDrawType
	{
		NoDraw,
		Solid,
		Wire
	}

	public enum inkBrushMirrorType
	{
		NoMirror,
		Horizontal,
		Vertical,
		Both
	}

	public enum inkBrushTileType
	{
		NoTile,
		Horizontal,
		Vertical,
		Both
	}

	public enum inkCacheMode
	{
		Normal,
		Minimap,
		ExternalDynamicTexture
	}

	public enum inkCharacterEventType
	{
		CharInput,
		MoveCaretForward,
		MoveCaretBackward,
		Delete,
		Backspace
	}

	public enum inkCompositionParamType
	{
		FLOAT,
		VECTOR2
	}

	public enum inkDiscreteNavigationDirection
	{
		Up,
		Right,
		Down,
		Left
	}

	public enum inkDisplayMode
	{
		Invalid,
		Basic,
		Bold,
		Header,
		Single
	}

	public enum inkEAnchor
	{
		TopLeft,
		TopCenter,
		TopRight,
		CenterLeft,
		Centered,
		CenterRight,
		BottomLeft,
		BottomCenter,
		BottomRight,
		TopFillHorizontaly,
		CenterFillHorizontaly,
		BottomFillHorizontaly,
		LeftFillVerticaly,
		CenterFillVerticaly,
		RightFillVerticaly,
		Fill
	}

	public enum inkEBlurDimension
	{
		Horizontal,
		Vertical
	}

	public enum inkEButtonState
	{
		Normal,
		Hover,
		Press,
		Disabled
	}

	public enum inkEChildOrder
	{
		Forward,
		Backward
	}

	public enum inkEEndCapStyle
	{
		BUTT,
		SQUARE,
		ROUND,
		JOINED
	}

	public enum inkEHorizontalAlign
	{
		Fill,
		Left,
		Center,
		Right
	}

	public enum inkEJointStyle
	{
		MITER,
		BEVEL,
		ROUND
	}

	public enum inkELayerType
	{
		Watermarks,
		SystemNotifications,
		Loading,
		GameNotifications,
		Menu,
		Video,
		HUD,
		Editor,
		World,
		Offscreen,
		Advertisements,
		StreetSigns,
		PhotoMode,
		Debug,
		MAX
	}

	public enum inkEOrientation
	{
		Horizontal,
		Vertical
	}

	public enum inkEScrollDirection
	{
		Vertical,
		Horizontal
	}

	public enum inkEShapeVariant
	{
		Fill,
		Border,
		FillAndBorder
	}

	public enum inkESizeRule
	{
		Fixed,
		Stretch
	}

	public enum inkESliderDirection
	{
		Horizontal,
		Vertical
	}

	public enum inkETextDirection
	{
		LeftToRight,
		RightToLeft,
		Mixed
	}

	public enum inkETextureResolution
	{
		UltraHD_3840_2160,
		FullHD_1920_1080,
		HD_1280_720
	}

	public enum inkEToggleState
	{
		Normal,
		Press,
		Hover,
		Disabled,
		Toggled,
		ToggledPress,
		ToggledHover
	}

	public enum inkEVerticalAlign
	{
		Fill,
		Top,
		Center,
		Bottom
	}

	public enum inkEffectType
	{
		ScanlineWipe,
		LinearWipe,
		RadialWipe,
		LightSweep,
		BoxBlur,
		Mask,
		Glitch,
		PointCloud,
		ColorFill,
		InnerGlow,
		ColorCorrection,
		Multisampling
	}

	public enum inkFinalConfigurationVisibility
	{
		VisibleOnlyInFinal,
		HiddenOnlyInFinal
	}

	public enum inkFitToContentDirection
	{
		None,
		Horizontal,
		Vertical
	}

	public enum inkFocusCause
	{
		Mouse,
		Navigation,
		SetDirectly,
		Cleared,
		OtherWidgetLostFocus,
		WindowActivate
	}

	public enum inkGradientMode
	{
		Linear,
		Rectangular
	}

	public enum inkIconResult
	{
		Success,
		UnknownIconTweak,
		AtlasResourceNotFound,
		PartNotFoundInAtlas
	}

	public enum inkInputHintHoldIndicationType
	{
		Press,
		Hold,
		FromInputConfig
	}

	public enum inkLanguageId
	{
		EN,
		PL,
		JP,
		DE,
		ES,
		MX,
		KR,
		IT,
		FR,
		RU,
		PR,
		ZH_CN,
		TW,
		CZ,
		HU,
		AR,
		TR,
		TH,
		HT,
		DEBUG
	}

	public enum inkLastTickVideoState
	{
		NotDrawn,
		Drawn,
		Paused
	}

	public enum inkLifePath
	{
		Corporate,
		StreetKid,
		Nomad,
		Invalid
	}

	public enum inkLineType
	{
		RegularPatternSpacing,
		LoosePatternSpacing
	}

	public enum inkLoadingScreenType
	{
		Unknown,
		SplashScreen,
		Initial,
		FastTravel
	}

	public enum inkMaskDataSource
	{
		TextureAtlas,
		DynamicTexture
	}

	public enum inkMenuMode
	{
		Unknown,
		PauseMenu,
		HubMenu,
		CustomMenu
	}

	public enum inkMenuState
	{
		Enabled,
		Disabled
	}

	public enum inkSaveType
	{
		ManualSave,
		QuickSave,
		AutoSave,
		PointOfNoReturn,
		EndGameSave
	}

	public enum inkSelectionRule
	{
		Single,
		Parent,
		Children,
		TypeBased,
		NameBased
	}

	public enum inkSelectorChangeDirection
	{
		None,
		Prior,
		Next
	}

	public enum inkSpawnMode
	{
		SingleAndMultiplayer,
		OnlySingleplayer,
		OnlyMultiplayer
	}

	public enum inkState
	{
		InitEngine,
		PreGameMenu,
		InitialLoading,
		Game,
		InGameMenu,
		PauseMenu,
		FastTravelLoading,
		PhotoMode,
		MiniGameMenu,
		EndGameLoading,
		EditorMode
	}

	public enum inkTextReplaceAnimationControllerWidgetTextUsage
	{
		BaseText,
		TargetText,
		NoUsage
	}

	public enum inkTextWrappingPolicy
	{
		SingleLine,
		MultiLine,
		MultilineNoWrap
	}

	public enum inkTextureType
	{
		StaticTexture,
		DynamicTexture,
		InvalidTexture
	}

	public enum inkVideoInstanceDoneReason
	{
		Failed,
		Stopped,
		Finished
	}

	public enum inkVideoOptimizationState
	{
		None,
		TooManyBinks,
		FullscreenBinkVisible
	}

	public enum inkWidgetResourceVersion
	{
		Default,
		BrushToAtlas
	}

	public enum inkanimEventType
	{
		OnLoaded,
		OnStart,
		OnFinish,
		OnPause,
		OnResume,
		OnStartLoop,
		OnEndLoop
	}

	public enum inkanimInterpolationDirection
	{
		To,
		From,
		FromTo
	}

	public enum inkanimInterpolationMode
	{
		EasyIn,
		EasyOut,
		EasyInOut,
		EasyOutIn
	}

	public enum inkanimInterpolationType
	{
		Linear,
		Quadratic,
		Qubic,
		Quartic,
		Quintic,
		Sinusoidal,
		Exponential,
		Elastic,
		Circular,
		Back
	}

	public enum inkanimLoopType
	{
		None,
		Cycle,
		PingPong
	}

	public enum inkanimPropertyType
	{
		Size,
		Color,
		Margin,
		Padding,
		Transparency,
		Rotation
	}

	public enum locHolocallActorMode
	{
		Default,
		ActorUsesHolocall,
		ActorDoesntUseHolocall
	}

	public enum locVoiceTagGender
	{
		Undefined,
		Male,
		Female
	}

	public enum locVoiceoverContext
	{
		Vo_Context_Quest,
		Vo_Context_Community,
		Vo_Context_Combat,
		Vo_Context_Minor_Activity,
		Default_Vo_Context
	}

	public enum locVoiceoverExpression
	{
		Vo_Expression_Spoken,
		Vo_Expression_Phone,
		Vo_Expression_InnerDialog,
		Vo_Expression_Loudspeaker_Room,
		Vo_Expression_Loudspeaker_Street,
		Vo_Expression_Loudspeaker_City,
		Vo_Expression_Radio,
		Vo_Expression_GlobalTV,
		Vo_Experession_Cb_Radio,
		Vo_Expression_Cyberspace,
		Vo_Expression_Possessed,
		Vo_Expression_Helmet
	}

	public enum moveCirclingDirection
	{
		None,
		Left,
		Right
	}

	public enum moveExplorationType
	{
		None,
		Ladder,
		Jump,
		Climb,
		Vault,
		ChargedJump,
		ThrusterJump
	}

	public enum moveLineOfSight
	{
		None,
		Keep,
		Avoid
	}

	public enum moveMovementOrientationType
	{
		NotSet,
		Forward,
		Backward,
		Left,
		Right
	}

	public enum moveMovementType
	{
		Walk,
		Run,
		Sprint,
		Strafe,
		Stand
	}

	public enum moveSecureFootingFailureReason
	{
		Invalid,
		Filter,
		SimulationType,
		Ground
	}

	public enum moveSecureFootingFailureType
	{
		Invalid,
		Edge,
		Slope
	}

	public enum navLocomotionPathSegmentTypes
	{
		Invalid,
		Spline,
		OffMeshLink
	}

	public enum navNaviPositionType
	{
		None,
		Normal,
		Projected
	}

	public enum physicsFilterDataSource
	{
		Parent,
		Collider
	}

	public enum physicsMaterialFriction
	{
		Enabled,
		DisabledStrong,
		Disabled
	}

	public enum physicsMaterialTagAIVisibility
	{
		None,
		SemiTransparent,
		Transparent
	}

	public enum physicsMaterialTagProjectilePenetration
	{
		TechOnly,
		Any,
		Medium,
		Heavy,
		Never
	}

	public enum physicsMaterialTagType
	{
		AIVisibility,
		ProjectilePenetration,
		VehicleTraction
	}

	public enum physicsMaterialTagVehicleTraction
	{
		Default,
		Gravel
	}

	public enum physicsPhysicalSystemOwner
	{
		Unknown,
		StaticMeshNode,
		StaticCollisionAreaNode,
		DynamicMeshNode,
		TerrainMeshNode,
		TerrainCollisionNode,
		PhysicalDestructionNode,
		PhysicalDestructionComponent,
		PhysicalDecorationNode,
		PhysicalMeshComponent,
		PhysicalSkinnedMeshComponent,
		ColliderComponent,
		SimpleColliderComponent,
		RagdollBinder,
		WaterPatchNode,
		WorldCollisionNode,
		AggregateSystemComponent,
		ClothComponent,
		SkinnedClothComponent,
		ClothMeshNodeInstance,
		PhysicalTriggerComponent,
		PhysicalTriggerNode,
		StateMachineComponent,
		PhysicalParticleSystem,
		BakedDestructionComponent,
		BakedDestructionNode,
		InstancedDestructibleNode,
		PhotoModeSystem,
		VehicleChassisComponent,
		FoliageDestruction
	}

	public enum physicsPhysicsJointAxis
	{
		AxisX,
		AxisY,
		AxisZ,
		Twist,
		Swing1,
		Swing2
	}

	public enum physicsPhysicsJointDriveType
	{
		AxisX,
		AxisY,
		AxisZ,
		Swing,
		Twist,
		SLERP
	}

	public enum physicsPhysicsJointMotion
	{
		Locked,
		Limited,
		Free
	}

	public enum physicsProxyType
	{
		Invalid,
		PhysicalSystem,
		CharacterController,
		Destruction,
		ParticleSystem,
		Trigger,
		Cloth,
		WorldCollision,
		SimpleCollider,
		AggregateSystem,
		FoliageDestruction,
		Terrain
	}

	public enum physicsQueryUseCase
	{
		Default,
		ActionAnimation,
		AI,
		AnimationComponent,
		Audio,
		AudioHedgehog,
		Components,
		Debug,
		Gameplay,
		GeomDescription,
		LineOfSightTests,
		Navigation,
		Nodes,
		Ragdoll,
		Scripts,
		VehicleAI,
		Vehicles,
		VehicleChassis,
		VehiclesCrowd,
		VehicleWheel,
		VehicleStreamingHack,
		VehicleWater,
		WorldUI
	}

	public enum physicsRagdollShapeType
	{
		CAPSULE,
		BOX,
		SPHERE
	}

	public enum physicsShapeType
	{
		Box,
		Sphere,
		Capsule,
		ConvexMesh,
		TriangleMesh,
		Invalid
	}

	public enum physicsSimulationType
	{
		Static,
		Dynamic,
		Kinematic,
		Invalid
	}

	public enum physicsStateValue
	{
		Position,
		Rotation,
		Transform,
		LinearVelocity,
		AngularVelocity,
		LinearSpeed,
		TouchesGround,
		TouchesWalls,
		ImpulseAccumulator,
		IsSleeping,
		Mass,
		Volume,
		IsSimulated,
		IsKinematic,
		TimeDeltaOverride,
		SimulationFilter,
		Radius
	}

	public enum populationSpawnerObjectCtrlAction
	{
		Undefined,
		Activate,
		Deactivate,
		Reactivate,
		ResetKillCount
	}

	public enum questAttachmentOffsetMode
	{
		UseRealOffset,
		UseCustomOffset
	}

	public enum questAudioEventPrefetchMode
	{
		AddEventPrefetch,
		RemoveEventPrefetch
	}

	public enum questAvailableVehicleType
	{
		AnyCar,
		AnyMotorcycle,
		AnyVehicle,
		SpecificVehicle
	}

	public enum questBehindInteractionEventType
	{
		Undefined,
		StartedBeingBehind,
		StoppedBeingBehind,
		IsBehind,
		IsNotBehind
	}

	public enum questBlockAction
	{
		Block,
		Unblock,
		UnblockAll
	}

	public enum questBriefingSequencePlayerFunction
	{
		StartSequence,
		ChangeSequence,
		FinishSequence
	}

	public enum questBriefingType
	{
		Fullscreen,
		Hud
	}

	public enum questCameraParallaxSpace
	{
		Trajectory,
		Camera,
		Chest
	}

	public enum questCameraPlanesPreset
	{
		Undefined,
		VeryNear,
		Near,
		Normal
	}

	public enum questCharacterHitEventType
	{
		Bullet,
		Explosion,
		Melee,
		Other
	}

	public enum questCombatNodeFunctions
	{
		CombatTarget,
		ShootAt,
		LookAtTarget,
		ThrowGrenade,
		UseCover,
		SwitchWeapon,
		PrimaryWeapon,
		SecondaryWeapon,
		RestrictMovementToArea
	}

	public enum questCompanionPositions
	{
		Behind,
		InFront
	}

	public enum questControlCrowdAction
	{
		Disable,
		Enable
	}

	public enum questCustomStyle
	{
		PlacidePhone,
		VideoCallInterupt
	}

	public enum questDrillingState
	{
		Undefined,
		Started,
		Finished
	}

	public enum questEAddRemoveItemType
	{
		AddItem,
		RemoveByItemID,
		RemoveByTag,
		RemoveAll
	}

	public enum questEComparisonTypeEquality
	{
		Equal,
		NotEqual
	}

	public enum questEDebugViewMode
	{
		NONE,
		CLAY,
		PURE_GRAY,
		PURE_WHITE,
		SHADOWS,
		BASE_COLOR,
		NORMALS,
		ROUGHNESS,
		METALNESS,
		EMISSIVE,
		MATERIAL_ID,
		WIREFRAME,
		OVERDRAW
	}

	public enum questETimeDilationOverride
	{
		None,
		Ignore,
		Inherit
	}

	public enum questETimeShiftType
	{
		ShiftByTime,
		ShiftToHour
	}

	public enum questEUIMenuState
	{
		Open,
		Closed
	}

	public enum questElevator_ManageNPCAttachment_NodeTypeParamsAction
	{
		Attach,
		Detach
	}

	public enum questExitType
	{
		Terminating,
		NonTerminating
	}

	public enum questGameplayRestrictionAction
	{
		AddRestriction,
		RemoveRestriction,
		RemoveAllRestrictions
	}

	public enum questImpulseMagnitude
	{
		Any,
		Low,
		Medium,
		High
	}

	public enum questInjectLootOperationType
	{
		Inject,
		Remove
	}

	public enum questInputDevice
	{
		Undefined,
		KeyboardMouse,
		XBoxGamepad,
		PS4Gamepad
	}

	public enum questJournalAlignmentEventType
	{
		Left,
		Center,
		Right
	}

	public enum questJournalSizeEventType
	{
		Maximize,
		Minimize
	}

	public enum questLanguageMode
	{
		Undefined,
		VoLang,
		SubsLang,
		TextLang
	}

	public enum questLocationAction
	{
		Entered,
		Exited
	}

	public enum questLogicalOperation
	{
		AND,
		OR,
		XOR,
		NAND,
		NOR,
		NXOR
	}

	public enum questLookAtDrivenTurnsMode
	{
		Start,
		Pause,
		Resume,
		Stop,
		ForceStop
	}

	public enum questLootTokenState
	{
		Enabled,
		Disabled,
		Sealed,
		Unsealed
	}

	public enum questMountConditionType
	{
		OnMount,
		OnUnmount
	}

	public enum questMountVehicleOrigin
	{
		Any,
		NotStolen,
		Stolen
	}

	public enum questMountVehicleType
	{
		Any,
		Car,
		Motorcycle
	}

	public enum questMoveOnSplineType
	{
		Simple,
		Anim,
		WithCompanion
	}

	public enum questMoveType
	{
		MoveOnSpline,
		MoveTo,
		RotateTo,
		Patrol,
		Follow
	}

	public enum questMultiplayerAIDirectorFunction
	{
		SetStatus,
		SetCurrentPath,
		OverrideScheduleEntry,
		SetCurrentShedule
	}

	public enum questMultiplayerAIDirectorStatus
	{
		Enabled,
		Disabled
	}

	public enum questMultiplayerHeistState
	{
		Invalid,
		Failure,
		Victory
	}

	public enum questNodeType
	{
		Equip,
		Unequip
	}

	public enum questObjectInspectEventType
	{
		Undefined,
		Started,
		Finished
	}

	public enum questObjectInteractionEventType
	{
		Undefined,
		Entered,
		Exited,
		Executed
	}

	public enum questObjectScanEventType
	{
		Undefined,
		Started,
		Finished
	}

	public enum questPhaseNodeType
	{
		Quest,
		OpenWorld,
		Combat,
		Audio
	}

	public enum questPhoneCallMode
	{
		Undefined,
		Audio,
		Video
	}

	public enum questPhoneCallPhase
	{
		Undefined,
		IncomingCall,
		StartCall,
		EndCall
	}

	public enum questPhoneStatus
	{
		Available,
		NotAvailable,
		Busy,
		Minimized
	}

	public enum questPhoneTalkingState
	{
		Ended,
		Initializing,
		Talking
	}

	public enum questPlatform
	{
		PC,
		Console
	}

	public enum questProximityProgressBarAction
	{
		Activated,
		Inactivated,
		Completed,
		WentOutOfRange
	}

	public enum questProximityProgressBarOrientation
	{
		Undefined,
		InRange,
		OutOfRange
	}

	public enum questProximityProgressBarState
	{
		None,
		Active,
		Inactive,
		Complete
	}

	public enum questQuestContentType
	{
		Fixer,
		MainQuest,
		SideQuest_MainPath,
		SideQuest_Romance,
		SideQuest_Standalone,
		MinorQuestAndSts
	}

	public enum questQuickItemsSet
	{
		Q001_Kereznikov_Heal_Phone,
		Q003_All
	}

	public enum questRandomizerMode
	{
		Random,
		IgnoreLastUsed,
		IgnoreAllUsed
	}

	public enum questScanningState
	{
		NotScanned,
		Scanned
	}

	public enum questSceneConditionType
	{
		Undefined,
		IsInside,
		IsOutside,
		Entered,
		Exited
	}

	public enum questSetDestructionStateAction
	{
		Undefined,
		Trigger
	}

	public enum questSocketType
	{
		Undefined,
		Input,
		Output,
		CutSource,
		CutDestination
	}

	public enum questSpawnedVehicleType
	{
		EntityReferenced,
		AnyCar,
		AnyMotorcycle,
		SpecificVehicle
	}

	public enum questSwitchWeaponModes
	{
		PrimaryWeapon,
		SecondaryWeapon
	}

	public enum questTriggerConditionType
	{
		Undefined,
		Entered,
		Exited,
		IsInside,
		IsOutside,
		AllInsideMP,
		AllOutsideMP
	}

	public enum questTutorialScreenMode
	{
		Undefined,
		Fullscreen,
		Popup
	}

	public enum questUIGameContextRequestType
	{
		Push,
		Pop,
		Reset
	}

	public enum questUseWorkspotNodeFunctions
	{
		UseWorkspot,
		JumpWorkspot,
		StopWorkspot,
		IdleOnlyMode
	}

	public enum questUseWorkspotTier
	{
		Tier3,
		Tier4
	}

	public enum questVehicleCameraPerspective
	{
		FPP,
		TPP
	}

	public enum questVehicleCameraType
	{
		Undefined,
		PuppetFPP,
		TPP,
		DriverFPP
	}

	public enum questVehicleWeaponQuestID
	{
		Primary,
		Secondary,
		Tertiary,
		Quaternary,
		Quinary,
		Senary,
		Septenary,
		Octonary,
		All
	}

	public enum questVisionModeType
	{
		Undefined,
		FocusMode,
		EnhancedMode
	}

	public enum questWeaponUsageType
	{
		Shoot,
		Reload
	}

	public enum redTaskTextMessageType
	{
		Info,
		Error
	}

	public enum rendCaptureContextType
	{
		SceneGamedef,
		AnimViewer
	}

	public enum rendContactShadowReciever
	{
		CSR_None,
		CSR_All,
		CSR_CharacterOnly
	}

	public enum rendEParticleSortingMode
	{
		PSM_None,
		PSM_Billboard,
		PSM_Regular
	}

	public enum rendGIGroup
	{
		GI_Group0,
		GI_Group1
	}

	public enum rendGIVolume
	{
		GI_Exterior,
		GI_Interior1,
		GI_Interior2,
		GI_Interior3,
		GI_Interior4
	}

	public enum rendLightAttenuation
	{
		LA_InverseSquare,
		LA_Linear
	}

	public enum rendLightGroup
	{
		LG_Group0,
		LG_Group1,
		LG_Group2,
		LG_Group3,
		LG_Group4,
		LG_Group5,
		LG_Group6,
		LG_Group7
	}

	public enum rendPostFx_ScanningState
	{
		Off,
		Scanning,
		Cancelled,
		Complete
	}

	public enum rendResolutionMultiplier
	{
		X1,
		X2,
		X4
	}

	public enum rendScreenshotMode
	{
		NONE,
		NORMAL,
		LAYERED,
		HIGH_RESOLUTION,
		HIGH_RESOLUTION_LAYERED
	}

	public enum rendWindShapeAnchorPointDepth
	{
		AP_CENTER,
		AP_FRONT,
		AP_BACK
	}

	public enum rendWindShapeAnchorPointHorz
	{
		AP_CENTER,
		AP_RIGHT,
		AP_LEFT
	}

	public enum rendWindShapeAnchorPointVert
	{
		AP_CENTER,
		AP_TOP,
		AP_BOTTOM
	}
	public enum renderDevEnvProbeView
	{
		RADIANCE,
		ALBEDO,
		NORMAL,
		ROUGHNESS,
		METALNESS,
		EMISSIVE,
		SKY_MASK
	}

	public enum renderDevGIProbeView
	{
		RADIANCE,
		SKY_VISIBILITY,
		ENV_ID,
		FLAG_0,
		FLAG_1,
		FLAG_2,
		CURRENT_ID
	}

	public enum renderDevSurfelView
	{
		ALBEDO,
		NORMAL,
		SHADOWS,
		CLOSEST_PROBE,
		EMISSIVE,
		LIGHTING,
		BOUNCE,
		INSIDE,
		SHADOW
	}

	public enum renderDevTXAADebugMode
	{
		TXAA_NoDebug,
		TXAA_ShowHistoryBlendFactor
	}

	public enum scnAdditionalSpeakerRole
	{
		Full,
		OnlyLipsync
	}

	public enum scnAdditionalSpeakerType
	{
		Normal,
		Holocall
	}

	public enum scnAnimNameType
	{
		direct,
		reference,
		container,
		dynamic
	}

	public enum scnAnimationCategory
	{
		Body,
		Facial,
		Cyberware
	}

	public enum scnAudioFastForwardSupport
	{
		MuteDuringFastForward,
		DontMuteDuringFastForward
	}

	public enum scnAudioPlaybackDirectionSupportFlag
	{
		Forward,
		Backward
	}

	public enum scnBraindanceLayer
	{
		Visual,
		Audio,
		Thermal
	}

	public enum scnBraindancePerspective
	{
		FirstPerson,
		ThirdPerson
	}

	public enum scnBraindanceSpeed
	{
		Any,
		Slow,
		Normal,
		Fast,
		VeryFast
	}

	public enum scnChoiceNodeNsChoiceNodeFlags
	{
		IsFocusClue,
		IsValidInteractionFailsafeDisabled
	}

	public enum scnChoiceNodeNsMappinLocation
	{
		None,
		Interaction,
		Nameplate,
		ObjectDefault
	}

	public enum scnChoiceNodeNsOperationMode
	{
		attachToActor,
		attachToProp,
		attachToGameObject,
		attachToScreen,
		attachToWorld
	}

	public enum scnChoiceNodeNsSizePreset
	{
		small,
		normal,
		big,
		Dialogue,
		Interaction,
		Dialogue360
	}

	public enum scnChoiceNodeNsTimedAction
	{
		appear,
		disappear,
		disappearFading
	}

	public enum scnChoiceNodeNsVisualizerStyle
	{
		onScreen,
		inWorld
	}

	public enum scnContextualActorName
	{
		Player,
		VoicesetHolder,
		Voice,
		SpecificVoicetagHolder,
		ContextActorName
	}

	public enum scnDialogLineLanguage
	{
		Origin,
		Creole,
		Japanese,
		Arabic,
		Russian,
		Chinese,
		Brasilian,
		English,
		Korean
	}

	public enum scnDialogLineType
	{
		None,
		Regular,
		Holocall,
		SceneComment,
		OverHead,
		Radio,
		GlobalTV,
		Invisible,
		OverHeadAlwaysVisible,
		OwnerlessRegular,
		AlwaysCinematicNoSpeaker,
		GlobalTVAlwaysVisible
	}

	public enum scnDialogLineVisualStyle
	{
		regular,
		overHead,
		radio,
		globalTV,
		invisible,
		innerDialog,
		overHeadAlwaysVisible,
		alwaysCinematicNoSpeaker,
		globalTVAlwaysVisible
	}

	public enum scnDistractedConditionTarget
	{
		Anyone,
		Speaker,
		SpeakerOrAddressee
	}

	public enum scnEasingType
	{
		Linear,
		SinusoidalEaseInOut,
		QuadraticEaseIn,
		QuadraticEaseOut,
		CubicEaseInOut,
		CubicEaseIn,
		CubicEaseOut
	}

	public enum scnEndNodeNsType
	{
		Terminating,
		NonTerminating
	}

	public enum scnEntityAcquisitionPlan
	{
		findInContext,
		findInWorld,
		spawnDespawn,
		findInEntity,
		spawnSet,
		community,
		spawner,
		findNetworkPlayer,
		findInNode
	}

	public enum scnEventType
	{
	}

	public enum scnFastForwardMode
	{
		Default,
		GameplayReview
	}

	public enum scnFastForwardStrategy
	{
		automatic,
		allow_fully,
		block_on_start,
		block_on_end,
		block_on_start_and_end,
		block_fully,
		block_on_end_if_activator_matched
	}

	public enum scnInterruptCapability
	{
		None,
		Interruptable,
		NotInterruptable
	}

	public enum scnInterruptReturnLinesBehavior
	{
		Default,
		Vehicle,
		Holocall
	}

	public enum scnLookAtTargetType
	{
		Actor,
		Prop
	}

	public enum scnMarkerType
	{
		Local,
		Global,
		Entity
	}

	public enum scnOffsetMode
	{
		useRealOffset,
		useCustomOffset
	}

	public enum scnPlayDirection
	{
		Forward,
		Backward
	}

	public enum scnPlaySpeed
	{
		Pause,
		Slow,
		Normal,
		Fast,
		VeryFast
	}

	public enum scnPropOwnershipTransferOptionsType
	{
		TransferToWorkspotSystem_Automatic,
		TransferToWorkspotSystem_Custom,
		DisposeAfterScene
	}

	public enum scnPuppetVehicleState
	{
		IdleMounted,
		IdleStand,
		CombatWindowed,
		CombatSeated,
		Turret,
		GunnerSlot
	}

	public enum scnRandomizerMode
	{
		Random,
		IgnoreLastUsed,
		IgnoreAllUsed
	}

	public enum scnReminderConditionProcessStep
	{
		ReminderA,
		ReminderB,
		ReminderC,
		Looping
	}

	public enum scnRidActorPlacement
	{
		SceneOrigin,
		Actual,
		Player
	}

	public enum scnRootMotionAnimPlacementMode
	{
		Blend,
		TeleportToStart,
		PlayAtActorPosition
	}

	public enum scnSceneCategoryTag
	{
		voiceset,
		mainQuests,
		sideQuests,
		minorQuests,
		otherQuests,
		dialoguesQuests,
		streetOpenWorld,
		vendorsOpenWorld,
		dancefloorsOpenWorld,
		cityOpenWorld,
		chatsOpenWorld,
		otherOpenWorld,
		other
	}

	public enum scnSectionInternalsActorBehaviorMode
	{
		OnlyIfAlive,
		EvenIfDead
	}

	public enum scnWorldMarkerType
	{
		Tag,
		NodeRef
	}

	public enum scnblocLocaleId
	{
		db_db,
		pl_pl,
		en_us
	}

	public enum scndevEventType
	{
		NodeFailed,
		DebugMessage,
		NodeProgressSet
	}

	public enum scneventsRidCameraPlacement
	{
		SceneOrigin,
		Actual,
		Player
	}

	public enum scneventsUIAnimActionType
	{
		Play,
		Update,
		Resume,
		Pause,
		Stop
	}

	public enum scneventsVFXActionType
	{
		Play,
		Break,
		Kill
	}

	public enum scnfppBlendOverride
	{
		Centering,
		CopyPitch_CenteringYaw,
		CopyPitch_CopyYaw,
		Custom_PitchYaw
	}

	public enum scnfppParallaxSpace
	{
		Default,
		Camera,
		Trajectory,
		Chest
	}

	public enum scnlocLocaleId
	{
		db_db,
		pl_pl,
		en_us
	}

	public enum scnscreenplayItemType
	{
		invalid,
		dialogLine,
		choiceOption,
		standaloneComment
	}

	public enum senseAdditionalTraceType
	{
		Knee,
		Hip,
		Chest
	}

	public enum senseEShapeType
	{
		INVALID,
		BOX,
		SPHERE,
		CONE,
		ANGLE_RANGE
	}

	public enum senseTracingFreq
	{
		Never,
		Lowest,
		Low,
		Medium,
		High,
		Highest
	}

	public enum sharedCommandResult
	{
		Success,
		NeedOptions,
		Fail,
		Abort
	}

	public enum sharedMenuItemType
	{
		Action,
		Checked,
		Group,
		Separator
	}

	public enum tempshitMapPinOperation
	{
		Undefined,
		Add,
		Remove
	}

	public enum textHorizontalAlignment
	{
		Left,
		Center,
		Right
	}

	public enum textJustificationType
	{
		Left,
		Center,
		Right
	}

	public enum textLetterCase
	{
		OriginalCase,
		UpperCase,
		LowerCase
	}

	public enum textOverflowPolicy
	{
		None,
		DotsEnd,
		DotsEndLastLine,
		AutoScroll,
		PingPongScroll,
		AdjustToSize
	}

	public enum textTextDirection
	{
		LeftToRight,
		RightToLeft,
		Mixed
	}

	public enum textTextFlowDirection
	{
		Auto,
		LeftToRight,
		RightToLeft
	}

	public enum textTextShapingMethod
	{
		Auto,
		KerningOnly,
		FullShaping
	}

	public enum textVerticalAlignment
	{
		Top,
		Center,
		Bottom
	}

	public enum textWrappingPolicy
	{
		Default,
		PerCharacter
	}

	public enum toolsMessageSeverity
	{
		Success,
		Info,
		Warning,
		Error
	}

	public enum toolsMessageTokenType
	{
		Text,
		Location,
		Tag
	}

	public enum vehicleAudioEventAction
	{
		OnPlayerDriving,
		OnPlayerPassenger,
		OnPlayerExitVehicle,
		OnPlayerEnterCombat,
		OnPlayerExitCombat,
		OnPlayerVehicleSummoned
	}

	public enum vehicleBikeCurve
	{
		SpeedToTilt,
		InputToTilt
	}

	public enum vehicleCameraPerspective
	{
		FPP,
		TPPClose,
		TPPFar
	}

	public enum vehicleCameraType
	{
		FPP,
		TPP
	}

	public enum vehicleELightMode
	{
		Off,
		On,
		HighBeams
	}

	public enum vehicleELightType
	{
		Head,
		Brake,
		LeftBlinker,
		RightBlinker,
		Reverse,
		Interior,
		Utility,
		Default,
		Blinkers
	}

	public enum vehicleEQuestVehicleDoorState
	{
		ForceOpen,
		ForceClose,
		OpenAll,
		CloseAll,
		ForceLock,
		ForceUnlock,
		LockAll,
		EnableInteraction,
		DisableInteraction,
		DisableAllInteractions,
		ResetInteractions,
		ResetVehicle,
		OpenAllRegular,
		QuestLock,
		QuestLockAll,
		Count,
		Invalid
	}

	public enum vehicleEQuestVehicleWindowState
	{
		ForceOpen,
		ForceClose,
		OpenAll,
		CloseAll
	}

	public enum vehicleEState
	{
		Default,
		On,
		Disabled,
		Destroyed
	}

	public enum vehicleESummonedVehicleType
	{
		Any,
		Car,
		Motorcycle
	}

	public enum vehicleEVehicleDoor
	{
		seat_front_left,
		seat_front_right,
		seat_back_left,
		seat_back_right,
		trunk,
		hood,
		count,
		invalid
	}

	public enum vehicleEVehicleSpeedConditionType
	{
		CT_EQUAL,
		CT_NOT_EQUAL,
		CT_GREATER,
		CT_GREATER_EQUAL,
		CT_LESS,
		CT_LESS_EQUAL,
		CT_ABS_GREATER,
		CT_ABS_GREATER_EQUAL,
		CT_ABS_LESS,
		CT_ABS_LESS_EQUAL
	}

	public enum vehicleEVehicleWindowState
	{
		Closed,
		Open
	}

	public enum vehicleExitDirection
	{
		NoDirection,
		Left,
		Right,
		Front,
		Back,
		Top
	}

	public enum vehicleFormationType
	{
		FORMATION_TRIANGLE,
		FORMATION_TURTLE,
		FORMATION_QUINCUNX
	}

	public enum vehicleGarageState
	{
		NoVehiclesAvailable,
		SummonAvailable,
		SummonDisabled
	}

	public enum vehiclePlayerToAIInterpolationType
	{
		PTAIT_INSTANT,
		PTAIT_LINEAR,
		PTAIT_EASE_IN_QUAD,
		PTAIT_EASE_IN_CUBIC,
		PTAIT_EASE_OUT_CUBIC,
		PTAIT_EASE_IN_OUT_CUBIC,
		PTAIT_EASE_IN_QUANTIC,
		PTAIT_EASE_IN_SIN,
		PTAIT_EASE_OUT_SIN,
		PTAIT_EASE_IN_OUT_SIN,
		PTAIT_LINEAR_NON_SMOOTHED,
		PTAIT_EASE_IN_QUAD_NON_SMOOTHED,
		PTAIT_EASE_IN_CUBIC_NON_SMOOTHED,
		PTAIT_EASE_OUT_CUBIC_NON_SMOOTHED,
		PTAIT_EASE_IN_OUT_CUBIC_NON_SMOOTHED,
		PTAIT_EASE_IN_QUANTIC_NON_SMOOTHED,
		PTAIT_EASE_IN_SIN_NON_SMOOTHED,
		PTAIT_EASE_OUT_SIN_NON_SMOOTHED,
		PTAIT_EASE_IN_OUT_SIN_NON_SMOOTHED
	}

	public enum vehicleSummonFinishState
	{
		Arrived
	}

	public enum vehicleSummonState
	{
		Idle,
		EnRoute,
		AlreadySummoned,
		PathfindingFailed,
		Arrived
	}

	public enum vehicleTPPCameraDistance
	{
		Close,
		Far
	}

	public enum vehicleTPPCameraHeight
	{
		Low,
		High
	}

	public enum vehicleVehicleDoorInteractionState
	{
		Available,
		Locked,
		Disabled,
		QuestLocked,
		Reserved
	}

	public enum vehicleVehicleDoorState
	{
		Closed,
		Open,
		Detached
	}

	public enum vgEStyleAttributeType
	{
		FillColor,
		StrokeColor,
		StrokeSize,
		StrokeMiterLimit,
		FontFamily,
		FontSize
	}

	public enum visWorldOccluderType
	{
		Default,
		None,
		Detail,
		MinorInterior,
		MajorInterior,
		Exterior
	}

	public enum workLogicalOperation
	{
		AND,
		OR
	}

	public enum workPropAttachMethod
	{
		BonePosition,
		RelativePosition,
		Custom
	}

	public enum workWeaponType
	{
		Any,
		Ranged,
		OneHandedRanged,
		AssaultRifle,
		Hammer,
		Handgun,
		HeavyMachineGun,
		Katana,
		Knife,
		LightMachineGun,
		LongBlade,
		Melee,
		OneHandedClub,
		PrecisionRifle,
		Revolver,
		Rifle,
		ShortBlade,
		Shotgun,
		ShotgunDual,
		SniperRifle,
		SubmachineGun,
		TwoHandedClub
	}

	public enum workWorkspotDebugMode
	{
		VisualLogToogle,
		VisualLogOn,
		VisualLogOff,
		VisualStateToogle,
		VisualStateOn,
		VisualStateOff,
		RecorderOn,
		RecorderOff,
		PlaybackOn,
		PlaybackOff,
		Invalid,
		FunctionalTests
	}

	public enum workWorkspotLogic
	{
		Allow,
		Deny
	}

	public enum worldEClusteringModel
	{
		HierarchicalGrid,
		AlwaysLoaded,
		Discard
	}

	public enum worldEditablePrefabType
	{
		Regular,
		Decoration,
		Quest,
		Building,
		Road
	}

	public enum worldFindLaneFilter
	{
		None,
		Road,
		PatrolRoute,
		Pavement
	}

	public enum worldNavigationRequestStatus
	{
		OK,
		InvalidStartingPosition,
		InvalidEndPosition,
		OtherError
	}

	public enum worldNodeGroupType
	{
		RegularGroup,
		PrefabVariant,
		DecorationCell,
		ProxyGroup
	}

	public enum worldNodeSocketType
	{
		Bidirectional,
		Inward,
		Outward,
		Disabled
	}

	public enum worldObjectTag
	{
		None,
		WallInterior,
		WallExterior,
		Floor,
		Stairs,
		Ladder,
		Decoration,
		Discard,
		Cover
	}

	public enum worldObjectTagExt
	{
		None,
		Default,
		NonClimbable
	}

	public enum worldOffMeshConnectionType
	{
		Door,
		Ladder,
		Floor,
		Jump,
		Elevator,
		Drone,
		Exploration,
		Custom,
		Blockade
	}

	public enum worldPatrolSplinePointTypes
	{
		Workspot,
		LookAt,
		ClearLookAt
	}

	public enum worldPrefabMinimapContribution
	{
		Auto,
		Include,
		Discard
	}

	public enum worldPrefabOwnership
	{
		None,
		Quest,
		Audio,
		Environment,
		FX,
		LevelDesign,
		Lighting,
		OpenWorld,
		Cinematics
	}

	public enum worldPrefabProxyMeshOnly
	{
		SettingFromResource,
		Enabled,
		Disabled
	}

	public enum worldPrefabStreamingOcclusion
	{
		Default,
		Interior,
		OpenInterior
	}

	public enum worldPrefabType
	{
		Regular,
		Area,
		Generated,
		Decoration,
		Quest,
		Road,
		Building,
		Terrain
	}

	public enum worldProxWindowsType
	{
		SkipWindows,
		PropagateWindows,
		BakeLongDistantWindows,
		BakeWindowsToBuffer
	}

	public enum worldProxyBBoxSyncOptions
	{
		Do_Nothing,
		Pull,
		Pull_And_Delete
	}

	public enum worldProxyCoreAxis
	{
		X,
		Y,
		Z
	}

	public enum worldProxyGroupingNormals
	{
		Around_Core_Axis,
		Around_All_Axes
	}

	public enum worldProxyMeshBuildType
	{
		ProxyFromScratch,
		ProxyFromProxy,
		OnlyFromChildProxies
	}

	public enum worldProxyMeshDependencyMode
	{
		Auto,
		Discard
	}

	public enum worldProxyMeshOutputType
	{
		RayScan,
		SurfaceReconstruction,
		LegacyFromVoxels,
		FromCustomMesh,
		FromBoxes,
		FromCollision,
		FromConvexHull,
		BoundsCombine,
		BlobCrowd,
		KeepCurrent
	}

	public enum worldProxyMeshTexRes
	{
		RES_64,
		RES_128,
		RES_256,
		RES_512,
		RES_1024
	}

	public enum worldProxyMeshUVType
	{
		UvUseExisting,
		UvGenerateNew
	}

	public enum worldProxyNormalAngleStepSize
	{
		STEP_90,
		STEP_45,
		STEP_15,
		STEP_5
	}

	public enum worldProxySyncNormalSource
	{
		From_Groups,
		From_Face_Average
	}

	public enum worldQuestPrefabLoadingMode
	{
		Disable,
		ForceLoad
	}

	public enum worldQuestType
	{
		MainQuest,
		SideQuest,
		StreetStory
	}

	public enum worldRainIntensity
	{
		NoRain,
		LightRain,
		HeavyRain
	}

	public enum worldRoadMaterial
	{
		Concrete,
		ConcreteDestroyed,
		Dirt,
		HardenedDirtDestroyed
	}

	public enum worldRotatingMeshNodeAxis
	{
		X,
		Y,
		Z
	}

	public enum worldSpeedSplineOrientationMarkerType
	{
		UseSplineOrientation,
		WorldSpace,
		LocalSpace,
		KeepYawRoll_WorldSpacePitch,
		KeepPitchYaw_WorldSpaceRoll,
		KeepPitchRoll_WorldSpaceYaw,
		KeepYaw_WorldSpacePitchRoll,
		KeepRoll_WorldSpacePitchYaw,
		KeepPitch_WorldSpaceYawRoll
	}

	public enum worldStreamingTestCheckpointType
	{
		BeginMove,
		EndMove
	}

	public enum worldTrafficLightColor
	{
		GREEN,
		RED,
		YELLOW,
		INVALID
	}

	public enum worldTrafficMovementBehavior
	{
		Pedestrian,
		Car
	}

	public enum worldTrafficSplineNodeUsage
	{
		Pavement,
		Road
	}

	public enum worldTrafficSpotDirection
	{
		Forward,
		Backward,
		Both
	}

	public enum worldenvUtilsEBlendParamsType
	{
		EBPS_Tick,
		EBPS_Game,
		EBPS_Frame
	}

	public enum worldgeometryDescriptionQueryFlags
	{
		DistanceVector,
		CollisionNormal,
		ObstacleDepth,
		UpExtent,
		DownExtent,
		TopExtent,
		TopPoint,
		BehindPoint
	}

	public enum worldgeometryDescriptionQueryStatus
	{
		OK,
		NoGeometry,
		UpVectorSameAsDirection
	}

	public enum worldgeometryProbingStatus
	{
		None,
		StillInObstacle,
		GeometryDiverged,
		Failure
	}

	public enum worldgeometryaverageNormalDetectionHelperQueryStatus
	{
		Finished,
		NoGeometry
	}

	public enum worlduiEntryVisibility
	{
		TierVisibility,
		ForceShow,
		ForceHide
	}
}
