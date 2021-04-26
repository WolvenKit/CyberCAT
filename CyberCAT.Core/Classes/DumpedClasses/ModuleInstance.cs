using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ModuleInstance")]
    public class ModuleInstance : IScriptable
    {
        [RealName("isLookedAt")]
        public bool IsLookedAt { get; set; }
        
        [RealName("isRevealed")]
        public bool IsRevealed { get; set; }
        
        [RealName("wasProcessed")]
        public bool WasProcessed { get; set; }
        
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("state")]
        public DumpedEnums.InstanceState? State { get; set; }
        
        [RealName("previousInstance")]
        public Handle<ModuleInstance> PreviousInstance { get; set; }
    }
}
