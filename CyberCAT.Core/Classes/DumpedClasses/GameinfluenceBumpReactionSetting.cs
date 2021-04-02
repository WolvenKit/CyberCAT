using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinfluenceBumpReactionSetting")]
    public class GameinfluenceBumpReactionSetting : ISerializable
    {
        [RealName("reaction")]
        public DumpedEnums.gameinteractionsBumpIntensity? Reaction { get; set; }
        
        [RealName("maxVelocity")]
        public float MaxVelocity { get; set; }
    }
}
