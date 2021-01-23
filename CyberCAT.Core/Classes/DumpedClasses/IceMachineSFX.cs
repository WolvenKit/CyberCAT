using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IceMachineSFX")]
    public class IceMachineSFX : VendingMachineSFX
    {
        [RealName("iceFalls")]
        public CName IceFalls { get; set; }
        
        [RealName("processing")]
        public CName Processing { get; set; }
    }
}
