using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PuppetDeviceLinkPS")]
    public class PuppetDeviceLinkPS : DeviceLinkComponentPS
    {
        [RealName("securitySystemData")]
        public SecuritySystemData SecuritySystemData { get; set; }
    }
}
