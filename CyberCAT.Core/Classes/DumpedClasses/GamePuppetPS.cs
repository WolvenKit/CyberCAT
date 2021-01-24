using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamePuppetPS")]
    public class GamePuppetPS : GameObjectPS
    {
        [RealName("gender")]
        public CName Gender { get; set; }
        
        [RealName("wasQuickHacked")]
        public bool WasQuickHacked { get; set; }
        
        [RealName("hasAlternativeName")]
        public bool HasAlternativeName { get; set; }
        
        [RealName("isCrouch")]
        public bool IsCrouch { get; set; }
    }
}
