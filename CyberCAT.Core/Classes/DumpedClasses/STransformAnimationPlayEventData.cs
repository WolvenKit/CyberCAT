using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STransformAnimationPlayEventData")]
    public class STransformAnimationPlayEventData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("timeScale")]
        public float TimeScale { get; set; }
        
        [RealName("looping")]
        public bool Looping { get; set; }
        
        [RealName("timesPlayed")]
        public uint TimesPlayed { get; set; }
    }
}
