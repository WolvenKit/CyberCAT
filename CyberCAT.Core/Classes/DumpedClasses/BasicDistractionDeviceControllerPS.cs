using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BasicDistractionDeviceControllerPS")]
    public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("distractorType")]
        [RealType("EPlaystyleType")]
        public DumpedEnums.EPlaystyleType? DistractorType { get; set; }
        
        [RealName("basicDistractionDeviceSkillChecks")]
        public Handle<EngDemoContainer> BasicDistractionDeviceSkillChecks { get; set; }
        
        [RealName("effectOnSartNames")]
        [RealType("CName")]
        public string[] EffectOnSartNames { get; set; }
        
        [RealName("animationType")]
        public DumpedEnums.EAnimationType? AnimationType { get; set; }
        
        [RealName("forceAnimationSystem")]
        [RealType("Bool")]
        public bool ForceAnimationSystem { get; set; }
    }
}
