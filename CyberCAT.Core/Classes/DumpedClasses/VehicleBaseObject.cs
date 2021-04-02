using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleBaseObject")]
    public class VehicleBaseObject : GameObject
    {
        [RealName("vehicleComponent")]
        public VehicleComponent VehicleComponent { get; set; }
        
        [RealName("uiComponent")]
        public WorldWidgetComponent UiComponent { get; set; }
        
        [RealName("crowdMemberComponent")]
        public Handle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
        
        [RealName("hitTimestamp")]
        public float HitTimestamp { get; set; }
        
        [RealName("drivingTrafficPattern")]
        public CName DrivingTrafficPattern { get; set; }
        
        [RealName("onPavement")]
        public bool OnPavement { get; set; }
        
        [RealName("inTrafficLane")]
        public bool InTrafficLane { get; set; }
        
        [RealName("timesSentReactionEvent")]
        public int TimesSentReactionEvent { get; set; }
        
        [RealName("vehicleUpsideDown")]
        public bool VehicleUpsideDown { get; set; }
        
        [RealName("archetype")]
        public AIArchetype Archetype { get; set; }
    }
}
