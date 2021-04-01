using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NPCPuppet")]
    public class NPCPuppet : ScriptedPuppet
    {
        [RealName("lastHitEvent")]
        public Handle<GameeventsHitEvent> LastHitEvent { get; set; }
        
        [RealName("totalFrameReactionDamageReceived")]
        public float TotalFrameReactionDamageReceived { get; set; }
        
        [RealName("totalFrameWoundsDamageReceived")]
        public float TotalFrameWoundsDamageReceived { get; set; }
        
        [RealName("totalFrameDismembermentDamageReceived")]
        public float TotalFrameDismembermentDamageReceived { get; set; }
        
        [RealName("hitEventLock")]
        public ScriptReentrantRWLock HitEventLock { get; set; }
        
        [RealName("NPCManager")]
        public Handle<NPCManager> NPCManager { get; set; }
        
        [RealName("customDeathDirection")]
        public int CustomDeathDirection { get; set; }
        
        [RealName("deathOverrideState")]
        public bool DeathOverrideState { get; set; }
        
        [RealName("agonyState")]
        public bool AgonyState { get; set; }
        
        [RealName("defensiveState")]
        public bool DefensiveState { get; set; }
        
        [RealName("lastSetupWorkspotActionEvent")]
        public Handle<GameSetupWorkspotActionEvent> LastSetupWorkspotActionEvent { get; set; }
        
        [RealName("wasJustKilledOrDefeated")]
        public bool WasJustKilledOrDefeated { get; set; }
        
        [RealName("shouldDie")]
        public bool ShouldDie { get; set; }
        
        [RealName("shouldBeDefeated")]
        public bool ShouldBeDefeated { get; set; }
        
        [RealName("sentDownedEvent")]
        public bool SentDownedEvent { get; set; }
        
        [RealName("isRagdolling")]
        public bool IsRagdolling { get; set; }
        
        [RealName("hasAnimatedRagdoll")]
        public bool HasAnimatedRagdoll { get; set; }
        
        [RealName("disableCollisionRequested")]
        public bool DisableCollisionRequested { get; set; }
        
        [RealName("ragdollInstigator")]
        public GameObject RagdollInstigator { get; set; }
        
        [RealName("ragdollSplattersSpawned")]
        public int RagdollSplattersSpawned { get; set; }
        
        [RealName("ragdollFloorSplashSpawned")]
        public bool RagdollFloorSplashSpawned { get; set; }
        
        [RealName("ragdollImpactData")]
        public EntRagdollImpactPointData RagdollImpactData { get; set; }
        
        [RealName("ragdollDamageData")]
        public RagdollDamagePollData RagdollDamageData { get; set; }
        
        [RealName("ragdollInitialPosition")]
        public Vector4 RagdollInitialPosition { get; set; }
        
        [RealName("ragdollActivationTimestamp")]
        public float RagdollActivationTimestamp { get; set; }
        
        [RealName("ragdolledEntities")]
        public EntEntity[] RagdolledEntities { get; set; }
        
        [RealName("isNotVisible")]
        public bool IsNotVisible { get; set; }
        
        [RealName("deathListener")]
        public Handle<NPCDeathListener> DeathListener { get; set; }
        
        [RealName("godModeStatListener")]
        public Handle<NPCGodModeListener> GodModeStatListener { get; set; }
        
        [RealName("npcCollisionComponent")]
        public Handle<EntSimpleColliderComponent> NpcCollisionComponent { get; set; }
        
        [RealName("npcRagdollComponent")]
        public Handle<EntIComponent> NpcRagdollComponent { get; set; }
        
        [RealName("npcTraceObstacleComponent")]
        public Handle<EntSimpleColliderComponent> NpcTraceObstacleComponent { get; set; }
        
        [RealName("npcMountedToPlayerComponents")]
        public Handle<EntIComponent>[] NpcMountedToPlayerComponents { get; set; }
        
        [RealName("scavengeComponent")]
        public Handle<ScavengeComponent> ScavengeComponent { get; set; }
        
        [RealName("influenceComponent")]
        public Handle<GameinfluenceComponent> InfluenceComponent { get; set; }
        
        [RealName("comfortZoneComponent")]
        public Handle<EntIComponent> ComfortZoneComponent { get; set; }
        
        [RealName("isTargetingPlayer")]
        public bool IsTargetingPlayer { get; set; }
        
        [RealName("playerStatsListener")]
        public Handle<GameScriptStatsListener> PlayerStatsListener { get; set; }
        
        [RealName("upperBodyStateCallbackID")]
        public uint UpperBodyStateCallbackID { get; set; }
        
        [RealName("leftCyberwareStateCallbackID")]
        public uint LeftCyberwareStateCallbackID { get; set; }
        
        [RealName("meleeStateCallbackID")]
        public uint MeleeStateCallbackID { get; set; }
        
        [RealName("combatGadgetStateCallbackID")]
        public uint CombatGadgetStateCallbackID { get; set; }
        
        [RealName("wasAimedAtLast")]
        public bool WasAimedAtLast { get; set; }
        
        [RealName("wasCWChargedAtLast")]
        public bool WasCWChargedAtLast { get; set; }
        
        [RealName("wasMeleeChargedAtLast")]
        public bool WasMeleeChargedAtLast { get; set; }
        
        [RealName("wasChargingGadgetAtLast")]
        public bool WasChargingGadgetAtLast { get; set; }
        
        [RealName("isLookedAt")]
        public bool IsLookedAt { get; set; }
        
        [RealName("cachedPlayerID")]
        public EntEntityID CachedPlayerID { get; set; }
        
        [RealName("canGoThroughDoors")]
        public bool CanGoThroughDoors { get; set; }
        
        [RealName("lastStatusEffectSignalSent")]
        public GamedataStatusEffect_Record LastStatusEffectSignalSent { get; set; }
        
        [RealName("cachedStatusEffectAnim")]
        public GamedataStatusEffect_Record CachedStatusEffectAnim { get; set; }
        
        [RealName("resendStatusEffectSignalDelayID")]
        public GameDelayID ResendStatusEffectSignalDelayID { get; set; }
        
        [RealName("lastSEAppliedByPlayer")]
        public Handle<GameStatusEffect> LastSEAppliedByPlayer { get; set; }
        
        [RealName("pendingSEEvent")]
        public Handle<GameeventsApplyStatusEffectEvent> PendingSEEvent { get; set; }
        
        [RealName("bounty")]
        public Bounty Bounty { get; set; }
        
        [RealName("cachedVFXList")]
        public GamedataStatusEffectFX_Record[] CachedVFXList { get; set; }
        
        [RealName("cachedSFXList")]
        public GamedataStatusEffectFX_Record[] CachedSFXList { get; set; }
        
        [RealName("isThrowingGrenadeToPlayer")]
        public bool IsThrowingGrenadeToPlayer { get; set; }
        
        [RealName("throwingGrenadeDelayEventID")]
        public GameDelayID ThrowingGrenadeDelayEventID { get; set; }
        
        [RealName("myKiller")]
        public GameObject MyKiller { get; set; }
        
        [RealName("primaryThreatCalculationType")]
        public DumpedEnums.EAIThreatCalculationType? PrimaryThreatCalculationType { get; set; }
        
        [RealName("temporaryThreatCalculationType")]
        public DumpedEnums.EAIThreatCalculationType? TemporaryThreatCalculationType { get; set; }
        
        [RealName("isPlayerCompanionCached")]
        public bool IsPlayerCompanionCached { get; set; }
        
        [RealName("isPlayerCompanionCachedTimeStamp")]
        public float IsPlayerCompanionCachedTimeStamp { get; set; }
        
        [RealName("quickHackEffectsApplied")]
        public uint QuickHackEffectsApplied { get; set; }
        
        [RealName("hackingResistanceMod")]
        public Handle<GameConstantStatModifierData> HackingResistanceMod { get; set; }
        
        [RealName("delayNonStealthQuickHackVictimEventID")]
        public GameDelayID DelayNonStealthQuickHackVictimEventID { get; set; }
        
        [RealName("cachedIsPaperdoll")]
        public int CachedIsPaperdoll { get; set; }
        
        [RealName("smartDespawnDelayID")]
        public GameDelayID SmartDespawnDelayID { get; set; }
        
        [RealName("despawnTicks")]
        public uint DespawnTicks { get; set; }
    }
}
