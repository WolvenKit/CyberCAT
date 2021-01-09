using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameRenderGameplayEffectsManagerSaveData")]
    public class GameRenderGameplayEffectsManagerSaveData : ISerializable
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
