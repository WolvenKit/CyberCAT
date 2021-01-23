using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SActionWidgetPackage")]
    public class SActionWidgetPackage : SWidgetPackage
    {
        [RealName("action")]
        public Handle<GamedeviceAction> Action { get; set; }
        
        [RealName("wasInitalized")]
        public bool WasInitalized { get; set; }
        
        [RealName("dependendActions")]
        public Handle<GamedeviceAction>[] DependendActions { get; set; }
    }
}
