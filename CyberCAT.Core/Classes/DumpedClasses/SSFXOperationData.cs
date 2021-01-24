using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SSFXOperationData")]
    public class SSFXOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("sfxName")]
        public CName SfxName { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EEffectOperationType? OperationType { get; set; }
    }
}
