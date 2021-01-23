using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AOEAreaSetup")]
    public class AOEAreaSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaEffect")]
        public TweakDbId AreaEffect { get; set; }
        
        [RealName("actionName")]
        public TweakDbId ActionName { get; set; }
        
        [RealName("blocksVisibility")]
        public bool BlocksVisibility { get; set; }
        
        [RealName("isDangerous")]
        public bool IsDangerous { get; set; }
        
        [RealName("activateOnStartup")]
        public bool ActivateOnStartup { get; set; }
        
        [RealName("effectsOnlyActiveInArea")]
        public bool EffectsOnlyActiveInArea { get; set; }
        
        [RealName("duration")]
        public float Duration { get; set; }
        
        [RealName("actionWidgetRecord")]
        public TweakDbId ActionWidgetRecord { get; set; }
        
        [RealName("deviceWidgetRecord")]
        public TweakDbId DeviceWidgetRecord { get; set; }
        
        [RealName("thumbnailWidgetRecord")]
        public TweakDbId ThumbnailWidgetRecord { get; set; }
    }
}
