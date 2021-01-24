using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vector4")]
    public class Vector4 : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("X")]
        public float X { get; set; }
        
        [RealName("Y")]
        public float Y { get; set; }
        
        [RealName("Z")]
        public float Z { get; set; }
        
        [RealName("W")]
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
