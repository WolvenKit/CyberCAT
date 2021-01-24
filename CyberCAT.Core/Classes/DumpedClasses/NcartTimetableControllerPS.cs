using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NcartTimetableControllerPS")]
    public class NcartTimetableControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("ncartTimetableSetup")]
        public NcartTimetableSetup NcartTimetableSetup { get; set; }
        
        [RealName("currentTimeToDepart")]
        public int CurrentTimeToDepart { get; set; }
    }
}
