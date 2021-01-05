using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SecSystemDebugger")]
    public class SecSystemDebugger : GameScriptableSystem
    {
        [RealName("lastInstruction")]
        public DumpedEnums.EReprimandInstructions? LastInstruction { get; set; }
        
        [RealName("instructionSet")]
        [RealType("Bool")]
        public bool InstructionSet { get; set; }
        
        [RealName("lastInstructionTime")]
        [RealType("Float")]
        public float LastInstructionTime { get; set; }
        
        [RealName("lastInput")]
        public DumpedEnums.ESecurityNotificationType? LastInput { get; set; }
        
        [RealName("inputSet")]
        [RealType("Bool")]
        public bool InputSet { get; set; }
        
        [RealName("lastInputTime")]
        [RealType("Float")]
        public float LastInputTime { get; set; }
        
        [RealName("lastUpdateTime")]
        [RealType("Float")]
        public float LastUpdateTime { get; set; }
        
        [RealName("realTimeCallbackID")]
        public GameDelayID RealTimeCallbackID { get; set; }
        
        [RealName("realTimeCallback")]
        [RealType("Bool")]
        public bool RealTimeCallback { get; set; }
        
        [RealName("realTime")]
        [RealType("Float")]
        public float RealTime { get; set; }
        
        [RealName("callstack")]
        [RealType("CName")]
        public string[] Callstack { get; set; }
        
        [RealName("ids")]
        [RealType("Uint32")]
        public uint[] Ids { get; set; }
        
        [RealName("background")]
        [RealType("Uint32")]
        public uint Background { get; set; }
        
        [RealName("sysName")]
        [RealType("Uint32")]
        public uint SysName { get; set; }
        
        [RealName("sysState")]
        [RealType("Uint32")]
        public uint SysState { get; set; }
        
        [RealName("mostDangerousArea")]
        [RealType("Uint32")]
        public uint MostDangerousArea { get; set; }
        
        [RealName("blacklistReason")]
        [RealType("Uint32")]
        public uint BlacklistReason { get; set; }
        
        [RealName("blacklistCount")]
        [RealType("Uint32")]
        public uint BlacklistCount { get; set; }
        
        [RealName("reprimand")]
        [RealType("Uint32")]
        public uint Reprimand { get; set; }
        
        [RealName("repInstruction")]
        [RealType("Uint32")]
        public uint RepInstruction { get; set; }
        
        [RealName("reprimandID")]
        [RealType("Uint32")]
        public uint ReprimandID { get; set; }
        
        [RealName("input")]
        [RealType("Uint32")]
        public uint Input { get; set; }
        
        [RealName("regTime")]
        [RealType("Uint32")]
        public uint RegTime { get; set; }
        
        [RealName("inputTime")]
        [RealType("Uint32")]
        public uint InputTime { get; set; }
        
        [RealName("instructionTime")]
        [RealType("Uint32")]
        public uint InstructionTime { get; set; }
        
        [RealName("actualTime")]
        [RealType("Uint32")]
        public uint ActualTime { get; set; }
        
        [RealName("system")]
        public Handle<SecuritySystemControllerPS> System { get; set; }
        
        [RealName("refreshTime")]
        [RealType("Float")]
        public float RefreshTime { get; set; }
    }
}
