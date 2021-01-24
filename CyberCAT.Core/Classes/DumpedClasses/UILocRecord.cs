using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UILocRecord")]
    public class UILocRecord : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tag")]
        public CName Tag { get; set; }
        
        [RealName("value")]
        public string Value { get; set; }
    }
}
