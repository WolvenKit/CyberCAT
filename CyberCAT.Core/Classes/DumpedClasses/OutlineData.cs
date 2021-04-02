using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OutlineData")]
    public class OutlineData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("outlineType")]
        public DumpedEnums.EOutlineType? OutlineType { get; set; }
        
        [RealName("outlineStrength")]
        public float OutlineStrength { get; set; }
    }
}
