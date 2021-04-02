using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("OverheatStatListener")]
    public class OverheatStatListener : GameScriptStatPoolsListener
    {
        [RealName("weapon")]
        public GameweaponObject Weapon { get; set; }
        
        [RealName("updateEvt")]
        public Handle<UpdateOverheatEvent> UpdateEvt { get; set; }
        
        [RealName("startEvt")]
        public Handle<StartOverheatEffectEvent> StartEvt { get; set; }
    }
}
