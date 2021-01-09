using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TemporaryDoorState")]
    public class TemporaryDoorState : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("door")]
        public DumpedEnums.vehicleEVehicleDoor? Door { get; set; }
        
        [RealName("interactionState")]
        public DumpedEnums.vehicleVehicleDoorInteractionState? InteractionState { get; set; }
    }
}
