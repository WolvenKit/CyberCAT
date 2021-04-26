using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIbehaviorParameterizedBehavior")]
    public class AIbehaviorParameterizedBehavior : ISerializable
    {
        [RealName("treeDefinition")]
        public AIbehaviorResource TreeDefinition { get; set; }
        
        [RealName("argumentsOverrides")]
        public AIArgumentOverrideWrapper[] ArgumentsOverrides { get; set; }
    }
}
