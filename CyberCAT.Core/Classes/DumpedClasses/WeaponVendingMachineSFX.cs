using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeaponVendingMachineSFX")]
    public class WeaponVendingMachineSFX : VendingMachineSFX
    {
        [RealName("processing")]
        [RealType("CName")]
        public string Processing { get; set; }
        
        [RealName("gunFalls")]
        [RealType("CName")]
        public string GunFalls { get; set; }
    }
}
