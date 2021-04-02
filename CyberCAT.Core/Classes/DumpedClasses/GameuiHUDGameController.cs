using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameuiHUDGameController")]
    public class GameuiHUDGameController : GameuiWidgetGameController
    {
        [RealName("showAnimDef")]
        public Handle<InkanimDefinition> ShowAnimDef { get; set; }
        
        [RealName("hideAnimDef")]
        public Handle<InkanimDefinition> HideAnimDef { get; set; }
        
        [RealName("showAnimationName")]
        public CName ShowAnimationName { get; set; }
        
        [RealName("hideAnimationName")]
        public CName HideAnimationName { get; set; }
        
        [RealName("moduleShown")]
        public bool ModuleShown { get; set; }
        
        [RealName("showAnimProxy")]
        public Handle<InkanimProxy> ShowAnimProxy { get; set; }
        
        [RealName("hideAnimProxy")]
        public Handle<InkanimProxy> HideAnimProxy { get; set; }
    }
}
