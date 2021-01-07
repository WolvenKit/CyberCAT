using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RetractableAdControllerPS")]
    public class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
    {
        [RealName("isControlled")]
        [RealType("Bool")]
        public bool IsControlled { get; set; }
    }
}
