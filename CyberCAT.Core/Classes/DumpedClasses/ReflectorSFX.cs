using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ReflectorSFX")]
    public class ReflectorSFX : VendingMachineSFX
    {
        [RealName("distraction")]
        public CName Distraction { get; set; }
        
        [RealName("turnOn")]
        public CName TurnOn { get; set; }
        
        [RealName("turnOff")]
        public CName TurnOff { get; set; }
    }
}
