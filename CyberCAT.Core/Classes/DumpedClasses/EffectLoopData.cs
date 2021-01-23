using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("effectLoopData")]
    public class EffectLoopData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startTime")]
        public float StartTime { get; set; }
        
        [RealName("endTime")]
        public float EndTime { get; set; }
    }
}
