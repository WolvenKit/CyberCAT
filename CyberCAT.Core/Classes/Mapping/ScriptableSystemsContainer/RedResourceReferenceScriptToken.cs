using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("redResourceReferenceScriptToken")]
    public class RedResourceReferenceScriptToken : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("resource")]
        public CResource Resource { get; set; }
    }
}
