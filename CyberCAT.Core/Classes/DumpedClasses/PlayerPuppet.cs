using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerPuppet")]
    public class PlayerPuppet : ScriptedPuppet
    {
        [RealName("quickSlotsManager")]
        public Handle<QuickSlotsManager> QuickSlotsManager { get; set; }
        
        [RealName("inspectionComponent")]
        public Handle<InspectionComponent> InspectionComponent { get; set; }
        
        [RealName("Phone")]
        public Handle<PlayerPhone> Phone { get; set; }
        
        [RealName("fppCameraComponent")]
        public Handle<GameFPPCameraComponent> FppCameraComponent { get; set; }
        
        [RealName("primaryTargetingComponent")]
        public Handle<GameTargetingComponent> PrimaryTargetingComponent { get; set; }
        
        [RealName("DEBUG_Visualizer")]
        public Handle<DEBUG_VisualizerComponent> DEBUG_Visualizer { get; set; }
        
        [RealName("Debug_DamageInputRec")]
        public Handle<DEBUG_DamageInputReceiver> Debug_DamageInputRec { get; set; }
        
        [RealName("highDamageThreshold")]
        public float HighDamageThreshold { get; set; }
        
        [RealName("medDamageThreshold")]
        public float MedDamageThreshold { get; set; }
        
        [RealName("lowDamageThreshold")]
        public float LowDamageThreshold { get; set; }
        
        [RealName("meleeHighDamageThreshold")]
        public float MeleeHighDamageThreshold { get; set; }
        
        [RealName("meleeMedDamageThreshold")]
        public float MeleeMedDamageThreshold { get; set; }
        
        [RealName("meleeLowDamageThreshold")]
        public float MeleeLowDamageThreshold { get; set; }
        
        [RealName("explosionHighDamageThreshold")]
        public float ExplosionHighDamageThreshold { get; set; }
        
        [RealName("explosionMedDamageThreshold")]
        public float ExplosionMedDamageThreshold { get; set; }
        
        [RealName("explosionLowDamageThreshold")]
        public float ExplosionLowDamageThreshold { get; set; }
        
        [RealName("effectTimeStamp")]
        public float EffectTimeStamp { get; set; }
        
        [RealName("curInventoryWeight")]
        public float CurInventoryWeight { get; set; }
        
        [RealName("healthVfxBlackboard")]
        public Handle<WorldEffectBlackboard> HealthVfxBlackboard { get; set; }
        
        [RealName("laserTargettingVfxBlackboard")]
        public Handle<WorldEffectBlackboard> LaserTargettingVfxBlackboard { get; set; }
        
        [RealName("itemLogBlackboard")]
        public Handle<GameIBlackboard> ItemLogBlackboard { get; set; }
        
        [RealName("lastScanTarget")]
        public GameObject LastScanTarget { get; set; }
        
        [RealName("meleeSelectInputProcessed")]
        public bool MeleeSelectInputProcessed { get; set; }
        
        [RealName("waitingForDelayEvent")]
        public bool WaitingForDelayEvent { get; set; }
        
        [RealName("randomizedTime")]
        public float RandomizedTime { get; set; }
        
        [RealName("isResetting")]
        public bool IsResetting { get; set; }
        
        [RealName("delayEventID")]
        public GameDelayID DelayEventID { get; set; }
        
        [RealName("resetTickID")]
        public GameDelayID ResetTickID { get; set; }
        
        [RealName("katanaAnimProgression")]
        public float KatanaAnimProgression { get; set; }
        
        [RealName("coverModifierActive")]
        public bool CoverModifierActive { get; set; }
        
        [RealName("workspotDamageReductionActive")]
        public bool WorkspotDamageReductionActive { get; set; }
        
        [RealName("workspotVisibilityReductionActive")]
        public bool WorkspotVisibilityReductionActive { get; set; }
        
        [RealName("currentPlayerWorkspotTags")]
        public CName[] CurrentPlayerWorkspotTags { get; set; }
        
        [RealName("incapacitated")]
        public bool Incapacitated { get; set; }
        
        [RealName("remoteMappinId")]
        public GameNewMappinID RemoteMappinId { get; set; }
        
        [RealName("CPOMissionDataState")]
        public Handle<CPOMissionDataState> CPOMissionDataState { get; set; }
        
        [RealName("CPOMissionDataBbId")]
        public uint CPOMissionDataBbId { get; set; }
        
        [RealName("visibilityListener")]
        public Handle<VisibilityStatListener> VisibilityListener { get; set; }
        
        [RealName("secondHeartListener")]
        public Handle<SecondHeartStatListener> SecondHeartListener { get; set; }
        
        [RealName("armorStatListener")]
        public Handle<ArmorStatListener> ArmorStatListener { get; set; }
        
        [RealName("healthStatListener")]
        public Handle<HealthStatListener> HealthStatListener { get; set; }
        
        [RealName("oxygenStatListener")]
        public Handle<OxygenStatListener> OxygenStatListener { get; set; }
        
        [RealName("aimAssistListener")]
        public Handle<AimAssistSettingsListener> AimAssistListener { get; set; }
        
        [RealName("autoRevealListener")]
        public Handle<AutoRevealStatListener> AutoRevealListener { get; set; }
        
        [RealName("isTalkingOnPhone")]
        public bool IsTalkingOnPhone { get; set; }
        
        [RealName("DataDamageUpdateID")]
        public GameDelayID DataDamageUpdateID { get; set; }
        
        [RealName("playerAttachedCallbackID")]
        public uint PlayerAttachedCallbackID { get; set; }
        
        [RealName("playerDetachedCallbackID")]
        public uint PlayerDetachedCallbackID { get; set; }
        
        [RealName("combatStateListener")]
        public uint CombatStateListener { get; set; }
        
        [RealName("LocomotionStateListener")]
        public uint LocomotionStateListener { get; set; }
        
        [RealName("numberOfCombatantsListenerID")]
        public uint NumberOfCombatantsListenerID { get; set; }
        
        [RealName("numberOfCombatants")]
        public int NumberOfCombatants { get; set; }
        
        [RealName("zoneChangeListener")]
        public uint ZoneChangeListener { get; set; }
        
        [RealName("equipmentMeshOverlayEffectName")]
        public CName EquipmentMeshOverlayEffectName { get; set; }
        
        [RealName("equipmentMeshOverlayEffectTag")]
        public CName EquipmentMeshOverlayEffectTag { get; set; }
        
        [RealName("equipmentMeshOverlaySlots")]
        public TweakDbId[] EquipmentMeshOverlaySlots { get; set; }
        
        [RealName("coverVisibilityPerkBlocked")]
        public bool CoverVisibilityPerkBlocked { get; set; }
        
        [RealName("behindCover")]
        public bool BehindCover { get; set; }
        
        [RealName("inCombat")]
        public bool InCombat { get; set; }
        
        [RealName("hasBeenDetected")]
        public bool HasBeenDetected { get; set; }
        
        [RealName("inCrouch")]
        public bool InCrouch { get; set; }
        
        [RealName("gunshotRange")]
        public float GunshotRange { get; set; }
        
        [RealName("explosionRange")]
        public float ExplosionRange { get; set; }
        
        [RealName("nextBufferModifier")]
        public int NextBufferModifier { get; set; }
        
        [RealName("attackingNetrunnerID")]
        public EntEntityID AttackingNetrunnerID { get; set; }
        
        [RealName("NPCDeathInstigator")]
        public NPCPuppet NPCDeathInstigator { get; set; }
        
        [RealName("bestTargettingWeapon")]
        public GameweaponObject BestTargettingWeapon { get; set; }
        
        [RealName("bestTargettingDot")]
        public float BestTargettingDot { get; set; }
        
        [RealName("targettingEnemies")]
        public int TargettingEnemies { get; set; }
        
        [RealName("coverRecordID")]
        public TweakDbId CoverRecordID { get; set; }
        
        [RealName("damageReductionRecordID")]
        public TweakDbId DamageReductionRecordID { get; set; }
        
        [RealName("visReductionRecordID")]
        public TweakDbId VisReductionRecordID { get; set; }
        
        [RealName("lastDmgInflicted")]
        public EngineTime LastDmgInflicted { get; set; }
        
        [RealName("lowHealthNextRumbleTime")]
        public float LowHealthNextRumbleTime { get; set; }
        
        [RealName("staminaListener")]
        public Handle<StaminaListener> StaminaListener { get; set; }
        
        [RealName("memoryListener")]
        public Handle<MemoryListener> MemoryListener { get; set; }
        
        [RealName("securityAreaTypeE3HACK")]
        public DumpedEnums.ESecurityAreaType? SecurityAreaTypeE3HACK { get; set; }
        
        [RealName("overlappedSecurityZones")]
        public GamePersistentID[] OverlappedSecurityZones { get; set; }
        
        [RealName("interestingFacts")]
        public InterestingFacts InterestingFacts { get; set; }
        
        [RealName("interestingFactsListenersIds")]
        public InterestingFactsListenersIds InterestingFactsListenersIds { get; set; }
        
        [RealName("interestingFactsListenersFunctions")]
        public InterestingFactsListenersFunctions InterestingFactsListenersFunctions { get; set; }
        
        [RealName("visionModeController")]
        public Handle<PlayerVisionModeController> VisionModeController { get; set; }
        
        [RealName("cachedGameplayRestrictions")]
        public TweakDbId[] CachedGameplayRestrictions { get; set; }
        
        [RealName("delayEndGracePeriodAfterSpawnEventID")]
        public GameDelayID DelayEndGracePeriodAfterSpawnEventID { get; set; }
        
        [RealName("bossThatTargetsPlayer")]
        public EntEntityID BossThatTargetsPlayer { get; set; }
        
        [RealName("choiceTokenTextLayerId")]
        public uint ChoiceTokenTextLayerId { get; set; }
        
        [RealName("choiceTokenTextDrawn")]
        public bool ChoiceTokenTextDrawn { get; set; }
    }
}
