using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkPropertyBinding")]
    public class InkPropertyBinding : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("propertyName")]
        public CName PropertyName { get; set; }
        
        [RealName("stylePath")]
        public CName StylePath { get; set; }
    }
}
