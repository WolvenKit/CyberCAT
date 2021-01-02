using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameConstantStatModifierData")]
    public class GameConstantStatModifierData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType StatType { get; set; }

        [RealName("modifierType")]
        public DumpedEnums.gameStatModifierType ModifierType { get; set; }

        [RealName("value")]
        [RealType("Float")]
        public float Value { get; set; }
    }
}