using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameCyberspacePixelsortEffectParams")]
    public class GameCyberspacePixelsortEffectParams : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("fullscreen")]
        public bool Fullscreen { get; set; }
        
        [RealName("vfx")]
        public bool Vfx { get; set; }
        
        [RealName("initialDatamosh")]
        public float InitialDatamosh { get; set; }
        
        [RealName("targetDatamosh")]
        public float TargetDatamosh { get; set; }
        
        [RealName("initialIntensity")]
        public float InitialIntensity { get; set; }
        
        [RealName("targetIntensity")]
        public float TargetIntensity { get; set; }
        
        [RealName("timeBlend")]
        public float TimeBlend { get; set; }
    }
}
