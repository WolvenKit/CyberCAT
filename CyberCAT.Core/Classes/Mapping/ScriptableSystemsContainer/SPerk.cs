using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
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
