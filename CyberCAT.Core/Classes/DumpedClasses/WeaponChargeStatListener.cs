using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WeaponChargeStatListener")]
    public class WeaponChargeStatListener : GameCustomValueStatPoolsListener
    {
        [RealName("weapon")]
        public GameweaponObject Weapon { get; set; }
    }
}
