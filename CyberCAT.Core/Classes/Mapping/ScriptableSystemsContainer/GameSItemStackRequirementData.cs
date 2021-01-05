using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSItemStackRequirementData")]
    public class GameSItemStackRequirementData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("statType")]
        public DumpedEnums.gamedataStatType? StatType { get; set; }
        
        [RealName("requiredValue")]
        [RealType("Float")]
        public float RequiredValue { get; set; }
    }
}
