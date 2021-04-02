using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("HDRColor")]
    public class HDRColor : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("Red")]
        public float Red { get; set; }
        
        [RealName("Green")]
        public float Green { get; set; }
        
        [RealName("Blue")]
        public float Blue { get; set; }
        
        [RealName("Alpha")]
        public float Alpha { get; set; }
    }
}
