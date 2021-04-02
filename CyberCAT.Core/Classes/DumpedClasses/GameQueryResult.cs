using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameQueryResult")]
    public class GameQueryResult : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hitShapes")]
        public GameShapeData[] HitShapes { get; set; }
    }
}
