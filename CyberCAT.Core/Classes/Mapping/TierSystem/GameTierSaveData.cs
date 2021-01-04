using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.TierSystem
{
    [RealName("gameTierSaveData")]
    public class GameTierSaveData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("globalTiers")]
        public GameGlobalTierSaveData[] GlobalTiers { get; set; }
    }
}