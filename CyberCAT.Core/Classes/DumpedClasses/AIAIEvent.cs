using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIAIEvent")]
    public class AIAIEvent : RedEvent
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("timeToLive")]
        public float TimeToLive { get; set; }
    }
}
