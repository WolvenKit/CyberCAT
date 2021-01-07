using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MeshAppearanceDeviceOperation")]
    public class MeshAppearanceDeviceOperation : DeviceOperationBase
    {
        [RealName("meshesAppearence")]
        [RealType("CName")]
        public string MeshesAppearence { get; set; }
    }
}
