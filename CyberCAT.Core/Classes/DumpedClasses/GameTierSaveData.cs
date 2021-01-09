using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameTierSaveData")]
    public class GameTierSaveData : ISerializable
    {
        [RealName("globalTiers")]
        public GameGlobalTierSaveData[] GlobalTiers { get; set; }
    }
}
