using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WorkspotEntryData")]
    public class WorkspotEntryData : IScriptable
    {
        [RealName("workspotRef")]
        public NodeRef WorkspotRef { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("isAvailable")]
        public bool IsAvailable { get; set; }
    }
}
