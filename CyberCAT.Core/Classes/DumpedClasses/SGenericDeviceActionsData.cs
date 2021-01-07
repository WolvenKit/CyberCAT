using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SGenericDeviceActionsData")]
    public class SGenericDeviceActionsData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("toggleON")]
        public SDeviceActionBoolData ToggleON { get; set; }
        
        [RealName("togglePower")]
        public SDeviceActionBoolData TogglePower { get; set; }
    }
}
