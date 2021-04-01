using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkStyle")]
    public class InkStyle : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("styleID")]
        public CName StyleID { get; set; }
        
        [RealName("state")]
        public CName State { get; set; }
        
        [RealName("properties")]
        public InkStyleProperty[] Properties { get; set; }
    }
}
