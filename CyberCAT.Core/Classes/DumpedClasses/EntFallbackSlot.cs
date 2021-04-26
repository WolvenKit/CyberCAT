using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entFallbackSlot")]
    public class EntFallbackSlot : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("slotName")]
        public CName SlotName { get; set; }
        
        [RealName("boneName")]
        public CName BoneName { get; set; }
    }
}
