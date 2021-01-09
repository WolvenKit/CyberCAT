using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vector4")]
    public class Vector4 : GenericUnknownStruct.BaseClassEntry
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
        
        [RealName("W")]
        [RealType("Float")]
        public float W { get; set; }

        public Vector4()
        {
            // TODO: Verify this
            X = float.NaN;
            Y = float.NaN;
            Z = float.NaN;
            W = float.NaN;
        }
    }
}
