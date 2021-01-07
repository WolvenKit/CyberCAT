using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RadioControllerPS")]
    public class RadioControllerPS : MediaDeviceControllerPS
    {
        [RealName("radioSetup")]
        public RadioSetup RadioSetup { get; set; }
        
        [RealName("stations")]
        public RadioStationsMap[] Stations { get; set; }
        
        [RealName("stationsInitialized")]
        [RealType("Bool")]
        public bool StationsInitialized { get; set; }

        public RadioControllerPS()
        {
            AutoToggleQuestMark = true;
            IsInteractive = true;
        }
    }
}
