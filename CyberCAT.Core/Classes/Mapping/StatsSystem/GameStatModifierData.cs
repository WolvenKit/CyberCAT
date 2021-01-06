using CyberCAT.Core.Classes.NodeRepresentations;
using System;

namespace CyberCAT.Core.Classes.Mapping.StatsSystem
{
    [RealName("gameStatModifierData")]
    public class GameStatModifierData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType? StatType { get; set; }

        [RealName("modifierType")]
        public DumpedEnums.gameStatModifierType? ModifierType { get; set; }
        public override string ToString()
        {
            if (StatType.HasValue)
            {
                return Enum.GetName(typeof(DumpedEnums.gamedataStatType), StatType);
            }
            else
            {
                return "gamedataStatType";
            }
        }
    }
}