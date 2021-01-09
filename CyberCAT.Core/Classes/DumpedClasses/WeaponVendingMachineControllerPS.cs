using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeaponVendingMachineControllerPS")]
    public class WeaponVendingMachineControllerPS : VendingMachineControllerPS
    {
        [RealName("weaponVendingMachineSetup")]
        public WeaponVendingMachineSetup WeaponVendingMachineSetup { get; set; }
        
        [RealName("weaponVendingMachineSFX")]
        public WeaponVendingMachineSFX WeaponVendingMachineSFX { get; set; }
    }
}
