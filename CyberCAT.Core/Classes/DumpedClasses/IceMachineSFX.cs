using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IceMachineSFX")]
    public class IceMachineSFX : VendingMachineSFX
    {
        [RealName("iceFalls")]
        [RealType("CName")]
        public string IceFalls { get; set; }
        
        [RealName("processing")]
        [RealType("CName")]
        public string Processing { get; set; }
    }
}
