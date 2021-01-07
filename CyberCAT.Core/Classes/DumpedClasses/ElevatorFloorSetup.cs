using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ElevatorFloorSetup")]
    public class ElevatorFloorSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isHidden")]
        [RealType("Bool")]
        public bool IsHidden { get; set; }
        
        [RealName("isInactive")]
        [RealType("Bool")]
        public bool IsInactive { get; set; }
        
        [RealName("floorMarker")]
        [RealType("NodeRef")]
        public string FloorMarker { get; set; }
        
        [RealName("floorName")]
        [RealType("String")]
        public string FloorName { get; set; }
        
        [RealName("floorDisplayName")]
        [RealType("CName")]
        public string FloorDisplayName { get; set; }
        
        [RealName("authorizationTextOverride")]
        [RealType("String")]
        public string AuthorizationTextOverride { get; set; }
        
        [RealName("doorShouldOpenFrontLeftRight")]
        [RealType("Bool")]
        public bool[] DoorShouldOpenFrontLeftRight { get; set; }
    }
}
