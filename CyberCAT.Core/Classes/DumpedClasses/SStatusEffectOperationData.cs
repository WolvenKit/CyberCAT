using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SStatusEffectOperationData")]
    public class SStatusEffectOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("range")]
        [RealType("Float")]
        public float Range { get; set; }
        
        [RealName("duration")]
        [RealType("Float")]
        public float Duration { get; set; }
        
        [RealName("offset")]
        public Vector4 Offset { get; set; }
        
        [RealName("effect")]
        public GameStatusEffectTDBPicker Effect { get; set; }
    }
}
