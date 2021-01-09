using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SToggleDeviceOperationData")]
    public class SToggleDeviceOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("operationName")]
        [RealType("CName")]
        public string OperationName { get; set; }
        
        [RealName("enable")]
        [RealType("Bool")]
        public bool Enable { get; set; }
    }
}
