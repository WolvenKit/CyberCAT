using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamebbID")]
    public class GamebbID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("g")]
        [RealType("CName")]
        public string G { get; set; }
    }
}
