using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ToiletControllerPS")]
    public class ToiletControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("flushDuration")]
        [RealType("Float")]
        public float FlushDuration { get; set; }
        
        [RealName("flushSFX")]
        [RealType("CName")]
        public string FlushSFX { get; set; }
        
        [RealName("flushVFXname")]
        [RealType("CName")]
        public string FlushVFXname { get; set; }
        
        [RealName("isFlushing")]
        [RealType("Bool")]
        public bool IsFlushing { get; set; }
    }
}
