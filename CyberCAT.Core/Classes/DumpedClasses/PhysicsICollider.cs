using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("physicsICollider")]
    public class PhysicsICollider : ISerializable
    {
        [RealName("localToBody")]
        public Transform LocalToBody { get; set; }
        
        [RealName("material")]
        public CName Material { get; set; }
        
        [RealName("materialApperanceOverrides")]
        public PhysicsApperanceMaterial[] MaterialApperanceOverrides { get; set; }
        
        [RealName("tag")]
        public CName Tag { get; set; }
        
        [RealName("filterData")]
        public Handle<PhysicsFilterData> FilterData { get; set; }
        
        [RealName("volumeModifier")]
        public float VolumeModifier { get; set; }
        
        [RealName("isImported")]
        public bool IsImported { get; set; }
        
        [RealName("isQueryShapeOnly")]
        public bool IsQueryShapeOnly { get; set; }
    }
}
