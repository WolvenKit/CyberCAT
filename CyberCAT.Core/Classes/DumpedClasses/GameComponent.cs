using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameComponent")]
    public class GameComponent : EntIComponent
    {
        [RealName("persistentState")]
        public Handle<GamePersistentState> PersistentState { get; set; }
    }
}
