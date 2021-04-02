using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkWidgetLibraryItem")]
    public class InkWidgetLibraryItem : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("package")]
        [RealType("SharedDataBuffer")]
        public dynamic Package { get; set; }
    }
}
