using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameObject")]
    public class GameObject : EntGameEntity
    {
        [RealName("forceRegisterInHudManager")]
        public bool ForceRegisterInHudManager { get; set; }
        
        [RealName("prereqListeners")]
        public Handle<GameObjectListener>[] PrereqListeners { get; set; }
        
        [RealName("statusEffectListeners")]
        public Handle<StatusEffectTriggerListener>[] StatusEffectListeners { get; set; }
        
        [RealName("outlineRequestsManager")]
        public Handle<OutlineRequestManager> OutlineRequestsManager { get; set; }
        
        [RealName("outlineFadeCounter")]
        public int OutlineFadeCounter { get; set; }
        
        [RealName("fadeOutStarted")]
        public bool FadeOutStarted { get; set; }
        
        [RealName("lastEngineTime")]
        public float LastEngineTime { get; set; }
        
        [RealName("accumulatedTimePasssed")]
        public float AccumulatedTimePasssed { get; set; }
        
        [RealName("scanningComponent")]
        public Handle<GameScanningComponent> ScanningComponent { get; set; }
        
        [RealName("visionComponent")]
        public Handle<GameVisionModeComponent> VisionComponent { get; set; }
        
        [RealName("isHighlightedInFocusMode")]
        public bool IsHighlightedInFocusMode { get; set; }
        
        [RealName("statusEffectComponent")]
        public Handle<GameStatusEffectComponent> StatusEffectComponent { get; set; }
        
        [RealName("lastFrameGreen")]
        public Handle<OutlineRequest> LastFrameGreen { get; set; }
        
        [RealName("lastFrameRed")]
        public Handle<OutlineRequest> LastFrameRed { get; set; }
        
        [RealName("markAsQuest")]
        public bool MarkAsQuest { get; set; }
        
        [RealName("e3HighlightHackStarted")]
        public bool E3HighlightHackStarted { get; set; }
        
        [RealName("e3ObjectRevealed")]
        public bool E3ObjectRevealed { get; set; }
        
        [RealName("forceHighlightSource")]
        public EntEntityID ForceHighlightSource { get; set; }
        
        [RealName("workspotMapper")]
        public Handle<WorkspotMapperComponent> WorkspotMapper { get; set; }
        
        [RealName("stimBroadcaster")]
        public Handle<StimBroadcasterComponent> StimBroadcaster { get; set; }
        
        [RealName("uiSlotComponent")]
        public Handle<EntSlotComponent> UiSlotComponent { get; set; }
        
        [RealName("squadMemberComponent")]
        public Handle<SquadMemberBaseComponent> SquadMemberComponent { get; set; }
        
        [RealName("sourceShootComponent")]
        public Handle<GameSourceShootComponent> SourceShootComponent { get; set; }
        
        [RealName("targetShootComponent")]
        public Handle<GameTargetShootComponent> TargetShootComponent { get; set; }
        
        [RealName("receivedDamageHistory")]
        public DamageHistoryEntry[] ReceivedDamageHistory { get; set; }
        
        [RealName("forceDefeatReward")]
        public bool ForceDefeatReward { get; set; }
        
        [RealName("killRewardDisabled")]
        public bool KillRewardDisabled { get; set; }
        
        [RealName("willDieSoon")]
        public bool WillDieSoon { get; set; }
        
        [RealName("isScannerDataDirty")]
        public bool IsScannerDataDirty { get; set; }
        
        [RealName("hasVisibilityForcedInAnimSystem")]
        public bool HasVisibilityForcedInAnimSystem { get; set; }
        
        [RealName("isDead")]
        public bool IsDead { get; set; }
        
        [RealName("persistentState")]
        public Handle<GamePersistentState> PersistentState { get; set; }
        
        [RealName("displayName")]
        [RealType("LocalizationString")]
        public string DisplayName { get; set; }
        
        [RealName("displayDescription")]
        [RealType("LocalizationString")]
        public string DisplayDescription { get; set; }
        
        [RealName("audioResourceName")]
        public CName AudioResourceName { get; set; }
        
        [RealName("playerSocket")]
        public GamePlayerSocket PlayerSocket { get; set; }
        
        [RealName("visibilityCheckDistance")]
        public float VisibilityCheckDistance { get; set; }
        
        [RealName("tags")]
        public RedTagList Tags { get; set; }
    }
}
