using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSItemStackRequirementData")]
    public class GameSItemStackRequirementData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType? StatType { get; set; }
        
        [RealName("requiredValue")]
        public float RequiredValue { get; set; }
    }
}
