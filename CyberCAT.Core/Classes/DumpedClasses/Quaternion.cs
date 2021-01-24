using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Quaternion")]
    public class Quaternion : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("i")]
        public float I { get; set; }
        
        [RealName("j")]
        public float J { get; set; }
        
        [RealName("k")]
        public float K { get; set; }
        
        [RealName("r")]
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
