using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.RenderGameplayEffectsManagerSystem
{
    [RealName("gameCyberspacePixelsortEffectParams")]
    public class GameCyberspacePixelsortEffectParams : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("fullscreen")]
        [RealType("Bool")]
        public bool Fullscreen { get; set; }

        [RealName("vfx")]
        [RealType("Bool")]
        public bool VFX { get; set; }

        [RealName("initialDatamosh")]
        [RealType("Float")]
        public float InitialDatamosh { get; set; }

        [RealName("targetDatamosh")]
        [RealType("Float")]
        public float TargetDatamosh { get; set; }

        [RealName("initialIntensity")]
        [RealType("Float")]
        public float InitialIntensity { get; set; }

        [RealName("targetIntensity")]
        [RealType("Float")]
        public float TargetIntensity { get; set; }

        [RealName("timeBlend")]
        [RealType("Float")]
        public float TimeBlend { get; set; }
    }
}