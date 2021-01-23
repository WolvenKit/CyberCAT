using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ElevatorFloorSetup")]
    public class ElevatorFloorSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isHidden")]
        public bool IsHidden { get; set; }
        
        [RealName("isInactive")]
        public bool IsInactive { get; set; }
        
        [RealName("floorMarker")]
        public NodeRef FloorMarker { get; set; }
        
        [RealName("floorName")]
        public string FloorName { get; set; }
        
        [RealName("floorDisplayName")]
        public CName FloorDisplayName { get; set; }
        
        [RealName("authorizationTextOverride")]
        public string AuthorizationTextOverride { get; set; }
        
        [RealName("doorShouldOpenFrontLeftRight")]
        public bool[] DoorShouldOpenFrontLeftRight { get; set; }
    }
}
