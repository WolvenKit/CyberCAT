using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamePersistentID")]
    public class GamePersistentID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityHash")]
        public ulong EntityHash { get; set; }
        
        [RealName("componentName")]
        public CName ComponentName { get; set; }
    }
}
