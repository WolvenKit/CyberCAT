using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AreaEffectTargetData")]
    public class AreaEffectTargetData : IScriptable
    {
        [RealName("areaEffectID")]
        public CName AreaEffectID { get; set; }
        
        [RealName("onSelf")]
        public bool OnSelf { get; set; }
        
        [RealName("onSlaves")]
        public bool OnSlaves { get; set; }
    }
}
