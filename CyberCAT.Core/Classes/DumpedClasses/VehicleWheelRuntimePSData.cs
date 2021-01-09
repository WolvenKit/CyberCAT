using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleWheelRuntimePSData")]
    public class VehicleWheelRuntimePSData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("previousTouchedMaterial")]
        [RealType("CName")]
        public string PreviousTouchedMaterial { get; set; }
        
        [RealName("previousVisualDisplacement")]
        [RealType("Float")]
        public float PreviousVisualDisplacement { get; set; }
        
        [RealName("previousLogicalSpringCompression")]
        [RealType("Float")]
        public float PreviousLogicalSpringCompression { get; set; }
        
        [RealName("previousSwaybarDisplacement")]
        [RealType("Float")]
        public float PreviousSwaybarDisplacement { get; set; }
        
        [RealName("previousDampedSpringForce")]
        [RealType("Float")]
        public float PreviousDampedSpringForce { get; set; }

        public VehicleWheelRuntimePSData()
        {
            // TODO: Verify this
            PreviousLogicalSpringCompression = 1F;
            PreviousDampedSpringForce = 1F;
            PreviousSwaybarDisplacement = 1F;
        }
    }
}
