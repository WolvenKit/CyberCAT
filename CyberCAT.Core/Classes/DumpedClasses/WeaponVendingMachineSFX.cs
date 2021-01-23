using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeaponVendingMachineSFX")]
    public class WeaponVendingMachineSFX : VendingMachineSFX
    {
        [RealName("processing")]
        public CName Processing { get; set; }
        
        [RealName("gunFalls")]
        public CName GunFalls { get; set; }
    }
}
