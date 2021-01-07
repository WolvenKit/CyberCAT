using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("effectTrackGroup")]
    public class EffectTrackGroup : EffectTrackBase
    {
        [RealName("tracks")]
        public Handle<EffectTrackBase>[] Tracks { get; set; }
        
        [RealName("componentName")]
        [RealType("CName")]
        public string ComponentName { get; set; }
    }
}
