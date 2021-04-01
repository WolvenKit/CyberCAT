using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AnimFeature_Inspection")]
    public class AnimFeature_Inspection : AnimAnimFeature
    {
        [RealName("activeInspectionStage")]
        public int ActiveInspectionStage { get; set; }
        
        [RealName("rotationX")]
        public float RotationX { get; set; }
        
        [RealName("rotationY")]
        public float RotationY { get; set; }
        
        [RealName("offsetX")]
        public float OffsetX { get; set; }
        
        [RealName("offsetY")]
        public float OffsetY { get; set; }
    }
}
