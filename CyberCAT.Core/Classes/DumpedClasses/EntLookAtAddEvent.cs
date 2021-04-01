using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entLookAtAddEvent")]
    public class EntLookAtAddEvent : EntAnimTargetAddEvent
    {
        [RealName("outLookAtRef")]
        public AnimLookAtRef OutLookAtRef { get; set; }
        
        [RealName("request")]
        public AnimLookAtRequest Request { get; set; }
    }
}
