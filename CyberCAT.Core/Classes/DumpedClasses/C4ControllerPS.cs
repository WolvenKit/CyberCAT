using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("C4ControllerPS")]
    public class C4ControllerPS : ExplosiveDeviceControllerPS
    {
        [RealName("itemTweakDBString")]
        [RealType("CName")]
        public string ItemTweakDBString { get; set; }
    }
}
