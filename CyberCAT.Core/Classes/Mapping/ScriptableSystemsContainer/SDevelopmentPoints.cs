using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SDevelopmentPoints")]
    public class SDevelopmentPoints : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gamedataDevelopmentPointType? Type { get; set; }
        
        [RealName("spent")]
        [RealType("Int32")]
        public int Spent { get; set; }
        
        [RealName("unspent")]
        [RealType("Int32")]
        public int Unspent { get; set; }
    }
}
