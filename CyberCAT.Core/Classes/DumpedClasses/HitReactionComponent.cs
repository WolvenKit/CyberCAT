using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HitReactionComponent")]
    public class HitReactionComponent : AIMandatoryComponents
    {
        [RealName("impactDamageDuration")]
        public float ImpactDamageDuration { get; set; }
        
        [RealName("staggerDamageDuration")]
        public float StaggerDamageDuration { get; set; }
        
        [RealName("impactDamageDurationMelee")]
        public float ImpactDamageDurationMelee { get; set; }
        
        [RealName("staggerDamageDurationMelee")]
        public float StaggerDamageDurationMelee { get; set; }
        
        [RealName("knockdownDamageDuration")]
        public float KnockdownDamageDuration { get; set; }
        
        [RealName("defeatedMinDuration")]
        public float DefeatedMinDuration { get; set; }
        
        [RealName("previousHitTime")]
        public float PreviousHitTime { get; set; }
        
        [RealName("reactionType")]
        public DumpedEnums.animHitReactionType? ReactionType { get; set; }
        
        [RealName("animHitReaction")]
        public Handle<AnimAnimFeature_HitReactionsData> AnimHitReaction { get; set; }
        
        [RealName("lastAnimHitReaction")]
        public Handle<AnimAnimFeature_HitReactionsData> LastAnimHitReaction { get; set; }
        
        [RealName("hitReactionAction")]
        public Handle<ActionHitReactionScriptProxy> HitReactionAction { get; set; }
        
        [RealName("previousAnimHitReactionArray")]
        public ScriptHitData[] PreviousAnimHitReactionArray { get; set; }
        
        [RealName("lastHitReactionPlayed")]
        public DumpedEnums.EAILastHitReactionPlayed? LastHitReactionPlayed { get; set; }
        
        [RealName("hitShapeData")]
        public GameShapeData HitShapeData { get; set; }
        
        [RealName("animVariation")]
        public int AnimVariation { get; set; }
        
        [RealName("specificHitTimeout")]
        public float SpecificHitTimeout { get; set; }
        
        [RealName("quickMeleeCooldown")]
        public float QuickMeleeCooldown { get; set; }
        
        [RealName("dismembermentBodyPartDamageThreshold")]
        public float[] DismembermentBodyPartDamageThreshold { get; set; }
        
        [RealName("woundedBodyPartDamageThreshold")]
        public float[] WoundedBodyPartDamageThreshold { get; set; }
        
        [RealName("defeatedBodyPartDamageThreshold")]
        public float[] DefeatedBodyPartDamageThreshold { get; set; }
        
        [RealName("impactDamageThreshold")]
        public float ImpactDamageThreshold { get; set; }
        
        [RealName("staggerDamageThreshold")]
        public float StaggerDamageThreshold { get; set; }
        
        [RealName("knockdownDamageThreshold")]
        public float KnockdownDamageThreshold { get; set; }
        
        [RealName("knockdownImpulseThreshold")]
        public float KnockdownImpulseThreshold { get; set; }
        
        [RealName("immuneToKnockDown")]
        public bool ImmuneToKnockDown { get; set; }
        
        [RealName("hitComboReset")]
        public float HitComboReset { get; set; }
        
        [RealName("physicalImpulseReset")]
        public float PhysicalImpulseReset { get; set; }
        
        [RealName("cumulatedDamages")]
        public float CumulatedDamages { get; set; }
        
        [RealName("bodyPartWoundCumulatedDamages")]
        public float[] BodyPartWoundCumulatedDamages { get; set; }
        
        [RealName("bodyPartDismemberCumulatedDamages")]
        public float[] BodyPartDismemberCumulatedDamages { get; set; }
        
        [RealName("overrideHitReactionImpulse")]
        public float OverrideHitReactionImpulse { get; set; }
        
        [RealName("cumulatedPhysicalImpulse")]
        public float CumulatedPhysicalImpulse { get; set; }
        
        [RealName("comboResetTime")]
        public float ComboResetTime { get; set; }
        
        [RealName("ragdollImpulse")]
        public float RagdollImpulse { get; set; }
        
        [RealName("hitIntensity")]
        public DumpedEnums.EAIHitIntensity? HitIntensity { get; set; }
        
        [RealName("previousMeleeHitTimeStamp")]
        public float PreviousMeleeHitTimeStamp { get; set; }
        
        [RealName("previousRangedHitTimeStamp")]
        public float PreviousRangedHitTimeStamp { get; set; }
        
        [RealName("previousBlockTimeStamp")]
        public float PreviousBlockTimeStamp { get; set; }
        
        [RealName("previousParryTimeStamp")]
        public float PreviousParryTimeStamp { get; set; }
        
        [RealName("previousDodgeTimeStamp")]
        public float PreviousDodgeTimeStamp { get; set; }
        
        [RealName("blockCount")]
        public int BlockCount { get; set; }
        
        [RealName("parryCount")]
        public int ParryCount { get; set; }
        
        [RealName("dodgeCount")]
        public int DodgeCount { get; set; }
        
        [RealName("hitCount")]
        public uint HitCount { get; set; }
        
        [RealName("defeatedHasBeenPlayed")]
        public bool DefeatedHasBeenPlayed { get; set; }
        
        [RealName("deathHasBeenPlayed")]
        public bool DeathHasBeenPlayed { get; set; }
        
        [RealName("deathRegisteredTime")]
        public float DeathRegisteredTime { get; set; }
        
        [RealName("extendedDeathRegisteredTime")]
        public float ExtendedDeathRegisteredTime { get; set; }
        
        [RealName("extendedDeathDelayRegisteredTime")]
        public float ExtendedDeathDelayRegisteredTime { get; set; }
        
        [RealName("disableDismembermentAfterDeathDelay")]
        public float DisableDismembermentAfterDeathDelay { get; set; }
        
        [RealName("extendedHitReactionRegisteredTime")]
        public float ExtendedHitReactionRegisteredTime { get; set; }
        
        [RealName("extendedHitReactionDelayRegisteredTime")]
        public float ExtendedHitReactionDelayRegisteredTime { get; set; }
        
        [RealName("scatteredGuts")]
        public bool ScatteredGuts { get; set; }
        
        [RealName("cumulativeDamageUpdateInterval")]
        public float CumulativeDamageUpdateInterval { get; set; }
        
        [RealName("cumulativeDamageUpdateRequested")]
        public bool CumulativeDamageUpdateRequested { get; set; }
        
        [RealName("currentStimId")]
        public uint CurrentStimId { get; set; }
        
        [RealName("attackData")]
        public Handle<GamedamageAttackData> AttackData { get; set; }
        
        [RealName("hitPosition")]
        public Vector4 HitPosition { get; set; }
        
        [RealName("hitDirection")]
        public Vector4 HitDirection { get; set; }
        
        [RealName("lastHitReactionBehaviorData")]
        public Handle<HitReactionBehaviorData> LastHitReactionBehaviorData { get; set; }
        
        [RealName("lastStimName")]
        public CName LastStimName { get; set; }
        
        [RealName("deathStimName")]
        public CName DeathStimName { get; set; }
        
        [RealName("meleeHitCount")]
        public int MeleeHitCount { get; set; }
        
        [RealName("strongMeleeHitCount")]
        public int StrongMeleeHitCount { get; set; }
        
        [RealName("maxHitChainForMelee")]
        public int MaxHitChainForMelee { get; set; }
        
        [RealName("maxHitChainForRanged")]
        public int MaxHitChainForRanged { get; set; }
        
        [RealName("isAlive")]
        public bool IsAlive { get; set; }
        
        [RealName("frameDamageHealthFactor")]
        public float FrameDamageHealthFactor { get; set; }
        
        [RealName("hitCountData")]
        public float HitCountData { get; set; }
        
        [RealName("hitCountArrayEnd")]
        public int HitCountArrayEnd { get; set; }
        
        [RealName("hitCountArrayCurrent")]
        public int HitCountArrayCurrent { get; set; }
        
        [RealName("indicatorEnabledBlackboardId")]
        public uint IndicatorEnabledBlackboardId { get; set; }
        
        [RealName("hitIndicatorEnabled")]
        public bool HitIndicatorEnabled { get; set; }
        
        [RealName("hasBeenWounded")]
        public bool HasBeenWounded { get; set; }
        
        [RealName("hitReactionData")]
        public Handle<AnimAnimFeature_HitReactionsData> HitReactionData { get; set; }
    }
}
