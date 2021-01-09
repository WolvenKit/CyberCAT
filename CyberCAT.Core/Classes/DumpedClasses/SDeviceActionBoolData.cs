using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceActionBoolData")]
    public class SDeviceActionBoolData : SDeviceActionData
    {
        [RealName("nameOnTrueRecord")]
        [RealType("TweakDBID")]
        public TweakDbId NameOnTrueRecord { get; set; }
        
        [RealName("nameOnTrue")]
        [RealType("String")]
        public string NameOnTrue { get; set; }
        
        [RealName("nameOnFalseRecord")]
        [RealType("TweakDBID")]
        public TweakDbId NameOnFalseRecord { get; set; }
        
        [RealName("nameOnFalse")]
        [RealType("String")]
        public string NameOnFalse { get; set; }
    }
}
