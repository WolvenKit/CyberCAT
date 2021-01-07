using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MovableDeviceControllerPS")]
    public class MovableDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("MovableDeviceSetup")]
        public MovableDeviceSetup MovableDeviceSetup { get; set; }
        
        [RealName("movableDeviceSkillChecks")]
        public Handle<DemolitionContainer> MovableDeviceSkillChecks { get; set; }
    }
}
