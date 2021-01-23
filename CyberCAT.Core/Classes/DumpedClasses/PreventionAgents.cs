using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PreventionAgents")]
    public class PreventionAgents : IScriptable
    {
        [RealName("groupName")]
        public CName GroupName { get; set; }
        
        [RealName("requsteredAgents")]
        public SPreventionAgentData[] RequsteredAgents { get; set; }
    }
}
