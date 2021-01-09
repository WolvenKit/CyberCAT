using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatPoolModifier")]
    public class GameStatPoolModifier : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("enabled")]
        [RealType("Bool")]
        public bool Enabled { get; set; }
        
        [RealName("rangeBegin")]
        [RealType("Float")]
        public float RangeBegin { get; set; }
        
        [RealName("rangeEnd")]
        [RealType("Float")]
        public float RangeEnd { get; set; }
        
        [RealName("startDelay")]
        [RealType("Float")]
        public float StartDelay { get; set; }
        
        [RealName("valuePerSec")]
        [RealType("Float")]
        public float ValuePerSec { get; set; }
        
        [RealName("delayOnChange")]
        [RealType("Bool")]
        public bool DelayOnChange { get; set; }
        
        [RealName("usingPointValues")]
        [RealType("Bool")]
        public bool UsingPointValues { get; set; }
    }
}
