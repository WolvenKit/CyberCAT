using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameScriptableComponent")]
    public class GameScriptableComponent : GameComponent
    {
        [RealName("priority")]
        public uint Priority { get; set; }
    }
}
