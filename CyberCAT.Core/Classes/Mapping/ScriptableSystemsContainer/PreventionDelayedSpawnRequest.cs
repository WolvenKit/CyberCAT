
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("PreventionDelayedSpawnRequest")]
    public class PreventionDelayedSpawnRequest : GameScriptableSystemRequest
    {
        [RealName("heatStage")]
        public DumpedEnums.EPreventionHeatStage? HeatStage { get; set; }
    }
}
