using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseVisibleObjectComponent")]
    public class SenseVisibleObjectComponent : EntIPlacedComponent
    {
        [RealName("visibleObject")]
        public Handle<SenseVisibleObject> VisibleObject { get; set; }
    }
}
