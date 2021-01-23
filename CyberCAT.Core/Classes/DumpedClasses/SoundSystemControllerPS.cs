using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SoundSystemControllerPS")]
    public class SoundSystemControllerPS : MasterControllerPS
    {
        [RealName("defaultAction")]
        public int DefaultAction { get; set; }
        
        [RealName("soundSystemSettings")]
        public SoundSystemSettings[] SoundSystemSettings { get; set; }
        
        [RealName("currentEvent")]
        public Handle<ChangeMusicAction> CurrentEvent { get; set; }
        
        [RealName("cachedEvent")]
        public Handle<ChangeMusicAction> CachedEvent { get; set; }
    }
}
