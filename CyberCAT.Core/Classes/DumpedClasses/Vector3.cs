using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vector3")]
    public class Vector3 : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("X")]
        public float X { get; set; }
        
        [RealName("Y")]
        public float Y { get; set; }
        
        [RealName("Z")]
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
