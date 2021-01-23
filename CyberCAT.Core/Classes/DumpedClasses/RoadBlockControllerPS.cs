using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RoadBlockControllerPS")]
    public class RoadBlockControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isBlocking")]
        public bool IsBlocking { get; set; }
        
        [RealName("negateAnimState")]
        public bool NegateAnimState { get; set; }
        
        [RealName("nameForBlocking")]
        public TweakDbId NameForBlocking { get; set; }
        
        [RealName("nameForUnblocking")]
        public TweakDbId NameForUnblocking { get; set; }
    }
}
