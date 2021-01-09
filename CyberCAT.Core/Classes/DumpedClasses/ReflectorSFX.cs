using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ReflectorSFX")]
    public class ReflectorSFX : VendingMachineSFX
    {
        [RealName("distraction")]
        [RealType("CName")]
        public string Distraction { get; set; }
        
        [RealName("turnOn")]
        [RealType("CName")]
        public string TurnOn { get; set; }
        
        [RealName("turnOff")]
        [RealType("CName")]
        public string TurnOff { get; set; }
    }
}
