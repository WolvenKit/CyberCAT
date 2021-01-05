using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SDeviceTimetableEntry")]
    public class SDeviceTimetableEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("time")]
        public SSimpleGameTime Time { get; set; }
        
        [RealName("state")]
        public DumpedEnums.EDeviceStatus? State { get; set; }
        
        [RealName("entryID")]
        [RealType("Uint32")]
        public uint EntryID { get; set; }
    }
}
