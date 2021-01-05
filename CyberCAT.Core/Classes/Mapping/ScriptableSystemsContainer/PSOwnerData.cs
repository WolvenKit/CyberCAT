using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("PSOwnerData")]
    public class PSOwnerData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        public GamePersistentID Id { get; set; }
        
        [RealName("className")]
        [RealType("CName")]
        public string ClassName { get; set; }
    }
}
