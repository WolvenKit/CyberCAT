using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIbehaviorResource")]
    public class AIbehaviorResource : CResource
    {
        [RealName("root")]
        public Handle<AIbehaviorTreeNodeDefinition> Root { get; set; }
        
        [RealName("arguments")]
        public AITreeArgumentsDefinition Arguments { get; set; }
        
        [RealName("delegate_")]
        public Handle<AIbehaviorBehaviorDelegate> Delegate_ { get; set; }
        
        [RealName("initializationEvents")]
        public CName[] InitializationEvents { get; set; }
    }
}
