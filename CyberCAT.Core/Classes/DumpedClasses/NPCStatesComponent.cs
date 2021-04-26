using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NPCStatesComponent")]
    public class NPCStatesComponent : GameAINetStateComponent
    {
        [RealName("aimingLookatEvent")]
        public Handle<EntLookAtAddEvent> AimingLookatEvent { get; set; }
        
        [RealName("highLevelAnimFeatureName")]
        public CName HighLevelAnimFeatureName { get; set; }
        
        [RealName("upperBodyAnimFeatureName")]
        public CName UpperBodyAnimFeatureName { get; set; }
        
        [RealName("stanceAnimFeatureName")]
        public CName StanceAnimFeatureName { get; set; }
        
        [RealName("statFlagDefensiveState")]
        public Handle<GameStatModifierData> StatFlagDefensiveState { get; set; }
        
        [RealName("prevNPCStanceState")]
        public DumpedEnums.gamedataNPCStanceState? PrevNPCStanceState { get; set; }
        
        [RealName("previousHighLevelState")]
        public DumpedEnums.gamedataNPCHighLevelState? PreviousHighLevelState { get; set; }
        
        [RealName("prevHitReactionMode")]
        public DumpedEnums.EHitReactionMode? PrevHitReactionMode { get; set; }
        
        [RealName("bulkyStaggerMinRecordID")]
        public TweakDbId BulkyStaggerMinRecordID { get; set; }
        
        [RealName("staggerMinRecordID")]
        public TweakDbId StaggerMinRecordID { get; set; }
        
        [RealName("unstoppableRecordID")]
        public TweakDbId UnstoppableRecordID { get; set; }
        
        [RealName("unstoppableTwitchMinRecordID")]
        public TweakDbId UnstoppableTwitchMinRecordID { get; set; }
        
        [RealName("unstoppableTwitchNoneRecordID")]
        public TweakDbId UnstoppableTwitchNoneRecordID { get; set; }
        
        [RealName("forceImpactRecordID")]
        public TweakDbId ForceImpactRecordID { get; set; }
        
        [RealName("forceStaggerRecordID")]
        public TweakDbId ForceStaggerRecordID { get; set; }
        
        [RealName("forceKnockdownRecordID")]
        public TweakDbId ForceKnockdownRecordID { get; set; }
        
        [RealName("fragileRecordID")]
        public TweakDbId FragileRecordID { get; set; }
        
        [RealName("weakRecordID")]
        public TweakDbId WeakRecordID { get; set; }
        
        [RealName("toughRecordID")]
        public TweakDbId ToughRecordID { get; set; }
        
        [RealName("bulkyRecordID")]
        public TweakDbId BulkyRecordID { get; set; }
        
        [RealName("regularRecordID")]
        public TweakDbId RegularRecordID { get; set; }
        
        [RealName("inCombat")]
        public bool InCombat { get; set; }
    }
}
