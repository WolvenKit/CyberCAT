using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RoadBlockControllerPS")]
    public class RoadBlockControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isBlocking")]
        [RealType("Bool")]
        public bool IsBlocking { get; set; }
        
        [RealName("negateAnimState")]
        [RealType("Bool")]
        public bool NegateAnimState { get; set; }
        
        [RealName("nameForBlocking")]
        [RealType("TweakDBID")]
        public TweakDbId NameForBlocking { get; set; }
        
        [RealName("nameForUnblocking")]
        [RealType("TweakDBID")]
        public TweakDbId NameForUnblocking { get; set; }
    }
}
