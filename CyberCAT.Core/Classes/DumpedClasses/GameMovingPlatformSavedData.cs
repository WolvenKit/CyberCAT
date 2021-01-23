using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMovingPlatformSavedData")]
    public class GameMovingPlatformSavedData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("movement")]
        public Handle<GameIMovingPlatformMovement> Movement { get; set; }
        
        [RealName("destinationName")]
        public CName DestinationName { get; set; }
        
        [RealName("destinationData")]
        public int DestinationData { get; set; }
        
        [RealName("time")]
        public float Time { get; set; }
        
        [RealName("maxTime")]
        public float MaxTime { get; set; }
        
        [RealName("mountedPlayerEntityID")]
        public uint MountedPlayerEntityID { get; set; }
    }
}
