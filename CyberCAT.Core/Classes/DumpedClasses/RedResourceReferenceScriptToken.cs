using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("redResourceReferenceScriptToken")]
    public class RedResourceReferenceScriptToken : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("resource")]
        public CResource Resource { get; set; }
    }
}
