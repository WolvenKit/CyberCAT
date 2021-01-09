using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameInventoryScriptCallback")]
    public class GameInventoryScriptCallback : IScriptable
    {
        [RealName("itemID")]
        public GameItemID ItemID { get; set; }
    }
}
