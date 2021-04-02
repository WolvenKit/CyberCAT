using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Vector2")]
    public class Vector2 : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("X")]
        public float X { get; set; }
        
        [RealName("Y")]
        public float Y { get; set; }
    }
}
