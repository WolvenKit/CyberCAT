using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamebbScriptID")]
    public class GamebbScriptID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("None")]
        public GamebbID None { get; set; }
    }
}
