using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIArgumentDefinition")]
    public class AIArgumentDefinition : ISerializable
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("isPersistent")]
        public bool IsPersistent { get; set; }
        
        [RealName("behaviorCallbackName")]
        public CName BehaviorCallbackName { get; set; }
    }
}
