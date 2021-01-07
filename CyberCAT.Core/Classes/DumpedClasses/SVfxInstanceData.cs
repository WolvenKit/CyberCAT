using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SVfxInstanceData")]
    public class SVfxInstanceData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("fx")]
        public Handle<GameFxInstance> Fx { get; set; }
        
        [RealName("id")]
        [RealType("CName")]
        public string Id { get; set; }
    }
}
