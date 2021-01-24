using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FuseControllerPS")]
    public class FuseControllerPS : MasterControllerPS
    {
        [RealName("timeTableSetup")]
        public Handle<DeviceTimeTableManager> TimeTableSetup { get; set; }
        
        [RealName("maxLightsSwitchedAtOnce")]
        public int MaxLightsSwitchedAtOnce { get; set; }
        
        [RealName("timeToNextSwitch")]
        public float TimeToNextSwitch { get; set; }
        
        [RealName("lightSwitchRandomizerType")]
        public DumpedEnums.ELightSwitchRandomizerType? LightSwitchRandomizerType { get; set; }
        
        [RealName("alternativeNameForON")]
        public TweakDbId AlternativeNameForON { get; set; }
        
        [RealName("alternativeNameForOFF")]
        public TweakDbId AlternativeNameForOFF { get; set; }
        
        [RealName("isCLSInitialized")]
        public bool IsCLSInitialized { get; set; }

        public FuseControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
