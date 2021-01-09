using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AICommandQueuePS")]
    public class AICommandQueuePS : GameComponentPS
    {
        [RealName("behaviorArgumentList")]
        public Handle<AIArgumentInstancePS>[] BehaviorArgumentList { get; set; }
        
        [RealName("aiRole")]
        public Handle<AIRole> AiRole { get; set; }
    }
}
