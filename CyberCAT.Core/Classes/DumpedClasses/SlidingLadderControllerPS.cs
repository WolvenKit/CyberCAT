using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SlidingLadderControllerPS")]
    public class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
    {
        [RealName("isShootable")]
        public bool IsShootable { get; set; }
        
        [RealName("animationTime")]
        public float AnimationTime { get; set; }
    }
}
