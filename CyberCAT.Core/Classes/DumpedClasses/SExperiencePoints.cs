using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SExperiencePoints")]
    public class SExperiencePoints : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("amount")]
        [RealType("Float")]
        public float Amount { get; set; }
        
        [RealName("forType")]
        public DumpedEnums.gamedataProficiencyType? ForType { get; set; }
        
        [RealName("entity")]
        public EntEntityID Entity { get; set; }
    }
}
