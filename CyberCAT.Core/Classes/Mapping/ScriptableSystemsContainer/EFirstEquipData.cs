using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("EFirstEquipData")]
    public class EFirstEquipData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("weaponID")]
        [RealType("TweakDBID")]
        public ulong WeaponID { get; set; }
        
        [RealName("hasPlayedFirstEquip")]
        [RealType("Bool")]
        public bool HasPlayedFirstEquip { get; set; }
    }
}
