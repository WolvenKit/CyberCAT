using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("QuickSlotsManager")]
    public class QuickSlotsManager : GameScriptableComponent
    {
        [RealName("Player")]
        public PlayerPuppet Player { get; set; }
        
        [RealName("QuickSlotsBB")]
        public Handle<GameIBlackboard> QuickSlotsBB { get; set; }
        
        [RealName("IsPlayerInCar")]
        public bool IsPlayerInCar { get; set; }
        
        [RealName("PlayerVehicleID")]
        public EntEntityID PlayerVehicleID { get; set; }
        
        [RealName("QuickDpadCommands")]
        public QuickSlotCommand[] QuickDpadCommands { get; set; }
        
        [RealName("QuickDpadCommands_Vehicle")]
        public QuickSlotCommand[] QuickDpadCommands_Vehicle { get; set; }
        
        [RealName("DefaultHoldCommands")]
        public QuickSlotCommand[] DefaultHoldCommands { get; set; }
        
        [RealName("DefaultHoldCommands_Vehicle")]
        public QuickSlotCommand[] DefaultHoldCommands_Vehicle { get; set; }
        
        [RealName("NumberOfItemsPerWheel")]
        public int NumberOfItemsPerWheel { get; set; }
        
        [RealName("QuickKeyboardCommands")]
        public QuickSlotCommand[] QuickKeyboardCommands { get; set; }
        
        [RealName("QuickKeyboardCommands_Vehicle")]
        public QuickSlotCommand[] QuickKeyboardCommands_Vehicle { get; set; }
        
        [RealName("lastPressAndHoldBtn")]
        public Handle<QuickSlotButtonHoldEndEvent> LastPressAndHoldBtn { get; set; }
        
        [RealName("WheelList_Vehicles")]
        public QuickSlotCommand[] WheelList_Vehicles { get; set; }
        
        [RealName("currentWheelItem")]
        public QuickSlotCommand CurrentWheelItem { get; set; }
        
        [RealName("currentWeaponWheelItem")]
        public QuickSlotCommand CurrentWeaponWheelItem { get; set; }
        
        [RealName("currentGadgetWheelConsumable")]
        public QuickSlotCommand CurrentGadgetWheelConsumable { get; set; }
        
        [RealName("currentGadgetWheelGadget")]
        public QuickSlotCommand CurrentGadgetWheelGadget { get; set; }
        
        [RealName("currentVehicleWheelItem")]
        public QuickSlotCommand CurrentVehicleWheelItem { get; set; }
        
        [RealName("currentGadgetWheelItem")]
        public QuickSlotCommand CurrentGadgetWheelItem { get; set; }
        
        [RealName("currentInteractionWheelItem")]
        public QuickSlotCommand CurrentInteractionWheelItem { get; set; }
    }
}
