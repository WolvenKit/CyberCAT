using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.TierSystem
{
    [RealName("gameSceneTierData")]
    public class GameSceneTierData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tier")]
        public DumpedEnums.GameplayTier? Tier { get; set; }

        [RealName("emptyHands")]
        [RealType("Bool")]
        public bool EmptyHands { get; set; }
    }
}