using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entSimpleColliderComponent")]
    public class EntSimpleColliderComponent : EntIPlacedComponent
    {
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("colliders")]
        public Handle<PhysicsICollider>[] Colliders { get; set; }
        
        [RealName("filter")]
        public Handle<PhysicsFilterData> Filter { get; set; }
        
        [RealName("compiledBuffer")]
        [RealType("DataBuffer")]
        public dynamic CompiledBuffer { get; set; }
    }
}
