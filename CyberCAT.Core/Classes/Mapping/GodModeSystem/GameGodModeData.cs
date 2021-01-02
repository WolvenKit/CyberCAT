using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.GodModeSystem
{
    [RealName("gameGodModeData")]
    public class GameGodModeData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("source")]
        [RealType("CName")]
        public string Source { get; set; }

        [RealName("type")]
        public DumpedEnums.gameGodModeType Type { get; set; }
    }
}