using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CooldownPackage")]
    public class CooldownPackage : IScriptable
    {
        [RealName("actionID")]
        public TweakDbId ActionID { get; set; }
        
        [RealName("addressees")]
        public PSOwnerData[] Addressees { get; set; }
        
        [RealName("initialCooldown")]
        public float InitialCooldown { get; set; }
        
        [RealName("label")]
        public CooldownStorageID Label { get; set; }
        
        [RealName("packageStatus")]
        public DumpedEnums.PackageStatus? PackageStatus { get; set; }
    }
}
