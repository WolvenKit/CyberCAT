using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SPerk")]
    public class SPerk : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gamedataPerkType? Type { get; set; }
        
        [RealName("currLevel")]
        [RealType("Int32")]
        public int CurrLevel { get; set; }
    }
}
