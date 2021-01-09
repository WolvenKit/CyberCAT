using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SubCharacterSystem")]
    public class SubCharacterSystem : GameScriptableSystem
    {
        [RealName("uniqueSubCharacters")]
        public SSubCharacter[] UniqueSubCharacters { get; set; }
        
        [RealName("scriptSpawnedFlathead")]
        [RealType("Bool")]
        public bool ScriptSpawnedFlathead { get; set; }
        
        [RealName("isDespawningFlathead")]
        [RealType("Bool")]
        public bool IsDespawningFlathead { get; set; }
    }
}
