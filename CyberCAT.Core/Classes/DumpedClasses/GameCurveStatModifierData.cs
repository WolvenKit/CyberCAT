using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameCurveStatModifierData")]
    public class GameCurveStatModifierData : GameStatModifierData
    {
        [RealName("curveName")]
        public CName CurveName { get; set; }
        
        [RealName("columnName")]
        public CName ColumnName { get; set; }
        
        [RealName("curveStat")]
        public DumpedEnums.gamedataStatType? CurveStat { get; set; }
    }
}
