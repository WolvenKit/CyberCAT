using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SHitStatusEffect")]
    public class SHitStatusEffect : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("stacks")]
        public float Stacks { get; set; }
        
        [RealName("id")]
        public TweakDbId Id { get; set; }
    }
}
