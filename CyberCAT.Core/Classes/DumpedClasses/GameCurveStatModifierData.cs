using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameCurveStatModifierData")]
    public class GameCurveStatModifierData : GameStatModifierData
    {
        [RealName("curveName")]
        [RealType("CName")]
        public string CurveName { get; set; }
        
        [RealName("columnName")]
        [RealType("CName")]
        public string ColumnName { get; set; }
        
        [RealName("curveStat")]
        public DumpedEnums.gamedataStatType? CurveStat { get; set; }
    }
}
