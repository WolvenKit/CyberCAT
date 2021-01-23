using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FuseData")]
    public class FuseData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("psOwnerData")]
        public PSOwnerData PsOwnerData { get; set; }
        
        [RealName("timeTable")]
        public SDeviceTimetableEntry[] TimeTable { get; set; }
        
        [RealName("lights")]
        public int Lights { get; set; }
    }
}
