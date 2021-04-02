using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkStyleProperty")]
    public class InkStyleProperty : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("propertyPath")]
        public CName PropertyPath { get; set; }

        // TODO: Check type
        [RealName("value")]
        [RealType("Variant")]
        public dynamic Value { get; set; }
    }
}
