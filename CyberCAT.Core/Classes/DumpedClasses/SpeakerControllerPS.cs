using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SpeakerControllerPS")]
    public class SpeakerControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("speakerSetup")]
        public SpeakerSetup SpeakerSetup { get; set; }
        
        [RealName("currentValue")]
        [RealType("CName")]
        public string CurrentValue { get; set; }
        
        [RealName("previousValue")]
        [RealType("CName")]
        public string PreviousValue { get; set; }
    }
}
