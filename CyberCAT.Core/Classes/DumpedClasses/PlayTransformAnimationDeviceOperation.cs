using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayTransformAnimationDeviceOperation")]
    public class PlayTransformAnimationDeviceOperation : DeviceOperationBase
    {
        [RealName("transformAnimations")]
        public STransformAnimationData[] TransformAnimations { get; set; }

        public PlayTransformAnimationDeviceOperation()
        {
            IsEnabled = true;
        }
    }
}
