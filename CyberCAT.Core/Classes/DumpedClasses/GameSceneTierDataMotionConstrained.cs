using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSceneTierDataMotionConstrained")]
    public class GameSceneTierDataMotionConstrained : GameSceneTierData
    {
        [RealName("splineRef")]
        [RealType("NodeRef")]
        public string SplineRef { get; set; }
        
        [RealName("adjustingSpeed")]
        [RealType("Float")]
        public float AdjustingSpeed { get; set; }
        
        [RealName("adjustingDuration")]
        [RealType("Float")]
        public float AdjustingDuration { get; set; }
        
        [RealName("travellingSpeed")]
        [RealType("Float")]
        public float TravellingSpeed { get; set; }
        
        [RealName("travellingDuration")]
        [RealType("Float")]
        public float TravellingDuration { get; set; }
        
        [RealName("notificationBackwardIndex")]
        [RealType("Int32")]
        public int NotificationBackwardIndex { get; set; }
    }
}
