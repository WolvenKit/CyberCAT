using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gamedeviceClearance")]
    public class GamedeviceClearance : IScriptable
    {
        [RealName("min")]
        [RealType("Int32")]
        public int Min { get; set; }
        
        [RealName("max")]
        [RealType("Int32")]
        public int Max { get; set; }
    }
}
