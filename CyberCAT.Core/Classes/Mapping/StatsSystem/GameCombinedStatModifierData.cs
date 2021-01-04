namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameCombinedStatModifierData")]
    public class GameCombinedStatModifierData : GameStatModifierData
    {
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