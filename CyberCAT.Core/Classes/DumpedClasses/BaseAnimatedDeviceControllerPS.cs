using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BaseAnimatedDeviceControllerPS")]
    public class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isActive")]
        public bool IsActive { get; set; }
        
        [RealName("hasInteraction")]
        public bool HasInteraction { get; set; }
        
        [RealName("randomizeAnimationTime")]
        public bool RandomizeAnimationTime { get; set; }
        
        [RealName("nameForActivation")]
        public TweakDbId NameForActivation { get; set; }
        
        [RealName("nameForDeactivation")]
        public TweakDbId NameForDeactivation { get; set; }
    }
}
