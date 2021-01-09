using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameDelayedFunctionsScheduler")]
    public class GameDelayedFunctionsScheduler : ISerializable
    {
        [RealName("initialized")]
        [RealType("Bool")]
        public bool Initialized { get; set; }
        
        [RealName("currentTime")]
        public EngineTime CurrentTime { get; set; }
        
        [RealName("nextCallId")]
        [RealType("Uint32")]
        public uint NextCallId { get; set; }
    }
}
