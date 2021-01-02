using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameCombinedStatModifierData")]
    public class GameCombinedStatModifierData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType StatType { get; set; }

        [RealName("modifierType")]
        public DumpedEnums.gameStatModifierType ModifierType { get; set; }

        [RealName("refStatType")]
        public DumpedEnums.gamedataStatType RefStatType { get; set; }

        [RealName("operation")]
        public DumpedEnums.gameCombinedStatOperation Operation { get; set; }

        [RealName("refObject")]
        public DumpedEnums.gameStatObjectsRelation RefObject { get; set; }

        [RealName("value")]
        [RealType("Float")]
        public float Value { get; set; }
    }
}