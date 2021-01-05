
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("FocusCluesSystem")]
    public class FocusCluesSystem : GameScriptableSystem
    {
        [RealName("linkedClues")]
        public LinkedFocusClueData[] LinkedClues { get; set; }
        
        [RealName("disabledGroupes")]
        [RealType("CName")]
        public string[] DisabledGroupes { get; set; }
        
        [RealName("activeLinkedClue")]
        public LinkedFocusClueData ActiveLinkedClue { get; set; }
    }
}
