using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CameraSetup")]
    public class CameraSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("canStreamVideo")]
        public bool CanStreamVideo { get; set; }
    }
}
