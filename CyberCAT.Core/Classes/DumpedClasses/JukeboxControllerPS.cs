using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("JukeboxControllerPS")]
    public class JukeboxControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("jukeboxSetup")]
        public JukeboxSetup JukeboxSetup { get; set; }
        
        [RealName("stations")]
        public RadioStationsMap[] Stations { get; set; }
        
        [RealName("activeStation")]
        [RealType("Int32")]
        public int ActiveStation { get; set; }
        
        [RealName("isPlaying")]
        [RealType("Bool")]
        public bool IsPlaying { get; set; }
    }
}
