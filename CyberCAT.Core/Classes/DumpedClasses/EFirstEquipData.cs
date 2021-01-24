using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("EFirstEquipData")]
    public class EFirstEquipData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("weaponID")]
        public TweakDbId WeaponID { get; set; }
        
        [RealName("hasPlayedFirstEquip")]
        public bool HasPlayedFirstEquip { get; set; }
    }
}
