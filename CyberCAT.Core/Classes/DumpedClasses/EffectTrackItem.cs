using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("effectTrackItem")]
    public class EffectTrackItem : EffectBaseItem
    {
        [RealName("timeBegin")]
        public float TimeBegin { get; set; }
        
        [RealName("timeDuration")]
        public float TimeDuration { get; set; }

        // TODO: Check type
        [RealName("ruid")]
        [RealType("CRUID")]
        public dynamic Ruid { get; set; }
    }
}
