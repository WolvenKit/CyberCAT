using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceTimeTableManager")]
    public class DeviceTimeTableManager : IScriptable
    {
        [RealName("timeTable")]
        public SDeviceTimetableEntry[] TimeTable { get; set; }
    }
}
