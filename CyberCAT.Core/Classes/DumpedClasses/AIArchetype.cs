using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIArchetype")]
    public class AIArchetype : CResource
    {
        [RealName("behaviorDefinition")]
        public Handle<AIbehaviorParameterizedBehavior> BehaviorDefinition { get; set; }
        
        [RealName("movementParameters")]
        public MoveMovementParameters MovementParameters { get; set; }
    }
}
