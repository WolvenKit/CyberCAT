using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceTimetableEntry")]
    public class SDeviceTimetableEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("time")]
        public SSimpleGameTime Time { get; set; }
        
        [RealName("state")]
        public DumpedEnums.EDeviceStatus? State { get; set; }
        
        [RealName("entryID")]
        public uint EntryID { get; set; }
    }
}
