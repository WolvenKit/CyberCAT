using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PreventionSystem")]
    public class PreventionSystem : GameScriptableSystem
    {
        [RealName("districtManager")]
        public Handle<DistrictManager> DistrictManager { get; set; }
        
        [RealName("hiddenReaction")]
        [RealType("Bool")]
        public bool HiddenReaction { get; set; }
        
        [RealName("systemDisabled")]
        [RealType("Bool")]
        public bool SystemDisabled { get; set; }
        
        [RealName("systemLockSources")]
        [RealType("CName")]
        public string[] SystemLockSources { get; set; }
        
        [RealName("deescalationZeroLockExecution")]
        [RealType("Bool")]
        public bool DeescalationZeroLockExecution { get; set; }
        
        [RealName("heatStage")]
        public DumpedEnums.EPreventionHeatStage? HeatStage { get; set; }
        
        [RealName("playerIsInSecurityArea")]
        public GamePersistentID[] PlayerIsInSecurityArea { get; set; }
        
        [RealName("policeSecuritySystems")]
        public GamePersistentID[] PoliceSecuritySystems { get; set; }
        
        [RealName("policeman100SpawnHits")]
        [RealType("Int32")]
        public int Policeman100SpawnHits { get; set; }
        
        [RealName("agentGroupsList")]
        public Handle<PreventionAgents>[] AgentGroupsList { get; set; }
        
        [RealName("agentsWhoSeePlayer")]
        public EntEntityID[] AgentsWhoSeePlayer { get; set; }
        
        [RealName("hitNPC")]
        public SHitNPC[] HitNPC { get; set; }
        
        [RealName("lastCrimePoint")]
        public Vector4 LastCrimePoint { get; set; }
        
        [RealName("DEBUG_lastCrimeDistance")]
        [RealType("Float")]
        public float DEBUG_lastCrimeDistance { get; set; }
        
        [RealName("policemanRandPercent")]
        [RealType("Int32")]
        public int PolicemanRandPercent { get; set; }
        
        [RealName("policemabProbabilityPercent")]
        [RealType("Int32")]
        public int PolicemabProbabilityPercent { get; set; }
        
        [RealName("generalPercent")]
        [RealType("Float")]
        public float GeneralPercent { get; set; }
        
        [RealName("partGeneralPercent")]
        [RealType("Float")]
        public float PartGeneralPercent { get; set; }
        
        [RealName("newDamageValue")]
        [RealType("Float")]
        public float NewDamageValue { get; set; }
        
        [RealName("gameTimeStampPrevious")]
        [RealType("Float")]
        public float GameTimeStampPrevious { get; set; }
        
        [RealName("gameTimeStampLastPoliceRise")]
        [RealType("Float")]
        public float GameTimeStampLastPoliceRise { get; set; }
        
        [RealName("gameTimeStampDeescalationZero")]
        [RealType("Float")]
        public float GameTimeStampDeescalationZero { get; set; }
        
        [RealName("deescalationZeroDelayID")]
        public GameDelayID DeescalationZeroDelayID { get; set; }
        
        [RealName("deescalationZeroCheck")]
        [RealType("Bool")]
        public bool DeescalationZeroCheck { get; set; }
        
        [RealName("policemenSpawnDelayID")]
        public GameDelayID PolicemenSpawnDelayID { get; set; }
        
        [RealName("spawnDelayedEvt")]
        public Handle<PreventionDelayedSpawnRequest> SpawnDelayedEvt { get; set; }
        
        [RealName("preventionTickDelayID")]
        public GameDelayID PreventionTickDelayID { get; set; }
        
        [RealName("preventionTickCheck")]
        [RealType("Bool")]
        public bool PreventionTickCheck { get; set; }
        
        [RealName("securityAreaResetDelayID")]
        public GameDelayID SecurityAreaResetDelayID { get; set; }
        
        [RealName("securityAreaResetCheck")]
        [RealType("Bool")]
        public bool SecurityAreaResetCheck { get; set; }
        
        [RealName("Debug_PorcessReason")]
        public DumpedEnums.EPreventionDebugProcessReason? Debug_PorcessReason { get; set; }
        
        [RealName("Debug_PsychoLogicType")]
        public DumpedEnums.EPreventionPsychoLogicType? Debug_PsychoLogicType { get; set; }
        
        [RealName("currentPreventionPreset")]
        [RealType("TweakDBID")]
        public TweakDbId CurrentPreventionPreset { get; set; }
        
        [RealName("failsafePoliceRecordT1")]
        [RealType("TweakDBID")]
        public TweakDbId FailsafePoliceRecordT1 { get; set; }
        
        [RealName("failsafePoliceRecordT2")]
        [RealType("TweakDBID")]
        public TweakDbId FailsafePoliceRecordT2 { get; set; }
        
        [RealName("failsafePoliceRecordT3")]
        [RealType("TweakDBID")]
        public TweakDbId FailsafePoliceRecordT3 { get; set; }
        
        [RealName("blinkReasonsStack")]
        [RealType("CName")]
        public string[] BlinkReasonsStack { get; set; }
        
        [RealName("onPlayerChoiceCallID")]
        [RealType("Uint32")]
        public uint OnPlayerChoiceCallID { get; set; }
        
        [RealName("playerAttachedCallbackID")]
        [RealType("Uint32")]
        public uint PlayerAttachedCallbackID { get; set; }
        
        [RealName("playerDetachedCallbackID")]
        [RealType("Uint32")]
        public uint PlayerDetachedCallbackID { get; set; }
        
        [RealName("playerHLSID")]
        [RealType("Uint32")]
        public uint PlayerHLSID { get; set; }
        
        [RealName("playerVehicleStateID")]
        [RealType("Uint32")]
        public uint PlayerVehicleStateID { get; set; }
        
        [RealName("playerHLS")]
        [RealType("gamePSMHighLevel")]
        public DumpedEnums.gamePSMHighLevel? PlayerHLS { get; set; }
        
        [RealName("playerVehicleState")]
        [RealType("gamePSMVehicle")]
        public DumpedEnums.gamePSMVehicle? PlayerVehicleState { get; set; }
    }
}
