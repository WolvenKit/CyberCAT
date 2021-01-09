using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameVisionModeComponentPS")]
    public class GameVisionModeComponentPS : GameComponentPS
    {
        [RealName("hideInDefaultMode")]
        [RealType("Bool")]
        public bool HideInDefaultMode { get; set; }
        
        [RealName("hideInFocusMode")]
        [RealType("Bool")]
        public bool HideInFocusMode { get; set; }
        
        [RealName("inactive")]
        [RealType("Bool")]
        public bool Inactive { get; set; }
        
        [RealName("questInactive")]
        [RealType("Bool")]
        public bool QuestInactive { get; set; }
        
        [RealName("questForcedModules")]
        [RealType("CName")]
        public string[] QuestForcedModules { get; set; }
        
        [RealName("questForcedMeshes")]
        [RealType("CName")]
        public string[] QuestForcedMeshes { get; set; }
        
        [RealName("storedHighlightData")]
        public Handle<FocusForcedHighlightPersistentData> StoredHighlightData { get; set; }
    }
}
