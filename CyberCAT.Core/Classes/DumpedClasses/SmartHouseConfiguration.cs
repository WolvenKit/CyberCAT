using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SmartHouseConfiguration")]
    public class SmartHouseConfiguration : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("enableInteraction")]
        [RealType("Bool")]
        public bool EnableInteraction { get; set; }
        
        [RealName("factName")]
        [RealType("CName")]
        public string FactName { get; set; }
    }
}
