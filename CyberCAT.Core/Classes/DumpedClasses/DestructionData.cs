using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DestructionData")]
    public class DestructionData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("durabilityType")]
        public DumpedEnums.EDeviceDurabilityType? DurabilityType { get; set; }
        
        [RealName("canBeFixed")]
        public bool CanBeFixed { get; set; }
    }
}
