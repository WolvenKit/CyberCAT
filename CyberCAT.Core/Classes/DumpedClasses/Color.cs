using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Color")]
    public class Color : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Red")]
        [RealType("Uint8")]
        public byte Red { get; set; }
        
        [RealName("Green")]
        [RealType("Uint8")]
        public byte Green { get; set; }
        
        [RealName("Blue")]
        [RealType("Uint8")]
        public byte Blue { get; set; }
        
        [RealName("Alpha")]
        [RealType("Uint8")]
        public byte Alpha { get; set; }
    }
}
