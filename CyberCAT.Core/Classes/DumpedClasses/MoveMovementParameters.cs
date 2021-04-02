using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("moveMovementParameters")]
    public class MoveMovementParameters : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.moveMovementType? Type { get; set; }
        
        [RealName("maxSpeed")]
        public float MaxSpeed { get; set; }
        
        [RealName("acceleration")]
        public float Acceleration { get; set; }
        
        [RealName("deceleration")]
        public float Deceleration { get; set; }
        
        [RealName("rotationSpeed")]
        public float RotationSpeed { get; set; }
    }
}
