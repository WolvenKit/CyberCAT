using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ReactionManagerComponent")]
    public class ReactionManagerComponent : GameScriptableComponent
    {
        [RealName("activeReaction")]
        public Handle<AIReactionData> ActiveReaction { get; set; }
        
        [RealName("desiredReaction")]
        public Handle<AIReactionData> DesiredReaction { get; set; }
        
        [RealName("stimuliCache")]
        public Handle<SenseStimuliEvent>[] StimuliCache { get; set; }
        
        [RealName("reactionCache")]
        public Handle<AIReactionData>[] ReactionCache { get; set; }
        
        [RealName("reactionPreset")]
        public Handle<GamedataReactionPreset_Record> ReactionPreset { get; set; }
        
        [RealName("puppetReactionBlackboard")]
        public Handle<GameIBlackboard> PuppetReactionBlackboard { get; set; }
        
        [RealName("receivedStimType")]
        public DumpedEnums.gamedataStimType? ReceivedStimType { get; set; }
        
        [RealName("inCrowd")]
        public bool InCrowd { get; set; }
        
        [RealName("inTrafficLane")]
        public bool InTrafficLane { get; set; }
        
        [RealName("desiredFearPhase")]
        public int DesiredFearPhase { get; set; }
        
        [RealName("previousFearPhase")]
        public int PreviousFearPhase { get; set; }
        
        [RealName("NPCRadius")]
        public float NPCRadius { get; set; }
        
        [RealName("bumpTriggerDistanceBufferMounted")]
        public float BumpTriggerDistanceBufferMounted { get; set; }
        
        [RealName("bumpTriggerDistanceBufferCrouched")]
        public float BumpTriggerDistanceBufferCrouched { get; set; }
        
        [RealName("delayReactionEventID")]
        public GameDelayID DelayReactionEventID { get; set; }
        
        [RealName("delay")]
        public Vector2 Delay { get; set; }
        
        [RealName("delayDetectionEventID")]
        public GameDelayID DelayDetectionEventID { get; set; }
        
        [RealName("delayStimEventID")]
        public GameDelayID DelayStimEventID { get; set; }
        
        [RealName("resetReactionDataID")]
        public GameDelayID ResetReactionDataID { get; set; }
        
        [RealName("callingPoliceID")]
        public GameDelayID CallingPoliceID { get; set; }
        
        [RealName("lookatEvent")]
        public Handle<EntLookAtAddEvent> LookatEvent { get; set; }
        
        [RealName("ignoreList")]
        public EntEntityID[] IgnoreList { get; set; }
        
        [RealName("investigationList")]
        public StimEventData[] InvestigationList { get; set; }
        
        [RealName("pendingReaction")]
        public Handle<AIReactionData> PendingReaction { get; set; }
        
        [RealName("ovefloodCooldown")]
        public float OvefloodCooldown { get; set; }
        
        [RealName("stanceState")]
        public DumpedEnums.gamedataNPCStanceState? StanceState { get; set; }
        
        [RealName("highLevelState")]
        public DumpedEnums.gamedataNPCHighLevelState? HighLevelState { get; set; }
        
        [RealName("aiRole")]
        public DumpedEnums.EAIRole? AiRole { get; set; }
        
        [RealName("pendingBehaviorCb")]
        public uint PendingBehaviorCb { get; set; }
        
        [RealName("inPendingBehavior")]
        public bool InPendingBehavior { get; set; }
        
        [RealName("cacheSecuritySysOutput")]
        public Handle<SecuritySystemOutput> CacheSecuritySysOutput { get; set; }
        
        [RealName("environmentalHazards")]
        public Handle<SenseStimuliEvent>[] EnvironmentalHazards { get; set; }
        
        [RealName("environmentalHazardsDelayIDs")]
        public GameDelayID[] EnvironmentalHazardsDelayIDs { get; set; }
        
        [RealName("stolenVehicle")]
        public VehicleBaseObject StolenVehicle { get; set; }
        
        [RealName("isAlertedByDeadBody")]
        public bool IsAlertedByDeadBody { get; set; }
        
        [RealName("isInCrosswalk")]
        public bool IsInCrosswalk { get; set; }
        
        [RealName("owner_id")]
        public EntEntityID Owner_id { get; set; }
        
        [RealName("presetName")]
        public CName PresetName { get; set; }
        
        [RealName("inProcess")]
        public bool InProcess { get; set; }
        
        [RealName("updateByActive")]
        public bool UpdateByActive { get; set; }
        
        [RealName("personalities")]
        public DumpedEnums.gamedataStatType?[] Personalities { get; set; }
        
        [RealName("workspotReactionPlayed")]
        public bool WorkspotReactionPlayed { get; set; }
        
        [RealName("inReactionSequence")]
        public bool InReactionSequence { get; set; }
        
        [RealName("playerProximity")]
        public bool PlayerProximity { get; set; }
        
        [RealName("fearToIdleDistance")]
        public Vector2 FearToIdleDistance { get; set; }
        
        [RealName("exitWorkspotAim")]
        public Vector2 ExitWorkspotAim { get; set; }
        
        [RealName("bumpedRecently")]
        public int BumpedRecently { get; set; }
        
        [RealName("bumpTimestamp")]
        public float BumpTimestamp { get; set; }
        
        [RealName("bumpReactionInProgress")]
        public bool BumpReactionInProgress { get; set; }
        
        [RealName("crowdAimingReactionDistance")]
        public float CrowdAimingReactionDistance { get; set; }
        
        [RealName("fearInPlaceAroundDistance")]
        public float FearInPlaceAroundDistance { get; set; }
        
        [RealName("lookatRepeat")]
        public bool LookatRepeat { get; set; }
        
        [RealName("disturbingComfortZoneInProgress")]
        public bool DisturbingComfortZoneInProgress { get; set; }
        
        [RealName("entereProximityRecently")]
        public int EntereProximityRecently { get; set; }
        
        [RealName("comfortZoneTimestamp")]
        public float ComfortZoneTimestamp { get; set; }
        
        [RealName("disturbComfortZoneEventId")]
        public GameDelayID DisturbComfortZoneEventId { get; set; }
        
        [RealName("checkComfortZoneEventId")]
        public GameDelayID CheckComfortZoneEventId { get; set; }
        
        [RealName("spreadingFearEventId")]
        public GameDelayID SpreadingFearEventId { get; set; }
        
        [RealName("proximityLookatEventId")]
        public GameDelayID ProximityLookatEventId { get; set; }
        
        [RealName("resetFacialEventId")]
        public GameDelayID ResetFacialEventId { get; set; }
        
        [RealName("exitWorkspotSequenceEventId")]
        public GameDelayID ExitWorkspotSequenceEventId { get; set; }
        
        [RealName("fastWalk")]
        public bool FastWalk { get; set; }
        
        [RealName("createThreshold")]
        public bool CreateThreshold { get; set; }
        
        [RealName("initialized")]
        public bool Initialized { get; set; }
        
        [RealName("initCrowd")]
        public bool InitCrowd { get; set; }
        
        [RealName("facialCooldown")]
        public float FacialCooldown { get; set; }
        
        [RealName("disturbComfortZoneAggressiveEventId")]
        public GameDelayID DisturbComfortZoneAggressiveEventId { get; set; }
        
        [RealName("backOffInProgress")]
        public bool BackOffInProgress { get; set; }
        
        [RealName("backOffTimestamp")]
        public float BackOffTimestamp { get; set; }
        
        [RealName("crowdFearStage")]
        public DumpedEnums.gameFearStage? CrowdFearStage { get; set; }
        
        [RealName("fearLocomotionWrapper")]
        public bool FearLocomotionWrapper { get; set; }
        
        [RealName("successfulFearDeescalation")]
        public float SuccessfulFearDeescalation { get; set; }
        
        [RealName("willingToCallPolice")]
        public bool WillingToCallPolice { get; set; }
        
        [RealName("deadBodyInvestigators")]
        public EntEntityID[] DeadBodyInvestigators { get; set; }
        
        [RealName("deadBodyStartingPosition")]
        public Vector4 DeadBodyStartingPosition { get; set; }
        
        [RealName("currentStimThresholdValue")]
        public int CurrentStimThresholdValue { get; set; }
        
        [RealName("timeStampThreshold")]
        public float TimeStampThreshold { get; set; }
        
        [RealName("currentStealthStimThresholdValue")]
        public int CurrentStealthStimThresholdValue { get; set; }
        
        [RealName("stealthTimeStampThreshold")]
        public float StealthTimeStampThreshold { get; set; }
    }
}
