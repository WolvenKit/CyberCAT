using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SBinkperationData")]
    public class SBinkperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("componentName")]
        [RealType("CName")]
        public string ComponentName { get; set; }
        
        [RealName("binkPath")]
        public RedResourceReferenceScriptToken BinkPath { get; set; }
        
        [RealName("loop")]
        [RealType("Bool")]
        public bool Loop { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EBinkOperationType? OperationType { get; set; }
    }
}
