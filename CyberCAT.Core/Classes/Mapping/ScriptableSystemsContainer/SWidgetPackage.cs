using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SWidgetPackage")]
    public class SWidgetPackage : SWidgetPackageBase
    {
        [RealName("displayName")]
        [RealType("String")]
        public string DisplayName { get; set; }
        
        [RealName("ownerID")]
        public GamePersistentID OwnerID { get; set; }
        
        [RealName("ownerIDClassName")]
        [RealType("CName")]
        public string OwnerIDClassName { get; set; }
        
        [RealName("customData")]
        public Handle<WidgetCustomData> CustomData { get; set; }
        
        [RealName("isWidgetInactive")]
        [RealType("Bool")]
        public bool IsWidgetInactive { get; set; }
        
        [RealName("widgetState")]
        public DumpedEnums.EWidgetState? WidgetState { get; set; }
        
        [RealName("iconID")]
        [RealType("CName")]
        public string IconID { get; set; }
        
        [RealName("bckgroundTextureID")]
        [RealType("TweakDBID")]
        public TweakDbId BckgroundTextureID { get; set; }
        
        [RealName("iconTextureID")]
        [RealType("TweakDBID")]
        public TweakDbId IconTextureID { get; set; }
        
        [RealName("textData")]
        public Handle<TextTextParameterSet> TextData { get; set; }
    }
}
