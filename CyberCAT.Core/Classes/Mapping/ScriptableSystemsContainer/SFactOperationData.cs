using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SFactOperationData")]
    public class SFactOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("factName")]
        [RealType("CName")]
        public string FactName { get; set; }
        
        [RealName("factValue")]
        [RealType("Int32")]
        public int FactValue { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EMathOperationType? OperationType { get; set; }
    }
}
