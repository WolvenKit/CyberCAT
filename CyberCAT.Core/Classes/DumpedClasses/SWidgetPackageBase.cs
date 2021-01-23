using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SWidgetPackageBase")]
    public class SWidgetPackageBase : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("libraryPath")]
        public RedResourceReferenceScriptToken LibraryPath { get; set; }
        
        [RealName("libraryID")]
        public CName LibraryID { get; set; }
        
        [RealName("widgetTweakDBID")]
        public TweakDbId WidgetTweakDBID { get; set; }
        
        [RealName("widgetName")]
        public string WidgetName { get; set; }
        
        [RealName("placement")]
        public DumpedEnums.EWidgetPlacementType? Placement { get; set; }
        
        [RealName("isValid")]
        public bool IsValid { get; set; }
    }
}
