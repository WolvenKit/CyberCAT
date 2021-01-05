using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("UIScriptableInventoryListenerCallback")]
    public class UIScriptableInventoryListenerCallback : GameInventoryScriptCallback
    {
        [RealName("uiScriptableSystem")]
        public Handle<UIScriptableSystem> UiScriptableSystem { get; set; }
    }
}
