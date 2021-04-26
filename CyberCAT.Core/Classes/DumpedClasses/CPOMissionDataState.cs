using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CPOMissionDataState")]
    public class CPOMissionDataState : IScriptable
    {
        [RealName("CPOMissionDataDamagesPreset")]
        public CName CPOMissionDataDamagesPreset { get; set; }
        
        [RealName("compatibleDeviceName")]
        public CName CompatibleDeviceName { get; set; }
        
        [RealName("ownerDecidesOnTransfer")]
        public bool OwnerDecidesOnTransfer { get; set; }
        
        [RealName("isChoiceToken")]
        public bool IsChoiceToken { get; set; }
        
        [RealName("choiceTokenTimeout")]
        public uint ChoiceTokenTimeout { get; set; }
        
        [RealName("delayedGiveChoiceTokenEventId")]
        public GameDelayID DelayedGiveChoiceTokenEventId { get; set; }
        
        [RealName("dataDamageTextLayerId")]
        public uint DataDamageTextLayerId { get; set; }
    }
}
