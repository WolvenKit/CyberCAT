using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.RenderGameplayEffectsManagerSystem
{
    [RealName("gameRenderGameplayEffectsManagerSaveData")]
    public class GameRenderGameplayEffectsManagerSaveData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("cyberspacePixelsortParams")]
        public GameCyberspacePixelsortEffectParams CyberspacePixelsortParams { get; set; }

        [RealName("cyberspacePixelsortEnabled")]
        [RealType("Bool")]
        public bool CyberspacePixelsortEnabled { get; set; }

        [RealName("enforceScreenSpaceReflectionsUberQuality")]
        [RealType("Bool")]
        public bool EnforceScreenSpaceReflectionsUberQuality { get; set; }
    }
}