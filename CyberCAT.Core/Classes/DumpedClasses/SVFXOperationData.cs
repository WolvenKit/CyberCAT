using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SVFXOperationData")]
    public class SVFXOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("vfxName")]
        public CName VfxName { get; set; }
        
        [RealName("vfxResource")]
        public GameFxResource VfxResource { get; set; }
        
        [RealName("shouldPersist")]
        public bool ShouldPersist { get; set; }
        
        [RealName("size")]
        public float Size { get; set; }
        
        [RealName("nodeRef")]
        public NodeRef NodeRef { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EEffectOperationType? OperationType { get; set; }
    }
}
