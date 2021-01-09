using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UILocRecord")]
    public class UILocRecord : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tag")]
        [RealType("CName")]
        public string Tag { get; set; }
        
        [RealName("value")]
        [RealType("String")]
        public string Value { get; set; }
    }
}
