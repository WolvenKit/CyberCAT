using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SProficiency")]
    public class SProficiency : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gamedataProficiencyType? Type { get; set; }
        
        [RealName("currentLevel")]
        public int CurrentLevel { get; set; }
        
        [RealName("maxLevel")]
        public int MaxLevel { get; set; }
        
        [RealName("isAtMaxLevel")]
        public bool IsAtMaxLevel { get; set; }
        
        [RealName("currentExp")]
        public int CurrentExp { get; set; }
        
        [RealName("expToLevel")]
        public int ExpToLevel { get; set; }
        
        [RealName("spentPerkPoints")]
        public int SpentPerkPoints { get; set; }
    }
}
