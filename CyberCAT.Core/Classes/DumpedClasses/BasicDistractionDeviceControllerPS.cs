using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BasicDistractionDeviceControllerPS")]
    public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("distractorType")]
        public DumpedEnums.EPlaystyleType? DistractorType { get; set; }
        
        [RealName("basicDistractionDeviceSkillChecks")]
        public Handle<EngDemoContainer> BasicDistractionDeviceSkillChecks { get; set; }
        
        [RealName("effectOnSartNames")]
        public CName[] EffectOnSartNames { get; set; }
        
        [RealName("animationType")]
        public DumpedEnums.EAnimationType? AnimationType { get; set; }
        
        [RealName("forceAnimationSystem")]
        public bool ForceAnimationSystem { get; set; }
    }
}
