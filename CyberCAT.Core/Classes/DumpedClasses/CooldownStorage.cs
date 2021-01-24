using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CooldownStorage")]
    public class CooldownStorage : IScriptable
    {
        [RealName("owner")]
        public PSOwnerData Owner { get; set; }
        
        [RealName("initialized")]
        public DumpedEnums.EBOOL? Initialized { get; set; }
        
        [RealName("gameInstanceHack")]
        public ScriptGameInstance GameInstanceHack { get; set; }
        
        [RealName("packages")]
        public Handle<CooldownPackage>[] Packages { get; set; }
        
        [RealName("currentID")]
        public uint CurrentID { get; set; }
        
        [RealName("map")]
        public CooldownPackageDelayIDs[] Map { get; set; }
    }
}
