using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScriptedPuppetPS")]
    public class ScriptedPuppetPS : GamePuppetPS
    {
        [RealName("cooldownStorage")]
        public Handle<CooldownStorage> CooldownStorage { get; set; }
        
        [RealName("isInitialized")]
        public DumpedEnums.EBOOL? IsInitialized { get; set; }
        
        [RealName("wasAttached")]
        [RealType("Bool")]
        public bool WasAttached { get; set; }
        
        [RealName("wasRevealedInNetworkPing")]
        [RealType("Bool")]
        public bool WasRevealedInNetworkPing { get; set; }
        
        [RealName("numberActions")]
        [RealType("Int32")]
        public int NumberActions { get; set; }
        
        [RealName("wasQuickHackAttempt")]
        [RealType("Bool")]
        public bool WasQuickHackAttempt { get; set; }
        
        [RealName("hasDirectInteractionChoicesActive")]
        [RealType("Bool")]
        public bool HasDirectInteractionChoicesActive { get; set; }
        
        [RealName("wasIncapacitated")]
        [RealType("Bool")]
        public bool WasIncapacitated { get; set; }
        
        [RealName("isBreached")]
        [RealType("Bool")]
        public bool IsBreached { get; set; }
        
        [RealName("isDead")]
        [RealType("Bool")]
        public bool IsDead { get; set; }
        
        [RealName("isIncapacitated")]
        [RealType("Bool")]
        public bool IsIncapacitated { get; set; }
        
        [RealName("isAndroidTurnedOff")]
        [RealType("Bool")]
        public bool IsAndroidTurnedOff { get; set; }
        
        [RealName("securitySystemData")]
        public SecuritySystemData SecuritySystemData { get; set; }
        
        [RealName("activeContexts")]
        public DumpedEnums.gamedeviceRequestType?[] ActiveContexts { get; set; }
        
        [RealName("lastInteractionLayerTag")]
        [RealType("CName")]
        public string LastInteractionLayerTag { get; set; }
        
        [RealName("quickHacksExposed")]
        [RealType("Bool")]
        public bool QuickHacksExposed { get; set; }
        
        [RealName("currentCooldownID")]
        [RealType("Uint32")]
        public uint CurrentCooldownID { get; set; }
        
        [RealName("reactionPresetID")]
        [RealType("TweakDBID")]
        public TweakDbId ReactionPresetID { get; set; }
        
        [RealName("isDefeatMechanicActive")]
        [RealType("Bool")]
        public bool IsDefeatMechanicActive { get; set; }
        
        [RealName("leftHandLoadout")]
        public GameItemID LeftHandLoadout { get; set; }
        
        [RealName("rightHandLoadout")]
        public GameItemID RightHandLoadout { get; set; }

        public ScriptedPuppetPS()
        {
            IsDefeatMechanicActive = true;
        }
    }
}
