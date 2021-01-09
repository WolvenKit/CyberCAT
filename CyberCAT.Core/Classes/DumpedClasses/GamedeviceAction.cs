using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceAction")]
    public class GamedeviceAction : RedEvent
    {
        [RealName("actionName")]
        [RealType("CName")]
        public string ActionName { get; set; }
        
        [RealName("clearanceLevel")]
        [RealType("Int32")]
        public int ClearanceLevel { get; set; }
        
        [RealName("localizedObjectName")]
        [RealType("String")]
        public string LocalizedObjectName { get; set; }
    }
}
