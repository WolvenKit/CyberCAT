using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WorkspotMapperComponent")]
    public class WorkspotMapperComponent : GameScriptableComponent
    {
        [RealName("workspotsMap")]
        public Handle<WorkspotMapData>[] WorkspotsMap { get; set; }
    }
}
