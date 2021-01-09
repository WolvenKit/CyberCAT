using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NetrunnerControlPanelControllerPS")]
    public class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
    {
        [RealName("factQuickHackSetup")]
        public ComputerQuickHackData FactQuickHackSetup { get; set; }
        
        [RealName("quickhackPerformed")]
        [RealType("Bool")]
        public bool QuickhackPerformed { get; set; }
    }
}
