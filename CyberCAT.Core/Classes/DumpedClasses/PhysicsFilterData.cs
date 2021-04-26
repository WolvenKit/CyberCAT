using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("physicsFilterData")]
    public class PhysicsFilterData : ISerializable
    {
        [RealName("queryFilter")]
        public PhysicsQueryFilter QueryFilter { get; set; }
        
        [RealName("simulationFilter")]
        public PhysicsSimulationFilter SimulationFilter { get; set; }
        
        [RealName("preset")]
        public CName Preset { get; set; }
        
        [RealName("customFilterData")]
        public Handle<PhysicsCustomFilterData> CustomFilterData { get; set; }
    }
}
