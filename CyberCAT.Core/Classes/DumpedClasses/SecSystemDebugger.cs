using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecSystemDebugger")]
    public class SecSystemDebugger : GameScriptableSystem
    {
        [RealName("lastInstruction")]
        public DumpedEnums.EReprimandInstructions? LastInstruction { get; set; }
        
        [RealName("instructionSet")]
        public bool InstructionSet { get; set; }
        
        [RealName("lastInstructionTime")]
        public float LastInstructionTime { get; set; }
        
        [RealName("lastInput")]
        public DumpedEnums.ESecurityNotificationType? LastInput { get; set; }
        
        [RealName("inputSet")]
        public bool InputSet { get; set; }
        
        [RealName("lastInputTime")]
        public float LastInputTime { get; set; }
        
        [RealName("lastUpdateTime")]
        public float LastUpdateTime { get; set; }
        
        [RealName("realTimeCallbackID")]
        public GameDelayID RealTimeCallbackID { get; set; }
        
        [RealName("realTimeCallback")]
        public bool RealTimeCallback { get; set; }
        
        [RealName("realTime")]
        public float RealTime { get; set; }
        
        [RealName("callstack")]
        public CName[] Callstack { get; set; }
        
        [RealName("ids")]
        public uint[] Ids { get; set; }
        
        [RealName("background")]
        public uint Background { get; set; }
        
        [RealName("sysName")]
        public uint SysName { get; set; }
        
        [RealName("sysState")]
        public uint SysState { get; set; }
        
        [RealName("mostDangerousArea")]
        public uint MostDangerousArea { get; set; }
        
        [RealName("blacklistReason")]
        public uint BlacklistReason { get; set; }
        
        [RealName("blacklistCount")]
        public uint BlacklistCount { get; set; }
        
        [RealName("reprimand")]
        public uint Reprimand { get; set; }
        
        [RealName("repInstruction")]
        public uint RepInstruction { get; set; }
        
        [RealName("reprimandID")]
        public uint ReprimandID { get; set; }
        
        [RealName("input")]
        public uint Input { get; set; }
        
        [RealName("regTime")]
        public uint RegTime { get; set; }
        
        [RealName("inputTime")]
        public uint InputTime { get; set; }
        
        [RealName("instructionTime")]
        public uint InstructionTime { get; set; }
        
        [RealName("actualTime")]
        public uint ActualTime { get; set; }
        
        [RealName("system")]
        public Handle<SecuritySystemControllerPS> System { get; set; }
        
        [RealName("refreshTime")]
        public float RefreshTime { get; set; }
    }
}
