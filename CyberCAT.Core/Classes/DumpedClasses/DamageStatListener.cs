using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DamageStatListener")]
    public class DamageStatListener : GameScriptStatsListener
    {
        [RealName("weapon")]
        public GameweaponObject Weapon { get; set; }
        
        [RealName("updateEvt")]
        public Handle<UpdateDamageChangeEvent> UpdateEvt { get; set; }
    }
}
