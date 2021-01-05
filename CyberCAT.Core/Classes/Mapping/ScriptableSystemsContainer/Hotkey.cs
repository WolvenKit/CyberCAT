
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("Hotkey")]
    public class Hotkey : IScriptable
    {
        [RealName("hotkey")]
        public DumpedEnums.gameEHotkey? HotkeyProp { get; set; }
        
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
        
        [RealName("scope")]
        public DumpedEnums.gamedataItemType?[] Scope { get; set; }
    }
}
