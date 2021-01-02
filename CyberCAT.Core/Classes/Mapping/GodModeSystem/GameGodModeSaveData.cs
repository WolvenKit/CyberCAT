using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.GodModeSystem
{
    [RealName("gameGodModeSaveData")]
    public class GameGodModeSaveData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("gods")]
        public GameGodModeSaveEntityData[] Gods { get; set; }
    }
}