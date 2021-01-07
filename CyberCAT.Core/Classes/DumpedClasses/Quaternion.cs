using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Quaternion")]
    public class Quaternion : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("i")]
        [RealType("Float")]
        public float I { get; set; }
        
        [RealName("j")]
        [RealType("Float")]
        public float J { get; set; }
        
        [RealName("k")]
        [RealType("Float")]
        public float K { get; set; }
        
        [RealName("r")]
        [RealType("Float")]
        public float R { get; set; }

        public Quaternion()
        {
            // TODO: Verify this
            I = float.NaN;
            J = float.NaN;
            K = float.NaN;
            R = float.NaN;
        }
    }
}
