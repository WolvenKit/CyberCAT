using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SWidgetPackage")]
    public class SWidgetPackage : SWidgetPackageBase
    {
        [RealName("displayName")]
        public string DisplayName { get; set; }
        
        [RealName("ownerID")]
        public GamePersistentID OwnerID { get; set; }
        
        [RealName("ownerIDClassName")]
        public CName OwnerIDClassName { get; set; }
        
        [RealName("customData")]
        public Handle<WidgetCustomData> CustomData { get; set; }
        
        [RealName("isWidgetInactive")]
        public bool IsWidgetInactive { get; set; }
        
        [RealName("widgetState")]
        public DumpedEnums.EWidgetState? WidgetState { get; set; }
        
        [RealName("iconID")]
        public CName IconID { get; set; }
        
        [RealName("bckgroundTextureID")]
        public TweakDbId BckgroundTextureID { get; set; }
        
        [RealName("iconTextureID")]
        public TweakDbId IconTextureID { get; set; }
        
        [RealName("textData")]
        public Handle<TextTextParameterSet> TextData { get; set; }
    }
}
