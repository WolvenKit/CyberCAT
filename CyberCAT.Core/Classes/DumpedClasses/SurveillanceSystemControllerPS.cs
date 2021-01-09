using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SurveillanceSystemControllerPS")]
    public class SurveillanceSystemControllerPS : DeviceSystemBaseControllerPS
    {
        [RealName("isRevealingEnemies")]
        [RealType("Bool")]
        public bool IsRevealingEnemies { get; set; }
    }
}
