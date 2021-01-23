using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SStimOperationData")]
    public class SStimOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("stimType")]
        public DumpedEnums.DeviceStimType? StimType { get; set; }
        
        [RealName("lifeTime")]
        public float LifeTime { get; set; }
        
        [RealName("radius")]
        public float Radius { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EEffectOperationType? OperationType { get; set; }
        
        [RealName("nodeRef")]
        public NodeRef NodeRef { get; set; }
    }
}
