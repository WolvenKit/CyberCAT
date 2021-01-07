using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameFxResource")]
    public class GameFxResource : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("effect")]
        public WorldEffect Effect { get; set; }
    }
}
