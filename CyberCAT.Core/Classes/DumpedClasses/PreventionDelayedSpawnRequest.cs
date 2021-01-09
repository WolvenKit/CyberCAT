using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PreventionDelayedSpawnRequest")]
    public class PreventionDelayedSpawnRequest : GameScriptableSystemRequest
    {
        [RealName("heatStage")]
        public DumpedEnums.EPreventionHeatStage? HeatStage { get; set; }
    }
}
