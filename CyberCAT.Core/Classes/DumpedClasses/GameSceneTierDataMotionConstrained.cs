using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSceneTierDataMotionConstrained")]
    public class GameSceneTierDataMotionConstrained : GameSceneTierData
    {
        [RealName("splineRef")]
        public NodeRef SplineRef { get; set; }
        
        [RealName("adjustingSpeed")]
        public float AdjustingSpeed { get; set; }
        
        [RealName("adjustingDuration")]
        public float AdjustingDuration { get; set; }
        
        [RealName("travellingSpeed")]
        public float TravellingSpeed { get; set; }
        
        [RealName("travellingDuration")]
        public float TravellingDuration { get; set; }
        
        [RealName("notificationBackwardIndex")]
        public int NotificationBackwardIndex { get; set; }
    }
}
