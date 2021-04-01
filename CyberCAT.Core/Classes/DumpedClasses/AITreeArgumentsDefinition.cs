using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AITreeArgumentsDefinition")]
    public class AITreeArgumentsDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("args")]
        public Handle<AIArgumentDefinition>[] Args { get; set; }
    }
}
