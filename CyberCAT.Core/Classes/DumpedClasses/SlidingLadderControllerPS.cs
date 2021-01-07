using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SlidingLadderControllerPS")]
    public class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
    {
        [RealName("isShootable")]
        [RealType("Bool")]
        public bool IsShootable { get; set; }
        
        [RealName("animationTime")]
        [RealType("Float")]
        public float AnimationTime { get; set; }
    }
}
