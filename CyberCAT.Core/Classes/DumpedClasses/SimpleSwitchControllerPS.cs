using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SimpleSwitchControllerPS")]
    public class SimpleSwitchControllerPS : MasterControllerPS
    {
        [RealName("switchAction")]
        public DumpedEnums.ESwitchAction? SwitchAction { get; set; }
        
        [RealName("nameForON")]
        [RealType("TweakDBID")]
        public TweakDbId NameForON { get; set; }
        
        [RealName("nameForOFF")]
        [RealType("TweakDBID")]
        public TweakDbId NameForOFF { get; set; }
    }
}
