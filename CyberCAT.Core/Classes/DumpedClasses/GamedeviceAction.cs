using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceAction")]
    public class GamedeviceAction : RedEvent
    {
        [RealName("actionName")]
        public CName ActionName { get; set; }
        
        [RealName("clearanceLevel")]
        public int ClearanceLevel { get; set; }
        
        [RealName("localizedObjectName")]
        public string LocalizedObjectName { get; set; }
    }
}
