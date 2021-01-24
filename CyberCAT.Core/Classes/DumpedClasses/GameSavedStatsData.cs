using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSavedStatsData")]
    public class GameSavedStatsData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statModifiers")]
        public Handle<GameStatModifierData>[] StatModifiers { get; set; }
        
        [RealName("inactiveStats")]
        public DumpedEnums.gamedataStatType?[] InactiveStats { get; set; }
        
        [RealName("recordID")]
        public TweakDbId RecordID { get; set; }
        
        [RealName("seed")]
        public uint Seed { get; set; }
    }
}
