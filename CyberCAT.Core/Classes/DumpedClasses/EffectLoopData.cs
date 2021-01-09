using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("effectLoopData")]
    public class EffectLoopData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startTime")]
        [RealType("Float")]
        public float StartTime { get; set; }
        
        [RealName("endTime")]
        [RealType("Float")]
        public float EndTime { get; set; }
    }
}
