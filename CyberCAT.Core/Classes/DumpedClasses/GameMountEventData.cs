using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMountEventData")]
    public class GameMountEventData : IScriptable
    {
        [RealName("slotName")]
        [RealType("CName")]
        public string SlotName { get; set; }
        
        [RealName("mountParentEntityId")]
        public EntEntityID MountParentEntityId { get; set; }
        
        [RealName("isInstant")]
        [RealType("Bool")]
        public bool IsInstant { get; set; }
        
        [RealName("entryAnimName")]
        [RealType("CName")]
        public string EntryAnimName { get; set; }
        
        [RealName("initialTransformLS")]
        public Transform InitialTransformLS { get; set; }
        
        [RealName("setEntityVisibleWhenMountFinish")]
        [RealType("Bool")]
        public bool SetEntityVisibleWhenMountFinish { get; set; }
        
        [RealName("removePitchRollRotationOnDismount")]
        [RealType("Bool")]
        public bool RemovePitchRollRotationOnDismount { get; set; }
        
        [RealName("ignoreHLS")]
        [RealType("Bool")]
        public bool IgnoreHLS { get; set; }
        
        [RealName("mountEventOptions")]
        public Handle<GameMountEventOptions> MountEventOptions { get; set; }
    }
}
