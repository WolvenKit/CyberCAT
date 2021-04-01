using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameItemID")]
    public class GameItemID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        public TweakDbId Id { get; set; }
        
        [RealName("rngSeed")]
        public uint RngSeed { get; set; }
        
        [RealName("uniqueCounter")]
        public ushort UniqueCounter { get; set; }
    }
}
