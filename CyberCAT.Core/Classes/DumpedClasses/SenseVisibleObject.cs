using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseVisibleObject")]
    public class SenseVisibleObject : IScriptable
    {
        [RealName("description")]
        public CName Description { get; set; }
        
        [RealName("visibilityDistance")]
        public float VisibilityDistance { get; set; }
        
        [RealName("visibleObjectType")]
        public DumpedEnums.gamedataSenseObjectType? VisibleObjectType { get; set; }
    }
}
