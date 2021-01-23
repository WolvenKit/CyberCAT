using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActivatedDeviceControllerPS")]
    public class ActivatedDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("animationSetup")]
        public ActivatedDeviceAnimSetup AnimationSetup { get; set; }
        
        [RealName("activatedDeviceSetup")]
        public ActivatedDeviceSetup ActivatedDeviceSetup { get; set; }
        
        [RealName("spiderbotInteractionLocationOverride")]
        public NodeRef SpiderbotInteractionLocationOverride { get; set; }
        
        [RealName("industrialArmAnimationOverride")]
        public int IndustrialArmAnimationOverride { get; set; }
    }
}
