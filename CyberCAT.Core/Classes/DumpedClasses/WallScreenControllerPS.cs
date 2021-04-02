using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("WallScreenControllerPS")]
    public class WallScreenControllerPS : TVControllerPS
    {
        [RealName("isShown")]
        public bool IsShown { get; set; }
    }
}
