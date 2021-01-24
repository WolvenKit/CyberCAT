using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectDebugSettings")]
    public class GameEffectDebugSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("overrideGlobalSettings")]
        public bool OverrideGlobalSettings { get; set; }
        
        [RealName("duration")]
        public float Duration { get; set; }
        
        [RealName("color")]
        public Color Color { get; set; }
    }
}
