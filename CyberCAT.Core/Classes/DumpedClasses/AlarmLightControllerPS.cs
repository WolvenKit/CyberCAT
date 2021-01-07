using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AlarmLightControllerPS")]
    public class AlarmLightControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("securityAlarmState")]
        public DumpedEnums.ESecuritySystemState? SecurityAlarmState { get; set; }
    }
}
