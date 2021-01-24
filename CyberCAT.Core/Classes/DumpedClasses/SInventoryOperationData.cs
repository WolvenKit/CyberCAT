using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SInventoryOperationData")]
    public class SInventoryOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemName")]
        public TweakDbId ItemName { get; set; }
        
        [RealName("quantity")]
        public int Quantity { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EItemOperationType? OperationType { get; set; }
    }
}
