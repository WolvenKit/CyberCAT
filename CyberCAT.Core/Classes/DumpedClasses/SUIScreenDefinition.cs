using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SUIScreenDefinition")]
    public class SUIScreenDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("screenDefinition")]
        public TweakDbId ScreenDefinition { get; set; }
        
        [RealName("style")]
        public TweakDbId Style { get; set; }
    }
}
