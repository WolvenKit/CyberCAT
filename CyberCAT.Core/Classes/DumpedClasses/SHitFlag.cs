using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SHitFlag")]
    public class SHitFlag : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("flag")]
        public DumpedEnums.hitFlag? Flag { get; set; }
        
        [RealName("source")]
        public CName Source { get; set; }
    }
}
