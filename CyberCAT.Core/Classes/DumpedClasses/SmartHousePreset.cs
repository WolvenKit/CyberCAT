using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SmartHousePreset")]
    public class SmartHousePreset : IScriptable
    {
        [RealName("timetable")]
        public SPresetTimetableEntry Timetable { get; set; }
    }
}
