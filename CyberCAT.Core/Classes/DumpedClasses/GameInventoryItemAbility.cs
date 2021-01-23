using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameInventoryItemAbility")]
    public class GameInventoryItemAbility : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("IconPath")]
        public CName IconPath { get; set; }
        
        [RealName("Title")]
        public string Title { get; set; }
        
        [RealName("Description")]
        public string Description { get; set; }
        
        [RealName("LocalizationDataPackage")]
        public Handle<GameUILocalizationDataPackage> LocalizationDataPackage { get; set; }
    }
}
