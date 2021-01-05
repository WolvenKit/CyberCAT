
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("PreventionAgents")]
    public class PreventionAgents : IScriptable
    {
        [RealName("groupName")]
        [RealType("CName")]
        public string GroupName { get; set; }
        
        [RealName("requsteredAgents")]
        public SPreventionAgentData[] RequsteredAgents { get; set; }
    }
}
