using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAlarmControllerPS")]
    public class SecurityAlarmControllerPS : MasterControllerPS
    {
        [RealName("securityAlarmSetup")]
        public SecurityAlarmSetup SecurityAlarmSetup { get; set; }
        
        [RealName("securityAlarmState")]
        public DumpedEnums.ESecuritySystemState? SecurityAlarmState { get; set; }
    }
}
