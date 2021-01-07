using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CleaningMachineControllerPS")]
    public class CleaningMachineControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("cleaningMachineSkillChecks")]
        public Handle<EngDemoContainer> CleaningMachineSkillChecks { get; set; }
    }
}
