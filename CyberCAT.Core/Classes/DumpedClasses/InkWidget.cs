using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkWidget")]
    public class InkWidget : IScriptable
    {
        [RealName("propertyManager")]
        public Handle<InkPropertyManager> PropertyManager { get; set; }
        
        [RealName("layout")]
        public InkWidgetLayout Layout { get; set; }
        
        [RealName("renderTransform")]
        public InkUITransform RenderTransform { get; set; }
        
        [RealName("userData")]
        public Handle<InkUserData>[] UserData { get; set; }
        
        [RealName("secondaryControllers")]
        public Handle<InkWidgetLogicController>[] SecondaryControllers { get; set; }
        
        [RealName("effects")]
        public Handle<InkIEffect>[] Effects { get; set; }
        
        [RealName("logicController")]
        public Handle<InkWidgetLogicController> LogicController { get; set; }
        
        [RealName("style")]
        public Handle<InkStyleResourceWrapper> Style { get; set; }
        
        [RealName("parentWidget")]
        public InkWidget ParentWidget { get; set; }
        
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("state")]
        public CName State { get; set; }
        
        [RealName("size")]
        public Vector2 Size { get; set; }
        
        [RealName("renderTransformPivot")]
        public Vector2 RenderTransformPivot { get; set; }
        
        [RealName("tintColor")]
        public HDRColor TintColor { get; set; }
        
        [RealName("opacity")]
        public float Opacity { get; set; }
        
        [RealName("visible")]
        public bool Visible { get; set; }
        
        [RealName("canSupportFocus")]
        public bool CanSupportFocus { get; set; }
        
        [RealName("fitToContent")]
        public bool FitToContent { get; set; }
        
        [RealName("isInteractive")]
        public bool IsInteractive { get; set; }
        
        [RealName("affectsLayoutWhenHidden")]
        public bool AffectsLayoutWhenHidden { get; set; }
    }
}
