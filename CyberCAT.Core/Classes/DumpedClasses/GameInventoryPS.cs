using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameInventoryPS")]
    public class GameInventoryPS : GameComponentPS
    {
        [RealName("isRegisteredShared")]
        public bool IsRegisteredShared { get; set; }
        
        [RealName("accessible")]
        public bool Accessible { get; set; }

        public GameInventoryPS()
        {
            Accessible = true;
        }
    }
}
