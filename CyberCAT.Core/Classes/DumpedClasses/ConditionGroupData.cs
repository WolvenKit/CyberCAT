using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ConditionGroupData")]
    public class ConditionGroupData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("conditions")]
        public Handle<GameplayConditionBase>[] Conditions { get; set; }
        
        [RealName("logicOperator")]
        public DumpedEnums.ELogicOperator? LogicOperator { get; set; }
    }
}
