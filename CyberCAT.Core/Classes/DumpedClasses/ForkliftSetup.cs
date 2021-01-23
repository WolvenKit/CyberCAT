using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ForkliftSetup")]
    public class ForkliftSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actionActivateName")]
        public CName ActionActivateName { get; set; }
        
        [RealName("liftingAnimationTime")]
        public float LiftingAnimationTime { get; set; }
        
        [RealName("hasDistractionQuickhack")]
        public bool HasDistractionQuickhack { get; set; }
    }
}
