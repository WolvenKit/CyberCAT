using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
