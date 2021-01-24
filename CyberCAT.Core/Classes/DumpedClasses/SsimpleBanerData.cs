using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SsimpleBanerData")]
    public class SsimpleBanerData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("title")]
        public string Title { get; set; }
        
        [RealName("description")]
        public string Description { get; set; }
        
        [RealName("content")]
        public RedResourceReferenceScriptToken Content { get; set; }
    }
}
