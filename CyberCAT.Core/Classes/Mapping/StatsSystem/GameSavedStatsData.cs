using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameSavedStatsData")]
    public class GameSavedStatsData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statModifiers")]
        [RealType("gameStatModifierData", IsHandle = true)]
        public Handle<GameStatModifierData>[] StatModifiers { get; set; }

        [RealName("inactiveStats")]
        public DumpedEnums.gamedataStatType?[] InactiveStats { get; set; }

        [RealName("recordID")]
        [RealType("TweakDBID")]
        public TweakDbId RecordID { get; set; }

        [RealName("seed")]
        [RealType("Uint32")]
        public uint Seed { get; set; }
    }
}