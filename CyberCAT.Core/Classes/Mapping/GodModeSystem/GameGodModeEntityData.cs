using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.GodModeSystem
{
    [RealName("gameGodModeEntityData")]
    public class GameGodModeEntityData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("overrides")]
        public GameGodModeData[] Overrides { get; set; }

        [RealName("base")]
        public GameGodModeData[] Base { get; set; }
    }
}