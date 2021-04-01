using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entIPlacedComponent")]
    public class EntIPlacedComponent : EntIComponent
    {
        [RealName("parentTransform")]
        public Handle<EntITransformBinding> ParentTransform { get; set; }
        
        [RealName("localTransform")]
        public WorldTransform LocalTransform { get; set; }
    }
}
