using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WorldPosition")]
    public class WorldPosition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("x")]
        public FixedPoint X { get; set; }
        
        [RealName("y")]
        public FixedPoint Y { get; set; }
        
        [RealName("z")]
        public FixedPoint Z { get; set; }
    }
}
