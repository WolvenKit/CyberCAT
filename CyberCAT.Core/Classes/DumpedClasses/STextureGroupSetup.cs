using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STextureGroupSetup")]
    public class STextureGroupSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("compression")]
        public DumpedEnums.ETextureCompression? Compression { get; set; }
        
        [RealName("rawFormat")]
        public DumpedEnums.ETextureRawFormat? RawFormat { get; set; }
        
        [RealName("group")]
        public DumpedEnums.GpuWrapApieTextureGroup? Group { get; set; }
        
        [RealName("platformMipBiasPC")]
        public byte PlatformMipBiasPC { get; set; }
        
        [RealName("platformMipBiasConsole")]
        public byte PlatformMipBiasConsole { get; set; }
        
        [RealName("isStreamable")]
        public bool IsStreamable { get; set; }
        
        [RealName("hasMipchain")]
        public bool HasMipchain { get; set; }
        
        [RealName("isGamma")]
        public bool IsGamma { get; set; }
        
        [RealName("allowTextureDowngrade")]
        public bool AllowTextureDowngrade { get; set; }
    }
}
