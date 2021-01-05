using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("STrait")]
    public class STrait : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gamedataTraitType? Type { get; set; }
        
        [RealName("unlocked")]
        [RealType("Bool")]
        public bool Unlocked { get; set; }
        
        [RealName("currLevel")]
        [RealType("Int32")]
        public int CurrLevel { get; set; }
    }
}
