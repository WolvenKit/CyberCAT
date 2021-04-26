using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseComponent")]
    public class SenseComponent : EntIPlacedComponent
    {
        [RealName("highLevelCb")]
        public uint HighLevelCb { get; set; }
        
        [RealName("reactionCb")]
        public uint ReactionCb { get; set; }
        
        [RealName("highLevelState")]
        public DumpedEnums.gamedataNPCHighLevelState? HighLevelState { get; set; }
        
        [RealName("mainPreset")]
        public TweakDbId MainPreset { get; set; }
        
        [RealName("secondaryPreset")]
        public TweakDbId SecondaryPreset { get; set; }
        
        [RealName("puppetBlackboard")]
        public Handle<GameIBlackboard> PuppetBlackboard { get; set; }
        
        [RealName("playerTakedownStateCallbackID")]
        public uint PlayerTakedownStateCallbackID { get; set; }
        
        [RealName("playerUpperBodyStateCallbackID")]
        public uint PlayerUpperBodyStateCallbackID { get; set; }
        
        [RealName("playerCarryingStateCallbackID")]
        public uint PlayerCarryingStateCallbackID { get; set; }
        
        [RealName("playerInPerception")]
        public PlayerPuppet PlayerInPerception { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("sensorObject")]
        public Handle<SenseSensorObject> SensorObject { get; set; }
        
        [RealName("visibleObject")]
        public Handle<SenseVisibleObject> VisibleObject { get; set; }
        
        [RealName("enableBeingDetectable")]
        public bool EnableBeingDetectable { get; set; }
    }
}
