using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.GodModeSystem
{
    [RealName("gameGodModeSaveEntityData")]
    public class GameGodModeSaveEntityData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityId")]
        public EntEntityID EntityId { get; set; }

        [RealName("data")]
        public GameGodModeEntityData Data { get; set; }
    }
}