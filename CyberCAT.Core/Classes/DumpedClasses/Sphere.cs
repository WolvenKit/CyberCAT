using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Sphere")]
    public class Sphere : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("CenterRadius2")]
        public Vector4 CenterRadius2 { get; set; }
    }
}
