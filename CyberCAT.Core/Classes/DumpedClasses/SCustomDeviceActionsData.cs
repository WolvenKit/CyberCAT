using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SCustomDeviceActionsData")]
    public class SCustomDeviceActionsData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actions")]
        public SDeviceActionCustomData[] Actions { get; set; }
    }
}
