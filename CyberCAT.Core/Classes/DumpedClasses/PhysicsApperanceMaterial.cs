using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("physicsApperanceMaterial")]
    public class PhysicsApperanceMaterial : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("apperanceName")]
        public CName ApperanceName { get; set; }
        
        [RealName("materialFrom")]
        public CName MaterialFrom { get; set; }
        
        [RealName("material")]
        public CName Material { get; set; }
    }
}
