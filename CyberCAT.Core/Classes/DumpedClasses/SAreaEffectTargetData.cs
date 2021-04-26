using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SAreaEffectTargetData")]
    public class SAreaEffectTargetData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaEffectID")]
        public CName AreaEffectID { get; set; }
        
        [RealName("onSelf")]
        public bool OnSelf { get; set; }
        
        [RealName("onSlaves")]
        public bool OnSlaves { get; set; }
    }
}
