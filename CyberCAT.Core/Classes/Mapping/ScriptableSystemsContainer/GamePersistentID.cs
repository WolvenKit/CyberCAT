using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gamePersistentID")]
    public class GamePersistentID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityHash")]
        [RealType("Uint64")]
        public ulong EntityHash { get; set; }
        
        [RealName("componentName")]
        [RealType("CName")]
        public string ComponentName { get; set; }
    }
}
