using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeakFenceSetup")]
    public class WeakFenceSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hasGenericInteraction")]
        [RealType("Bool")]
        public bool HasGenericInteraction { get; set; }
    }
}
