using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WorldWidgetComponent")]
    public class WorldWidgetComponent : IWorldWidgetComponent
    {
        [RealName("screenDefinition")]
        public SUIScreenDefinition ScreenDefinition { get; set; }
        
        [RealName("cursorResource")]
        public InkWidgetLibraryResource CursorResource { get; set; }
        
        [RealName("widgetResource")]
        public InkWidgetLibraryResource WidgetResource { get; set; }
        
        [RealName("staticTextureResource")]
        public CBitmapTexture StaticTextureResource { get; set; }
        
        [RealName("itemNameToSpawn")]
        public CName ItemNameToSpawn { get; set; }
        
        [RealName("sceneWidgetProperties")]
        public WorlduiSceneWidgetProperties SceneWidgetProperties { get; set; }
    }
}
