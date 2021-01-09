using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameInventoryItemAbility")]
    public class GameInventoryItemAbility : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("IconPath")]
        [RealType("CName")]
        public string IconPath { get; set; }
        
        [RealName("Title")]
        [RealType("String")]
        public string Title { get; set; }
        
        [RealName("Description")]
        [RealType("String")]
        public string Description { get; set; }
        
        [RealName("LocalizationDataPackage")]
        public Handle<GameUILocalizationDataPackage> LocalizationDataPackage { get; set; }
    }
}
