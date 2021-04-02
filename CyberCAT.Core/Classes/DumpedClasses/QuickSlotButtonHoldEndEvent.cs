using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("QuickSlotButtonHoldEndEvent")]
    public class QuickSlotButtonHoldEndEvent : RedEvent
    {
        [RealName("dPadItemDirection")]
        public DumpedEnums.EDPadSlot? DPadItemDirection { get; set; }
        
        [RealName("rightStickAngle")]
        public float RightStickAngle { get; set; }
        
        [RealName("tryExecuteCommand")]
        public bool TryExecuteCommand { get; set; }
    }
}
