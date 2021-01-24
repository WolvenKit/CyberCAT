using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AOEEffectorControllerPS")]
    public class AOEEffectorControllerPS : ActivatedDeviceControllerPS
    {
        [RealName("effectsToPlay")]
        public CName[] EffectsToPlay { get; set; }
    }
}
