using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AOEAreaSetup")]
    public class AOEAreaSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("areaEffect")]
        [RealType("TweakDBID")]
        public TweakDbId AreaEffect { get; set; }
        
        [RealName("actionName")]
        [RealType("TweakDBID")]
        public TweakDbId ActionName { get; set; }
        
        [RealName("blocksVisibility")]
        [RealType("Bool")]
        public bool BlocksVisibility { get; set; }
        
        [RealName("isDangerous")]
        [RealType("Bool")]
        public bool IsDangerous { get; set; }
        
        [RealName("activateOnStartup")]
        [RealType("Bool")]
        public bool ActivateOnStartup { get; set; }
        
        [RealName("effectsOnlyActiveInArea")]
        [RealType("Bool")]
        public bool EffectsOnlyActiveInArea { get; set; }
        
        [RealName("duration")]
        [RealType("Float")]
        public float Duration { get; set; }
        
        [RealName("actionWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ActionWidgetRecord { get; set; }
        
        [RealName("deviceWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId DeviceWidgetRecord { get; set; }
        
        [RealName("thumbnailWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ThumbnailWidgetRecord { get; set; }
    }
}
