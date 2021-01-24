using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("FocusCluesSystem")]
    public class FocusCluesSystem : GameScriptableSystem
    {
        [RealName("linkedClues")]
        public LinkedFocusClueData[] LinkedClues { get; set; }
        
        [RealName("disabledGroupes")]
        public CName[] DisabledGroupes { get; set; }
        
        [RealName("activeLinkedClue")]
        public LinkedFocusClueData ActiveLinkedClue { get; set; }
    }
}
