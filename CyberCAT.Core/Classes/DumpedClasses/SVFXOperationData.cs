using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SVFXOperationData")]
    public class SVFXOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("vfxName")]
        [RealType("CName")]
        public string VfxName { get; set; }
        
        [RealName("vfxResource")]
        public GameFxResource VfxResource { get; set; }
        
        [RealName("shouldPersist")]
        [RealType("Bool")]
        public bool ShouldPersist { get; set; }
        
        [RealName("size")]
        [RealType("Float")]
        public float Size { get; set; }
        
        [RealName("nodeRef")]
        [RealType("NodeRef")]
        public string NodeRef { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EEffectOperationType? OperationType { get; set; }
    }
}
