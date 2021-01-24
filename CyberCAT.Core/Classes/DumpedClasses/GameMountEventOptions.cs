using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameMountEventOptions")]
    public class GameMountEventOptions : IScriptable
    {
        [RealName("silentUnmount")]
        public bool SilentUnmount { get; set; }
        
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("alive")]
        public bool Alive { get; set; }
        
        [RealName("occupiedByNeutral")]
        public bool OccupiedByNeutral { get; set; }
    }
}
