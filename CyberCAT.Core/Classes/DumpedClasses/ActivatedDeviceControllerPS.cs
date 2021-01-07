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
        [RealType("NodeRef")]
        public string SpiderbotInteractionLocationOverride { get; set; }
        
        [RealName("industrialArmAnimationOverride")]
        [RealType("Int32")]
        public int IndustrialArmAnimationOverride { get; set; }
    }
}
