using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectDebugSettings")]
    public class GameEffectDebugSettings : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("overrideGlobalSettings")]
        [RealType("Bool")]
        public bool OverrideGlobalSettings { get; set; }
        
        [RealName("duration")]
        [RealType("Float")]
        public float Duration { get; set; }
        
        [RealName("color")]
        public Color Color { get; set; }
    }
}
