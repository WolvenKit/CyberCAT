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
        [RealType("Int32")]
        public int Value { get; set; }
        
        [RealName("id")]
        [RealType("TweakDBID")]
        public TweakDbId Id { get; set; }
    }
}
