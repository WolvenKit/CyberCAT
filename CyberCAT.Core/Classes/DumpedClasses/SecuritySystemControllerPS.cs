using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecuritySystemControllerPS")]
    public class SecuritySystemControllerPS : DeviceSystemBaseControllerPS
    {
        [RealName("level_0")]
        public SecurityAccessLevelEntry[] Level_0 { get; set; }
        
        [RealName("level_1")]
        public SecurityAccessLevelEntry[] Level_1 { get; set; }
        
        [RealName("level_2")]
        public SecurityAccessLevelEntry[] Level_2 { get; set; }
        
        [RealName("level_3")]
        public SecurityAccessLevelEntry[] Level_3 { get; set; }
        
        [RealName("level_4")]
        public SecurityAccessLevelEntry[] Level_4 { get; set; }
        
        [RealName("allowSecuritySystemToDisableItself")]
        public bool AllowSecuritySystemToDisableItself { get; set; }
        
        [RealName("attitudeGroup")]
        public TweakDbId AttitudeGroup { get; set; }
        
        [RealName("suppressAbilityToModifyAttitude")]
        public bool SuppressAbilityToModifyAttitude { get; set; }
        
        [RealName("attitudeChangeMode")]
        public DumpedEnums.EShouldChangeAttitude? AttitudeChangeMode { get; set; }
        
        [RealName("performAutomaticResetAfter")]
        public Time PerformAutomaticResetAfter { get; set; }
        
        [RealName("hideAreasOnMinimap")]
        public bool HideAreasOnMinimap { get; set; }
        
        [RealName("isUnderStrictQuestControl")]
        public bool IsUnderStrictQuestControl { get; set; }
        
        [RealName("securitySystemState")]
        public DumpedEnums.ESecuritySystemState? SecuritySystemState { get; set; }
        
        [RealName("agentsRegistry")]
        public Handle<AgentRegistry> AgentsRegistry { get; set; }
        
        [RealName("securitySystem")]
        public Handle<SecuritySystemControllerPS> SecuritySystem { get; set; }
        
        [RealName("latestOutputEngineTime")]
        public float LatestOutputEngineTime { get; set; }
        
        [RealName("updateInterval")]
        public float UpdateInterval { get; set; }
        
        [RealName("restartDuration")]
        public int RestartDuration { get; set; }
        
        [RealName("protectedEntityIDs")]
        public EntEntityID[] ProtectedEntityIDs { get; set; }
        
        [RealName("entitiesRemainingAtGate")]
        public EntEntityID[] EntitiesRemainingAtGate { get; set; }
        
        [RealName("blacklist")]
        public Handle<BlacklistEntry>[] Blacklist { get; set; }
        
        [RealName("currentReprimandID")]
        public int CurrentReprimandID { get; set; }
        
        [RealName("blacklistDelayValid")]
        public bool BlacklistDelayValid { get; set; }
        
        [RealName("blacklistDelayID")]
        public GameDelayID BlacklistDelayID { get; set; }
        
        [RealName("maxGlobalWarningsCount")]
        public int MaxGlobalWarningsCount { get; set; }
        
        [RealName("delayIDValid")]
        public bool DelayIDValid { get; set; }
        
        [RealName("deescalationEventID")]
        public GameDelayID DeescalationEventID { get; set; }
        
        [RealName("outputsSend")]
        public int OutputsSend { get; set; }
        
        [RealName("inputsReceived")]
        public int InputsReceived { get; set; }
    }
}
