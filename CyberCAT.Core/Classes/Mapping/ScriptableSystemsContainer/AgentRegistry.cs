
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("AgentRegistry")]
    public class AgentRegistry : IScriptable
    {
        [RealName("isInitialized")]
        [RealType("Bool")]
        public bool IsInitialized { get; set; }
        
        [RealName("agents")]
        public Agent[] Agents { get; set; }
        
        [RealName("agentsLock")]
        public ScriptReentrantRWLock AgentsLock { get; set; }
        
        [RealName("maxReprimandsPerNPC")]
        [RealType("Int32")]
        public int MaxReprimandsPerNPC { get; set; }
        
        [RealName("maxReprimandsPerDEVICE")]
        [RealType("Int32")]
        public int MaxReprimandsPerDEVICE { get; set; }
    }
}
