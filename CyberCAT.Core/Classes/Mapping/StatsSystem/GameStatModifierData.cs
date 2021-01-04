using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameStatModifierData")]
    public class GameStatModifierData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType StatType { get; set; }

        [RealName("modifierType")]
        public DumpedEnums.gameStatModifierType ModifierType { get; set; }
    }
}