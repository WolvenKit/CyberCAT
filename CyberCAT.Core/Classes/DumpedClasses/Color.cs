using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Color")]
    public class Color : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Red")]
        public byte Red { get; set; }
        
        [RealName("Green")]
        public byte Green { get; set; }
        
        [RealName("Blue")]
        public byte Blue { get; set; }
        
        [RealName("Alpha")]
        public byte Alpha { get; set; }
    }
}
