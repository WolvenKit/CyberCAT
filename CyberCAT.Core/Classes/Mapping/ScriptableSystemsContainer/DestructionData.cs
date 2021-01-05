using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DestructionData")]
    public class DestructionData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("durabilityType")]
        public DumpedEnums.EDeviceDurabilityType? DurabilityType { get; set; }
        
        [RealName("canBeFixed")]
        [RealType("Bool")]
        public bool CanBeFixed { get; set; }
    }
}
