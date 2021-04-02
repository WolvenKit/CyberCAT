using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerBBValuesIds")]
    public class PlayerVisionModeControllerBBValuesIds : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("kerenzikov")]
        public GamebbScriptID_Int32 Kerenzikov { get; set; }
        
        [RealName("restrictedScene")]
        public GamebbScriptID_Int32 RestrictedScene { get; set; }
        
        [RealName("dead")]
        public GamebbScriptID_Int32 Dead { get; set; }
        
        [RealName("takedown")]
        public GamebbScriptID_Int32 Takedown { get; set; }
        
        [RealName("deviceTakeover")]
        public GamebbScriptID_EntityID DeviceTakeover { get; set; }
        
        [RealName("braindanceFPP")]
        public GamebbScriptID_Bool BraindanceFPP { get; set; }
        
        [RealName("braindanceActive")]
        public GamebbScriptID_Bool BraindanceActive { get; set; }
        
        [RealName("veryHardLanding")]
        public GamebbScriptID_Int32 VeryHardLanding { get; set; }
    }
}
