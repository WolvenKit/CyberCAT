using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameStatPoolModifier")]
    public class GameStatPoolModifier : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("enabled")]
        public bool Enabled { get; set; }
        
        [RealName("rangeBegin")]
        public float RangeBegin { get; set; }
        
        [RealName("rangeEnd")]
        public float RangeEnd { get; set; }
        
        [RealName("startDelay")]
        public float StartDelay { get; set; }
        
        [RealName("valuePerSec")]
        public float ValuePerSec { get; set; }
        
        [RealName("delayOnChange")]
        public bool DelayOnChange { get; set; }
        
        [RealName("usingPointValues")]
        public bool UsingPointValues { get; set; }
    }
}
