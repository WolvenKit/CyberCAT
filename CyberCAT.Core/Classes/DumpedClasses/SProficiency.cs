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
        [RealType("Int32")]
        public int CurrentLevel { get; set; }
        
        [RealName("maxLevel")]
        [RealType("Int32")]
        public int MaxLevel { get; set; }
        
        [RealName("isAtMaxLevel")]
        [RealType("Bool")]
        public bool IsAtMaxLevel { get; set; }
        
        [RealName("currentExp")]
        [RealType("Int32")]
        public int CurrentExp { get; set; }
        
        [RealName("expToLevel")]
        [RealType("Int32")]
        public int ExpToLevel { get; set; }
        
        [RealName("spentPerkPoints")]
        [RealType("Int32")]
        public int SpentPerkPoints { get; set; }
    }
}
