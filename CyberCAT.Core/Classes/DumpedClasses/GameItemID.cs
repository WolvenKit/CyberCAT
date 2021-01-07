using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameItemID")]
    public class GameItemID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        [RealType("TweakDBID")]
        public TweakDbId Id { get; set; }
        
        [RealName("rngSeed")]
        [RealType("Uint32")]
        public uint RngSeed { get; set; }
    }
}
