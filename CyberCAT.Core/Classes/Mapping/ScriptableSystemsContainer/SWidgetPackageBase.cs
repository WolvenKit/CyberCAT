using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SWidgetPackageBase")]
    public class SWidgetPackageBase : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("libraryPath")]
        public RedResourceReferenceScriptToken LibraryPath { get; set; }
        
        [RealName("libraryID")]
        [RealType("CName")]
        public string LibraryID { get; set; }
        
        [RealName("widgetTweakDBID")]
        [RealType("TweakDBID")]
        public TweakDbId WidgetTweakDBID { get; set; }
        
        [RealName("widgetName")]
        [RealType("String")]
        public string WidgetName { get; set; }
        
        [RealName("placement")]
        public DumpedEnums.EWidgetPlacementType? Placement { get; set; }
        
        [RealName("isValid")]
        [RealType("Bool")]
        public bool IsValid { get; set; }
    }
}
