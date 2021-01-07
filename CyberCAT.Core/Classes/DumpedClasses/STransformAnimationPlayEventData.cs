using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STransformAnimationPlayEventData")]
    public class STransformAnimationPlayEventData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("timeScale")]
        [RealType("Float")]
        public float TimeScale { get; set; }
        
        [RealName("looping")]
        [RealType("Bool")]
        public bool Looping { get; set; }
        
        [RealName("timesPlayed")]
        [RealType("Uint32")]
        public uint TimesPlayed { get; set; }
    }
}
