using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDamageOperationData")]
    public class SDamageOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("range")]
        public float Range { get; set; }
        
        [RealName("offset")]
        public Vector4 Offset { get; set; }
        
        [RealName("damageType")]
        public TweakDbId DamageType { get; set; }
    }
}
