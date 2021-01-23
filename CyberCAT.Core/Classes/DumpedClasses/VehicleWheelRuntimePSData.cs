using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehicleWheelRuntimePSData")]
    public class VehicleWheelRuntimePSData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("previousTouchedMaterial")]
        public CName PreviousTouchedMaterial { get; set; }
        
        [RealName("previousVisualDisplacement")]
        public float PreviousVisualDisplacement { get; set; }
        
        [RealName("previousLogicalSpringCompression")]
        public float PreviousLogicalSpringCompression { get; set; }
        
        [RealName("previousSwaybarDisplacement")]
        public float PreviousSwaybarDisplacement { get; set; }
        
        [RealName("previousDampedSpringForce")]
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
