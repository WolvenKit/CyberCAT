using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceLinkComponentPS")]
    public class DeviceLinkComponentPS : SharedGameplayPS
    {
        [RealName("parentDevice")]
        public DeviceLink ParentDevice { get; set; }
        
        [RealName("isConnected")]
        [RealType("Bool")]
        public bool IsConnected { get; set; }
        
        [RealName("ownerEntityID")]
        public EntEntityID OwnerEntityID { get; set; }
    }
}
