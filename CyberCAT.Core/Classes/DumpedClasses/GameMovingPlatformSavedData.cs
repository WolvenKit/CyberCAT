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
        [RealType("CName")]
        public string DestinationName { get; set; }
        
        [RealName("destinationData")]
        [RealType("Int32")]
        public int DestinationData { get; set; }
        
        [RealName("time")]
        [RealType("Float")]
        public float Time { get; set; }
        
        [RealName("maxTime")]
        [RealType("Float")]
        public float MaxTime { get; set; }
        
        [RealName("mountedPlayerEntityID")]
        [RealType("Uint32")]
        public uint MountedPlayerEntityID { get; set; }
    }
}
