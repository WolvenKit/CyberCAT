using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAlarmSetup")]
    public class SecurityAlarmSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("useSound")]
        public bool UseSound { get; set; }
        
        [RealName("alarmSound")]
        public CName AlarmSound { get; set; }
    }
}
