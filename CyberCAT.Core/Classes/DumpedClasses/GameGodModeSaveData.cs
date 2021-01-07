using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameGodModeSaveData")]
    public class GameGodModeSaveData : ISerializable
    {
        [RealName("gods")]
        public GameGodModeSaveEntityData[] Gods { get; set; }
    }
}
