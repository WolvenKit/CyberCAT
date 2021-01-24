using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ToiletControllerPS")]
    public class ToiletControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("flushDuration")]
        public float FlushDuration { get; set; }
        
        [RealName("flushSFX")]
        public CName FlushSFX { get; set; }
        
        [RealName("flushVFXname")]
        public CName FlushVFXname { get; set; }
        
        [RealName("isFlushing")]
        public bool IsFlushing { get; set; }
    }
}
