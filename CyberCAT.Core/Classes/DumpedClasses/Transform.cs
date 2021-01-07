using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Transform")]
    public class Transform : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("position")]
        public Vector4 Position { get; set; }
        
        [RealName("orientation")]
        public Quaternion Orientation { get; set; }
    }
}
