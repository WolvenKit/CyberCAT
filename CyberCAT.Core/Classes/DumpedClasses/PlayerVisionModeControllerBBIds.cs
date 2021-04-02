using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerBBIds")]
    public class PlayerVisionModeControllerBBIds : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("kerenzikov")]
        public Handle<GamebbScriptDefinition> Kerenzikov { get; set; }
        
        [RealName("restrictedScene")]
        public Handle<GamebbScriptDefinition> RestrictedScene { get; set; }
        
        [RealName("dead")]
        public Handle<GamebbScriptDefinition> Dead { get; set; }
        
        [RealName("takedown")]
        public Handle<GamebbScriptDefinition> Takedown { get; set; }
        
        [RealName("deviceTakeover")]
        public Handle<GamebbScriptDefinition> DeviceTakeover { get; set; }
        
        [RealName("braindanceFPP")]
        public Handle<GamebbScriptDefinition> BraindanceFPP { get; set; }
        
        [RealName("braindanceActive")]
        public Handle<GamebbScriptDefinition> BraindanceActive { get; set; }
        
        [RealName("veryHardLanding")]
        public Handle<GamebbScriptDefinition> VeryHardLanding { get; set; }
    }
}
