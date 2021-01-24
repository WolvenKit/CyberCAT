using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IceMachineControllerPS")]
    public class IceMachineControllerPS : VendingMachineControllerPS
    {
        [RealName("vendorTweakID")]
        public TweakDbId VendorTweakID { get; set; }
        
        [RealName("iceMachineSFX")]
        public IceMachineSFX IceMachineSFX { get; set; }
    }
}
