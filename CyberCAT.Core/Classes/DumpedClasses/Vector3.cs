using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vector3")]
    public class Vector3 : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("X")]
        [RealType("Float")]
        public float X { get; set; }
        
        [RealName("Y")]
        [RealType("Float")]
        public float Y { get; set; }
        
        [RealName("Z")]
        [RealType("Float")]
        public float Z { get; set; }

        public Vector3()
        {
            // TODO: Verify this
            X = float.NaN;
            Y = float.NaN;
            Z = float.NaN;
        }
    }
}
