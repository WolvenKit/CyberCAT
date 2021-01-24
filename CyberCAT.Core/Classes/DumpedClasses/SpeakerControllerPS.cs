using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SpeakerControllerPS")]
    public class SpeakerControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("speakerSetup")]
        public SpeakerSetup SpeakerSetup { get; set; }
        
        [RealName("currentValue")]
        public CName CurrentValue { get; set; }
        
        [RealName("previousValue")]
        public CName PreviousValue { get; set; }
    }
}
