using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScriptedPuppetPS")]
    public class ScriptedPuppetPS : GamePuppetPS
    {
        [RealName("deviceLink")]
        public PuppetDeviceLinkPS DeviceLink { get; set; }
        
        [RealName("cooldownStorage")]
        public Handle<CooldownStorage> CooldownStorage { get; set; }
        
        [RealName("isInitialized")]
        public DumpedEnums.EBOOL? IsInitialized { get; set; }
        
        [RealName("wasAttached")]
        public bool WasAttached { get; set; }
        
        [RealName("wasRevealedInNetworkPing")]
        public bool WasRevealedInNetworkPing { get; set; }
        
        [RealName("numberActions")]
        public int NumberActions { get; set; }
        
        [RealName("wasQuickHackAttempt")]
        public bool WasQuickHackAttempt { get; set; }
        
        [RealName("hasDirectInteractionChoicesActive")]
        public bool HasDirectInteractionChoicesActive { get; set; }
        
        [RealName("wasIncapacitated")]
        public bool WasIncapacitated { get; set; }
        
        [RealName("isBreached")]
        public bool IsBreached { get; set; }
        
        [RealName("isDead")]
        public bool IsDead { get; set; }
        
        [RealName("isIncapacitated")]
        public bool IsIncapacitated { get; set; }
        
        [RealName("isAndroidTurnedOff")]
        public bool IsAndroidTurnedOff { get; set; }
        
        [RealName("securitySystemData")]
        public SecuritySystemData SecuritySystemData { get; set; }
        
        [RealName("activeContexts")]
        public DumpedEnums.gamedeviceRequestType?[] ActiveContexts { get; set; }
        
        [RealName("lastInteractionLayerTag")]
        public CName LastInteractionLayerTag { get; set; }
        
        [RealName("quickHacksExposed")]
        public bool QuickHacksExposed { get; set; }
        
        [RealName("currentCooldownID")]
        public uint CurrentCooldownID { get; set; }
        
        [RealName("reactionPresetID")]
        public TweakDbId ReactionPresetID { get; set; }
        
        [RealName("isDefeatMechanicActive")]
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
