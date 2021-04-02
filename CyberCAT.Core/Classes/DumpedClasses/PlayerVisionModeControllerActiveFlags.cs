using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerActiveFlags")]
    public class PlayerVisionModeControllerActiveFlags : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("kerenzikov")]
        public bool Kerenzikov { get; set; }
        
        [RealName("restrictedScene")]
        public bool RestrictedScene { get; set; }
        
        [RealName("dead")]
        public bool Dead { get; set; }
        
        [RealName("takedown")]
        public bool Takedown { get; set; }
        
        [RealName("deviceTakeover")]
        public bool DeviceTakeover { get; set; }
        
        [RealName("braindanceFPP")]
        public bool BraindanceFPP { get; set; }
        
        [RealName("braindanceActive")]
        public bool BraindanceActive { get; set; }
        
        [RealName("veryHardLanding")]
        public bool VeryHardLanding { get; set; }
        
        [RealName("noScanningRestriction")]
        public bool NoScanningRestriction { get; set; }
        
        [RealName("hasNotCybereye")]
        public bool HasNotCybereye { get; set; }
        
        [RealName("isPhotoMode")]
        public bool IsPhotoMode { get; set; }
    }
}
