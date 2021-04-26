using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animLookAtRef")]
    public class AnimLookAtRef : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        public int Id { get; set; }
        
        [RealName("part")]
        public CName Part { get; set; }
    }
}
