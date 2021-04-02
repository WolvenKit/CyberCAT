using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("rendRenderTextureResource")]
    public class RendRenderTextureResource : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("renderResourceBlobPC")]
        public Handle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }
    }
}
