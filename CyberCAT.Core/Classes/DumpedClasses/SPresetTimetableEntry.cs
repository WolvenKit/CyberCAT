using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SPresetTimetableEntry")]
    public class SPresetTimetableEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("time")]
        public SSimpleGameTime Time { get; set; }
        
        [RealName("useTime")]
        public bool UseTime { get; set; }
        
        [RealName("arrayPosition")]
        public int ArrayPosition { get; set; }
        
        [RealName("entryID")]
        public uint EntryID { get; set; }
    }
}
