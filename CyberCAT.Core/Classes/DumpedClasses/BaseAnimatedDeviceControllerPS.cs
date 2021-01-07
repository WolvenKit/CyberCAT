using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BaseAnimatedDeviceControllerPS")]
    public class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isActive")]
        [RealType("Bool")]
        public bool IsActive { get; set; }
        
        [RealName("hasInteraction")]
        [RealType("Bool")]
        public bool HasInteraction { get; set; }
        
        [RealName("randomizeAnimationTime")]
        [RealType("Bool")]
        public bool RandomizeAnimationTime { get; set; }
        
        [RealName("nameForActivation")]
        [RealType("TweakDBID")]
        public TweakDbId NameForActivation { get; set; }
        
        [RealName("nameForDeactivation")]
        [RealType("TweakDBID")]
        public TweakDbId NameForDeactivation { get; set; }
    }
}
