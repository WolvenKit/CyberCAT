using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceClearance")]
    public class GamedeviceClearance : IScriptable
    {
        [RealName("min")]
        public int Min { get; set; }
        
        [RealName("max")]
        public int Max { get; set; }
    }
}
