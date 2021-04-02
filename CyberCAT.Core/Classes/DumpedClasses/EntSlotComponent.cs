using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entSlotComponent")]
    public class EntSlotComponent : EntIPlacedComponent
    {
        [RealName("slots")]
        public EntSlot[] Slots { get; set; }
        
        [RealName("fallbackSlots")]
        public EntFallbackSlot[] FallbackSlots { get; set; }
    }
}
