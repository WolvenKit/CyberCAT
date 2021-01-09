using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ForkliftControllerPS")]
    public class ForkliftControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("forkliftSetup")]
        public ForkliftSetup ForkliftSetup { get; set; }
        
        [RealName("isUp")]
        [RealType("Bool")]
        public bool IsUp { get; set; }
    }
}
