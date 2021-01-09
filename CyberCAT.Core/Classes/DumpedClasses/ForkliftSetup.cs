using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ForkliftSetup")]
    public class ForkliftSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("actionActivateName")]
        [RealType("CName")]
        public string ActionActivateName { get; set; }
        
        [RealName("liftingAnimationTime")]
        [RealType("Float")]
        public float LiftingAnimationTime { get; set; }
        
        [RealName("hasDistractionQuickhack")]
        [RealType("Bool")]
        public bool HasDistractionQuickhack { get; set; }
    }
}
