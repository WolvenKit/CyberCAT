using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SInventoryOperationData")]
    public class SInventoryOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("itemName")]
        [RealType("TweakDBID")]
        public TweakDbId ItemName { get; set; }
        
        [RealName("quantity")]
        [RealType("Int32")]
        public int Quantity { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EItemOperationType? OperationType { get; set; }
    }
}
