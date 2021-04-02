using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMountEventData")]
    public class GameMountEventData : IScriptable
    {
        [RealName("initialTransformLS")]
        public Transform InitialTransformLS { get; set; }
        
        [RealName("mountParentEntityId")]
        public EntEntityID MountParentEntityId { get; set; }
        
        [RealName("slotName")]
        public CName SlotName { get; set; }
        
        [RealName("entryAnimName")]
        public CName EntryAnimName { get; set; }
        
        [RealName("isInstant")]
        public bool IsInstant { get; set; }
        
        [RealName("setEntityVisibleWhenMountFinish")]
        public bool SetEntityVisibleWhenMountFinish { get; set; }
        
        [RealName("removePitchRollRotationOnDismount")]
        public bool RemovePitchRollRotationOnDismount { get; set; }
        
        [RealName("ignoreHLS")]
        public bool IgnoreHLS { get; set; }
        
        [RealName("mountEventOptions")]
        public Handle<GameMountEventOptions> MountEventOptions { get; set; }
    }
}
