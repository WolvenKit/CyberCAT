using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gamebbID")]
    public class GamebbID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("g")]
        [RealType("CName")]
        public string G { get; set; }
    }
}
