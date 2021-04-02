using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AIArgumentOverrideWrapper")]
    public class AIArgumentOverrideWrapper : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("type")]
        public DumpedEnums.AIArgumentType? Type { get; set; }
        
        [RealName("definition")]
        public Handle<AIArgumentDefinition> Definition { get; set; }
    }
}
