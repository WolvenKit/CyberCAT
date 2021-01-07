using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameInventoryPS")]
    public class GameInventoryPS : GameComponentPS
    {
        [RealName("isRegisteredShared")]
        [RealType("Bool")]
        public bool IsRegisteredShared { get; set; }
        
        [RealName("accessible")]
        [RealType("Bool")]
        public bool Accessible { get; set; }
    }
}
