using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameLootContainerBasePS")]
    public class GameLootContainerBasePS : GameObjectPS
    {
        [RealName("markAsQuest")]
        public bool MarkAsQuest { get; set; }
        
        [RealName("isDisabled")]
        public bool IsDisabled { get; set; }
        
        [RealName("isLocked")]
        public bool IsLocked { get; set; }
    }
}
