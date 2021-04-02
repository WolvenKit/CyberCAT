using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerVisionModeControllerRefreshPolicy")]
    public class PlayerVisionModeControllerRefreshPolicy : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("kerenzikov")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? Kerenzikov { get; set; }
        
        [RealName("restrictedScene")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? RestrictedScene { get; set; }
        
        [RealName("dead")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? Dead { get; set; }
        
        [RealName("takedown")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? Takedown { get; set; }
        
        [RealName("deviceTakeover")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? DeviceTakeover { get; set; }
        
        [RealName("braindanceFPP")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? BraindanceFPP { get; set; }
        
        [RealName("braindanceActive")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? BraindanceActive { get; set; }
        
        [RealName("veryHardLanding")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? VeryHardLanding { get; set; }
        
        [RealName("noScanningRestriction")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? NoScanningRestriction { get; set; }
        
        [RealName("hasNotCybereye")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? HasNotCybereye { get; set; }
        
        [RealName("isPhotoMode")]
        public DumpedEnums.PlayerVisionModeControllerRefreshPolicyEnum? IsPhotoMode { get; set; }
    }
}
