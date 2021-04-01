using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WorkspotMapData")]
    public class WorkspotMapData : IScriptable
    {
        [RealName("action")]
        public DumpedEnums.gamedataWorkspotActionType? Action { get; set; }
        
        [RealName("workspots")]
        public Handle<WorkspotEntryData>[] Workspots { get; set; }
    }
}
