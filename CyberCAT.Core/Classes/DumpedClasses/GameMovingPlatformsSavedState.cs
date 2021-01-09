using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMovingPlatformsSavedState")]
    public class GameMovingPlatformsSavedState : ISerializable
    {
        [RealName("mapping")]
        public EntEntityID[] Mapping { get; set; }
        
        [RealName("data")]
        public GameMovingPlatformSavedData[] Data { get; set; }
    }
}
