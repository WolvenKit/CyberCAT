using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AreaEntry")]
    public class AreaEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("user")]
        public EntEntityID User { get; set; }
    }
}
