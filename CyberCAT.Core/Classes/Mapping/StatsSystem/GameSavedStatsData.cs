using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameSavedStatsData")]
    public class GameSavedStatsData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statModifiers")]
        [RealType("gameStatModifierData", IsHandle = true)]
        public uint[] StatModifiers { get; set; }

        [RealName("inactiveStats")]
        public DumpedEnums.gamedataStatType[] InactiveStats { get; set; }

        [RealName("recordID")]
        [RealType("TweakDBID")]
        public ulong RecordID { get; set; }

        [RealName("seed")]
        [RealType("Uint32")]
        public uint Seed { get; set; }
    }
}