using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeakFenceControllerPS")]
    public class WeakFenceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("weakfenceSkillChecks")]
        public Handle<EngDemoContainer> WeakfenceSkillChecks { get; set; }
        
        [RealName("weakFenceSetup")]
        public WeakFenceSetup WeakFenceSetup { get; set; }
    }
}
