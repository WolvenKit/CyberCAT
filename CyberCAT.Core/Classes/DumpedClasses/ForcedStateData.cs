using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ForcedStateData")]
    public class ForcedStateData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("state")]
        public DumpedEnums.ECLSForcedState? State { get; set; }
        
        [RealName("sourceName")]
        [RealType("CName")]
        public string SourceName { get; set; }
        
        [RealName("priority")]
        public DumpedEnums.EPriority? Priority { get; set; }
        
        [RealName("savable")]
        [RealType("Bool")]
        public bool Savable { get; set; }
    }
}
