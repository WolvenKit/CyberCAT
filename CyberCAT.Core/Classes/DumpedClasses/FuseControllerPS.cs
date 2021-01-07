using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FuseControllerPS")]
    public class FuseControllerPS : MasterControllerPS
    {
        [RealName("timeTableSetup")]
        public Handle<DeviceTimeTableManager> TimeTableSetup { get; set; }
        
        [RealName("maxLightsSwitchedAtOnce")]
        [RealType("Int32")]
        public int MaxLightsSwitchedAtOnce { get; set; }
        
        [RealName("timeToNextSwitch")]
        [RealType("Float")]
        public float TimeToNextSwitch { get; set; }
        
        [RealName("lightSwitchRandomizerType")]
        public DumpedEnums.ELightSwitchRandomizerType? LightSwitchRandomizerType { get; set; }
        
        [RealName("alternativeNameForON")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeNameForON { get; set; }
        
        [RealName("alternativeNameForOFF")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeNameForOFF { get; set; }
        
        [RealName("isCLSInitialized")]
        [RealType("Bool")]
        public bool IsCLSInitialized { get; set; }
    }
}
