using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameinteractionsOrbID")]
    public class GameinteractionsOrbID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        [RealType("Uint32")]
        public uint Id { get; set; }
    }
}
