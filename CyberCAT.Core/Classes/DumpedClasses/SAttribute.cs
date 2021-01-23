using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SAttribute")]
    public class SAttribute : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("attributeName")]
        public DumpedEnums.gamedataStatType? AttributeName { get; set; }
        
        [RealName("value")]
        public int Value { get; set; }
        
        [RealName("id")]
        public TweakDbId Id { get; set; }
    }
}
