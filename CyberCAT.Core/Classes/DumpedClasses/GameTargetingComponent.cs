using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameTargetingComponent")]
    public class GameTargetingComponent : EntIPlacedComponent
    {
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("aimAssistData")]
        public TweakDbId[] AimAssistData { get; set; }
        
        [RealName("isPrimary")]
        public bool IsPrimary { get; set; }
        
        [RealName("alwaysInTestRange")]
        public bool AlwaysInTestRange { get; set; }
        
        [RealName("isDirectional")]
        public bool IsDirectional { get; set; }
    }
}
