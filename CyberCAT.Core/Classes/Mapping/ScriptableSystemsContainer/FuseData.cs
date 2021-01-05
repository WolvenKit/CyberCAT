using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("FuseData")]
    public class FuseData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("psOwnerData")]
        public PSOwnerData PsOwnerData { get; set; }
        
        [RealName("timeTable")]
        public SDeviceTimetableEntry[] TimeTable { get; set; }
        
        [RealName("lights")]
        [RealType("Int32")]
        public int Lights { get; set; }
    }
}
