
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("GameplayConditionContainer")]
    public class GameplayConditionContainer : IScriptable
    {
        [RealName("logicOperator")]
        public DumpedEnums.ELogicOperator? LogicOperator { get; set; }
        
        [RealName("conditionGroups")]
        public ConditionGroupData[] ConditionGroups { get; set; }
    }
}
