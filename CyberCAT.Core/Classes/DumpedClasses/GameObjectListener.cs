using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GameObjectListener")]
    public class GameObjectListener : IScriptable
    {
        [RealName("prereqOwner")]
        public Handle<GamePrereqState> PrereqOwner { get; set; }
        
        [RealName("e3HackBlock")]
        public bool E3HackBlock { get; set; }
    }
}
