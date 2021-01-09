using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamePuppetPS")]
    public class GamePuppetPS : GameObjectPS
    {
        [RealName("gender")]
        [RealType("CName")]
        public string Gender { get; set; }
        
        [RealName("wasQuickHacked")]
        [RealType("Bool")]
        public bool WasQuickHacked { get; set; }
        
        [RealName("hasAlternativeName")]
        [RealType("Bool")]
        public bool HasAlternativeName { get; set; }
        
        [RealName("isCrouch")]
        [RealType("Bool")]
        public bool IsCrouch { get; set; }
    }
}
