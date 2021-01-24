using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("MeshAppearanceDeviceOperation")]
    public class MeshAppearanceDeviceOperation : DeviceOperationBase
    {
        [RealName("meshesAppearence")]
        public CName MeshesAppearence { get; set; }
    }
}
