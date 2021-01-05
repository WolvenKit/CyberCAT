using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.GodModeSystem
{
    [RealName("gameGodModeData")]
    public class GameGodModeData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gameGodModeType? Type { get; set; }

        [RealName("source")]
        [RealType("CName")]
        public string Source { get; set; }
    }
}