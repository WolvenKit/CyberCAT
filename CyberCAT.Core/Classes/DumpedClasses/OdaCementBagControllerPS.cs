using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OdaCementBagControllerPS")]
    public class OdaCementBagControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("cementEffectCooldown")]
        [RealType("Float")]
        public float CementEffectCooldown { get; set; }
    }
}
