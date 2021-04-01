using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FixedPoint")]
    public class FixedPoint : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Bits")]
        public int Bits { get; set; }
    }
}
