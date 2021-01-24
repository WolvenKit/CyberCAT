using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameRenderGameplayEffectsManagerSaveData")]
    public class GameRenderGameplayEffectsManagerSaveData : ISerializable
    {
        [RealName("cyberspacePixelsortParams")]
        public GameCyberspacePixelsortEffectParams CyberspacePixelsortParams { get; set; }
        
        [RealName("cyberspacePixelsortEnabled")]
        public bool CyberspacePixelsortEnabled { get; set; }
        
        [RealName("enforceScreenSpaceReflectionsUberQuality")]
        public bool EnforceScreenSpaceReflectionsUberQuality { get; set; }
    }
}
