using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleCameraManagerComponentPS")]
    public class VehicleCameraManagerComponentPS : GameComponentPS
    {
        [RealName("perspective")]
        public DumpedEnums.vehicleCameraPerspective? Perspective { get; set; }
    }
}
