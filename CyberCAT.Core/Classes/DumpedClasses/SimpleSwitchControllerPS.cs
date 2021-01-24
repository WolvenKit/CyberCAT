using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SimpleSwitchControllerPS")]
    public class SimpleSwitchControllerPS : MasterControllerPS
    {
        [RealName("switchAction")]
        public DumpedEnums.ESwitchAction? SwitchAction { get; set; }
        
        [RealName("nameForON")]
        public TweakDbId NameForON { get; set; }
        
        [RealName("nameForOFF")]
        public TweakDbId NameForOFF { get; set; }
    }
}
