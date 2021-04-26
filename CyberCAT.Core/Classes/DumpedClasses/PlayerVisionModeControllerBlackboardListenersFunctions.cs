using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerBlackboardListenersFunctions")]
    public class PlayerVisionModeControllerBlackboardListenersFunctions : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("kerenzikov")]
        public CName Kerenzikov { get; set; }
        
        [RealName("restrictedScene")]
        public CName RestrictedScene { get; set; }
        
        [RealName("dead")]
        public CName Dead { get; set; }
        
        [RealName("takedown")]
        public CName Takedown { get; set; }
        
        [RealName("deviceTakeover")]
        public CName DeviceTakeover { get; set; }
        
        [RealName("braindanceFPP")]
        public CName BraindanceFPP { get; set; }
        
        [RealName("braindanceActive")]
        public CName BraindanceActive { get; set; }
        
        [RealName("veryHardLanding")]
        public CName VeryHardLanding { get; set; }
    }
}
