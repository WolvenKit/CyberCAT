using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("effectTrackItem")]
    public class EffectTrackItem : EffectBaseItem
    {
        [RealName("timeBegin")]
        [RealType("Float")]
        public float TimeBegin { get; set; }
        
        [RealName("timeDuration")]
        [RealType("Float")]
        public float TimeDuration { get; set; }
        
        // TODO
        [RealName("ruid")]
        [RealType("CRUID")]
        public dynamic Ruid { get; set; }
    }
}
