using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DataTermControllerPS")]
    public class DataTermControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("linkedFastTravelPoint")]
        public Handle<GameFastTravelPointData> LinkedFastTravelPoint { get; set; }
        
        [RealName("triggerType")]
        public DumpedEnums.EFastTravelTriggerType? TriggerType { get; set; }
    }
}
