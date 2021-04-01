using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkUITransform")]
    public class InkUITransform : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("translation")]
        public Vector2 Translation { get; set; }
        
        [RealName("scale")]
        public Vector2 Scale { get; set; }
        
        [RealName("rotation")]
        public float Rotation { get; set; }
        
        [RealName("shear")]
        public Vector2 Shear { get; set; }
    }
}
