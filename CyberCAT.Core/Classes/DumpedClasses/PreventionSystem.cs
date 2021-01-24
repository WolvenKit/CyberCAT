using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PreventionSystem")]
    public class PreventionSystem : GameScriptableSystem
    {
        [RealName("districtManager")]
        public Handle<DistrictManager> DistrictManager { get; set; }
        
        [RealName("hiddenReaction")]
        public bool HiddenReaction { get; set; }
        
        [RealName("systemDisabled")]
        public bool SystemDisabled { get; set; }
        
        [RealName("systemLockSources")]
        public CName[] SystemLockSources { get; set; }
        
        [RealName("deescalationZeroLockExecution")]
        public bool DeescalationZeroLockExecution { get; set; }
        
        [RealName("heatStage")]
        public DumpedEnums.EPreventionHeatStage? HeatStage { get; set; }
        
        [RealName("playerIsInSecurityArea")]
        public GamePersistentID[] PlayerIsInSecurityArea { get; set; }
        
        [RealName("policeSecuritySystems")]
        public GamePersistentID[] PoliceSecuritySystems { get; set; }
        
        [RealName("policeman100SpawnHits")]
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
        public float DEBUG_lastCrimeDistance { get; set; }
        
        [RealName("policemanRandPercent")]
        public int PolicemanRandPercent { get; set; }
        
        [RealName("policemabProbabilityPercent")]
        public int PolicemabProbabilityPercent { get; set; }
        
        [RealName("generalPercent")]
        public float GeneralPercent { get; set; }
        
        [RealName("partGeneralPercent")]
        public float PartGeneralPercent { get; set; }
        
        [RealName("newDamageValue")]
        public float NewDamageValue { get; set; }
        
        [RealName("gameTimeStampPrevious")]
        public float GameTimeStampPrevious { get; set; }
        
        [RealName("gameTimeStampLastPoliceRise")]
        public float GameTimeStampLastPoliceRise { get; set; }
        
        [RealName("gameTimeStampDeescalationZero")]
        public float GameTimeStampDeescalationZero { get; set; }
        
        [RealName("deescalationZeroDelayID")]
        public GameDelayID DeescalationZeroDelayID { get; set; }
        
        [RealName("deescalationZeroCheck")]
        public bool DeescalationZeroCheck { get; set; }
        
        [RealName("policemenSpawnDelayID")]
        public GameDelayID PolicemenSpawnDelayID { get; set; }
        
        [RealName("spawnDelayedEvt")]
        public Handle<PreventionDelayedSpawnRequest> SpawnDelayedEvt { get; set; }
        
        [RealName("preventionTickDelayID")]
        public GameDelayID PreventionTickDelayID { get; set; }
        
        [RealName("preventionTickCheck")]
        public bool PreventionTickCheck { get; set; }
        
        [RealName("securityAreaResetDelayID")]
        public GameDelayID SecurityAreaResetDelayID { get; set; }
        
        [RealName("securityAreaResetCheck")]
        public bool SecurityAreaResetCheck { get; set; }
        
        [RealName("Debug_PorcessReason")]
        public DumpedEnums.EPreventionDebugProcessReason? Debug_PorcessReason { get; set; }
        
        [RealName("Debug_PsychoLogicType")]
        public DumpedEnums.EPreventionPsychoLogicType? Debug_PsychoLogicType { get; set; }
        
        [RealName("currentPreventionPreset")]
        public TweakDbId CurrentPreventionPreset { get; set; }
        
        [RealName("failsafePoliceRecordT1")]
        public TweakDbId FailsafePoliceRecordT1 { get; set; }
        
        [RealName("failsafePoliceRecordT2")]
        public TweakDbId FailsafePoliceRecordT2 { get; set; }
        
        [RealName("failsafePoliceRecordT3")]
        public TweakDbId FailsafePoliceRecordT3 { get; set; }
        
        [RealName("blinkReasonsStack")]
        public CName[] BlinkReasonsStack { get; set; }
        
        [RealName("onPlayerChoiceCallID")]
        public uint OnPlayerChoiceCallID { get; set; }
        
        [RealName("playerAttachedCallbackID")]
        public uint PlayerAttachedCallbackID { get; set; }
        
        [RealName("playerDetachedCallbackID")]
        public uint PlayerDetachedCallbackID { get; set; }
        
        [RealName("playerHLSID")]
        public uint PlayerHLSID { get; set; }
        
        [RealName("playerVehicleStateID")]
        public uint PlayerVehicleStateID { get; set; }
        
        [RealName("playerHLS")]
        [RealType("gamePSMHighLevel")]
        public DumpedEnums.gamePSMHighLevel? PlayerHLS { get; set; }
        
        [RealName("playerVehicleState")]
        [RealType("gamePSMVehicle")]
        public DumpedEnums.gamePSMVehicle? PlayerVehicleState { get; set; }
    }
}
