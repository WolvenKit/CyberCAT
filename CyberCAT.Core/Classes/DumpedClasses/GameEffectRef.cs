using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameEffectRef")]
    public class GameEffectRef : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("set")]
        public GameEffectSet Set { get; set; }
        
        [RealName("tag")]
        [RealType("CName")]
        public string Tag { get; set; }
    }
}
