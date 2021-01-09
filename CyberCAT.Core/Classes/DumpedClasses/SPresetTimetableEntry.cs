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
        [RealType("Bool")]
        public bool UseTime { get; set; }
        
        [RealName("arrayPosition")]
        [RealType("Int32")]
        public int ArrayPosition { get; set; }
        
        [RealName("entryID")]
        [RealType("Uint32")]
        public uint EntryID { get; set; }
    }
}
