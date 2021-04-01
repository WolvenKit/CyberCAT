using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceClearance")]
    public class GamedeviceClearance : IScriptable
    {
        [RealName("max")]
        public int Max { get; set; }
        
        [RealName("min")]
        public int Min { get; set; }
    }
}
