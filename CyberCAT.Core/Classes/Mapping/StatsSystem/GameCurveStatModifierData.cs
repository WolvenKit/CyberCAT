using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameCurveStatModifierData")]
    public class GameCurveStatModifierData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType StatType { get; set; }

        [RealName("modifierType")]
        public DumpedEnums.gameStatModifierType ModifierType { get; set; }

        [RealName("curveName")]
        [RealType("CName")]
        public string CurveName { get; set; }

        [RealName("columnName")]
        [RealType("CName")]
        public string ColumnName { get; set; }

        [RealName("curveStat")]
        public DumpedEnums.gamedataStatType CurveStat { get; set; }

        [RealName("value")]
        [RealType("Float")]
        public float Value { get; set; }
    }
}