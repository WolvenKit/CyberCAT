using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WindowControllerPS")]
    public class WindowControllerPS : DoorControllerPS
    {
        [RealName("windowSkillChecks")]
        public Handle<EngDemoContainer> WindowSkillChecks { get; set; }
    }
}
