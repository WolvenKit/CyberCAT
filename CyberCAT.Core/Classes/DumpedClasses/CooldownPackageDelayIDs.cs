using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CooldownPackageDelayIDs")]
    public class CooldownPackageDelayIDs : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("packageID")]
        public CooldownStorageID PackageID { get; set; }
        
        [RealName("delayIDs")]
        public GameDelayID[] DelayIDs { get; set; }
    }
}
