using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SmartHouseControllerPS")]
    public class SmartHouseControllerPS : MasterControllerPS
    {
        [RealName("timetable")]
        public SPresetTimetableEntry[] Timetable { get; set; }
        
        [RealName("activePreset")]
        public Handle<SmartHousePreset> ActivePreset { get; set; }
        
        [RealName("availablePresets")]
        public Handle<SmartHousePreset>[] AvailablePresets { get; set; }
        
        [RealName("smartHouseCustomization")]
        public SmartHouseConfiguration SmartHouseCustomization { get; set; }
        
        [RealName("callbackID")]
        [RealType("Uint32")]
        public uint CallbackID { get; set; }
    }
}
