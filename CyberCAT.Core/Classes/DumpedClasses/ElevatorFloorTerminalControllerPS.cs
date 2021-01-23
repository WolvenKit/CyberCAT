using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ElevatorFloorTerminalControllerPS")]
    public class ElevatorFloorTerminalControllerPS : TerminalControllerPS
    {
        [RealName("elevatorFloorSetup")]
        public ElevatorFloorSetup ElevatorFloorSetup { get; set; }
        
        [RealName("hasDirectInteration")]
        public bool HasDirectInteration { get; set; }
        
        [RealName("isElevatorAtThisFloor")]
        public bool IsElevatorAtThisFloor { get; set; }
    }
}
