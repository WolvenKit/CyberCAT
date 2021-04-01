using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerBBListeners")]
    public class PlayerVisionModeControllerBBListeners : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("kerenzikov")]
        public uint Kerenzikov { get; set; }
        
        [RealName("restrictedScene")]
        public uint RestrictedScene { get; set; }
        
        [RealName("dead")]
        public uint Dead { get; set; }
        
        [RealName("takedown")]
        public uint Takedown { get; set; }
        
        [RealName("deviceTakeover")]
        public uint DeviceTakeover { get; set; }
        
        [RealName("braindanceFPP")]
        public uint BraindanceFPP { get; set; }
        
        [RealName("braindanceActive")]
        public uint BraindanceActive { get; set; }
        
        [RealName("veryHardLanding")]
        public uint VeryHardLanding { get; set; }
    }
}
