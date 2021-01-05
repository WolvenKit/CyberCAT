using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameItemID")]
    public class GameItemID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        [RealType("TweakDBID")]
        public ulong Id { get; set; }
        
        [RealName("rngSeed")]
        [RealType("Uint32")]
        public uint RngSeed { get; set; }
    }
}
