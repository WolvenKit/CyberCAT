using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entBaseCameraComponent")]
    public class EntBaseCameraComponent : EntIPlacedComponent
    {
        [RealName("fov")]
        public float Fov { get; set; }
        
        [RealName("zoom")]
        public float Zoom { get; set; }
        
        [RealName("nearPlaneOverride")]
        public float NearPlaneOverride { get; set; }
        
        [RealName("farPlaneOverride")]
        public float FarPlaneOverride { get; set; }
        
        [RealName("motionBlurScale")]
        public float MotionBlurScale { get; set; }
    }
}
