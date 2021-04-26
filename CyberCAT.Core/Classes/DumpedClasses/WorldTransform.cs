using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WorldTransform")]
    public class WorldTransform : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Position")]
        public WorldPosition Position { get; set; }
        
        [RealName("Orientation")]
        public Quaternion Orientation { get; set; }
    }
}
