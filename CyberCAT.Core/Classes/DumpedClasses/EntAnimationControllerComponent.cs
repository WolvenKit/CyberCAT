using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("entAnimationControllerComponent")]
    public class EntAnimationControllerComponent : EntIComponent
    {
        [RealName("actionAnimDatabaseRef")]
        public AnimActionAnimDatabase ActionAnimDatabaseRef { get; set; }
        
        [RealName("animDatabaseCollection")]
        public AnimAnimDatabaseCollection AnimDatabaseCollection { get; set; }
        
        [RealName("controlBinding")]
        public Handle<EntAnimationControlBinding> ControlBinding { get; set; }
    }
}
