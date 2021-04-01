using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameDelayedFunctionsScheduler")]
    public class GameDelayedFunctionsScheduler : ISerializable
    {
        [RealName("currentTime")]
        public EngineTime CurrentTime { get; set; }
        
        [RealName("nextCallId")]
        public uint NextCallId { get; set; }
        
        [RealName("initialized")]
        public bool Initialized { get; set; }
    }
}
