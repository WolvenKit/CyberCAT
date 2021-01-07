using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GenericDeviceActionsData")]
    public class GenericDeviceActionsData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("stateActionsOverrides")]
        public SGenericDeviceActionsData StateActionsOverrides { get; set; }
        
        [RealName("customActions")]
        public SCustomDeviceActionsData CustomActions { get; set; }
    }
}
