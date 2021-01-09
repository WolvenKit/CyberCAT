using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAlarmSetup")]
    public class SecurityAlarmSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("useSound")]
        [RealType("Bool")]
        public bool UseSound { get; set; }
        
        [RealName("alarmSound")]
        [RealType("CName")]
        public string AlarmSound { get; set; }
    }
}
