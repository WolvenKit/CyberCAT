using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMountEventOptions")]
    public class GameMountEventOptions : IScriptable
    {
        [RealName("silentUnmount")]
        [RealType("Bool")]
        public bool SilentUnmount { get; set; }
        
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("alive")]
        [RealType("Bool")]
        public bool Alive { get; set; }
        
        [RealName("occupiedByNeutral")]
        [RealType("Bool")]
        public bool OccupiedByNeutral { get; set; }
    }
}
