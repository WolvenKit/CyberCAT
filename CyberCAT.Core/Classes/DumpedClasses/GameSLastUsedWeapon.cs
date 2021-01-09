using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameSLastUsedWeapon")]
    public class GameSLastUsedWeapon : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("lastUsedWeapon")]
        public GameItemID LastUsedWeapon { get; set; }
        
        [RealName("lastUsedRanged")]
        public GameItemID LastUsedRanged { get; set; }
        
        [RealName("lastUsedMelee")]
        public GameItemID LastUsedMelee { get; set; }
        
        [RealName("lastUsedHeavy")]
        public GameItemID LastUsedHeavy { get; set; }
    }
}
