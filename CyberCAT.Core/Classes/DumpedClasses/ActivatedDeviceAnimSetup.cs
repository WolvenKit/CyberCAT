using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ActivatedDeviceAnimSetup")]
    public class ActivatedDeviceAnimSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animationTime")]
        [RealType("Float")]
        public float AnimationTime { get; set; }
    }
}
