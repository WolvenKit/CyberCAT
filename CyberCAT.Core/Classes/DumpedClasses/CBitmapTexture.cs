using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CBitmapTexture")]
    public class CBitmapTexture : ITexture
    {
        [RealName("width")]
        public uint Width { get; set; }
        
        [RealName("height")]
        public uint Height { get; set; }
        
        [RealName("depth")]
        public uint Depth { get; set; }
        
        [RealName("setup")]
        public STextureGroupSetup Setup { get; set; }
        
        [RealName("renderResourceBlob")]
        public Handle<IRenderResourceBlob> RenderResourceBlob { get; set; }
        
        [RealName("renderTextureResource")]
        public RendRenderTextureResource RenderTextureResource { get; set; }
        
        [RealName("histBiasMulCoef")]
        public Vector3 HistBiasMulCoef { get; set; }
        
        [RealName("histBiasAddCoef")]
        public Vector3 HistBiasAddCoef { get; set; }
    }
}
