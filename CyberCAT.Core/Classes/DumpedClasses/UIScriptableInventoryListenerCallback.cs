using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("UIScriptableInventoryListenerCallback")]
    public class UIScriptableInventoryListenerCallback : GameInventoryScriptCallback
    {
        [RealName("uiScriptableSystem")]
        public Handle<UIScriptableSystem> UiScriptableSystem { get; set; }
    }
}
