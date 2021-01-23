using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SToggleDeviceOperationData")]
    public class SToggleDeviceOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("operationName")]
        public CName OperationName { get; set; }
        
        [RealName("enable")]
        public bool Enable { get; set; }
    }
}
