using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameVisionModeComponentPS")]
    public class GameVisionModeComponentPS : GameComponentPS
    {
        [RealName("storedHighlightData")]
        public Handle<FocusForcedHighlightPersistentData> StoredHighlightData { get; set; }
        
        [RealName("hideInDefaultMode")]
        public bool HideInDefaultMode { get; set; }
        
        [RealName("hideInFocusMode")]
        public bool HideInFocusMode { get; set; }
        
        [RealName("inactive")]
        public bool Inactive { get; set; }
        
        [RealName("questInactive")]
        public bool QuestInactive { get; set; }
        
        [RealName("questForcedMeshes")]
        public CName[] QuestForcedMeshes { get; set; }
        
        [RealName("questForcedModules")]
        public CName[] QuestForcedModules { get; set; }
    }
}
