using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameLootContainerBasePS")]
    public class GameLootContainerBasePS : GameObjectPS
    {
        [RealName("markAsQuest")]
        [RealType("Bool")]
        public bool MarkAsQuest { get; set; }
        
        [RealName("isDisabled")]
        [RealType("Bool")]
        public bool IsDisabled { get; set; }
        
        [RealName("isLocked")]
        [RealType("Bool")]
        public bool IsLocked { get; set; }
    }
}
