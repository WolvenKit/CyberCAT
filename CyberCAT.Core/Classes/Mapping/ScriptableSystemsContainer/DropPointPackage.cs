
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("DropPointPackage")]
    public class DropPointPackage : IScriptable
    {
        [RealName("itemID")]
        [RealType("TweakDBID")]
        public TweakDbId ItemID { get; set; }
        
        [RealName("status")]
        public DumpedEnums.DropPointPackageStatus? Status { get; set; }
        
        [RealName("predefinedDrop")]
        public GamePersistentID PredefinedDrop { get; set; }
        
        [RealName("statusHistory")]
        public DumpedEnums.DropPointPackageStatus?[] StatusHistory { get; set; }
    }
}
