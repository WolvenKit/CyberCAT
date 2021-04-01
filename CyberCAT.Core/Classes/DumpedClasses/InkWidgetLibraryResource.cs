using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkWidgetLibraryResource")]
    public class InkWidgetLibraryResource : CResource
    {
        [RealName("rootResolution")]
        public DumpedEnums.inkETextureResolution? RootResolution { get; set; }
        
        [RealName("rootDefinitionIndex")]
        public uint RootDefinitionIndex { get; set; }
        
        [RealName("libraryItems")]
        public InkWidgetLibraryItem[] LibraryItems { get; set; }
        
        [RealName("externalLibraries")]
        public InkWidgetLibraryResource[] ExternalLibraries { get; set; }
        
        [RealName("animationLibraryResRef")]
        public InkanimAnimationLibraryResource AnimationLibraryResRef { get; set; }
        
        [RealName("sequences")]
        public Handle<InkanimSequence>[] Sequences { get; set; }
        
        [RealName("externalDependenciesForInternalItems")]
        public CResource[] ExternalDependenciesForInternalItems { get; set; }
        
        [RealName("version")]
        public DumpedEnums.inkWidgetResourceVersion? Version { get; set; }
    }
}
