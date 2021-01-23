using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceActionBoolData")]
    public class SDeviceActionBoolData : SDeviceActionData
    {
        [RealName("nameOnTrueRecord")]
        public TweakDbId NameOnTrueRecord { get; set; }
        
        [RealName("nameOnTrue")]
        public string NameOnTrue { get; set; }
        
        [RealName("nameOnFalseRecord")]
        public TweakDbId NameOnFalseRecord { get; set; }
        
        [RealName("nameOnFalse")]
        public string NameOnFalse { get; set; }
    }
}
