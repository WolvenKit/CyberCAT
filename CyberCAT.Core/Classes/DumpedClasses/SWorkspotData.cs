using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SWorkspotData")]
    public class SWorkspotData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("componentName")]
        public CName ComponentName { get; set; }
        
        [RealName("freeCamera")]
        public bool FreeCamera { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EWorkspotOperationType? OperationType { get; set; }
    }
}
