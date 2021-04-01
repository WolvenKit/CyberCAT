using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameGodModeEntityData")]
    public class GameGodModeEntityData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("overrides")]
        public GameGodModeData[] Overrides { get; set; }
        
        [RealName("base")]
        public GameGodModeData[] Base_ { get; set; }
    }
}
