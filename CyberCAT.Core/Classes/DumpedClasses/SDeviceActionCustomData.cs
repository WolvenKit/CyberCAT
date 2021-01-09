using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceActionCustomData")]
    public class SDeviceActionCustomData : SDeviceActionData
    {
        [RealName("actionID")]
        [RealType("CName")]
        public string ActionID { get; set; }
        
        [RealName("On")]
        [RealType("Bool")]
        public bool On { get; set; }
        
        [RealName("Off")]
        [RealType("Bool")]
        public bool Off { get; set; }
        
        [RealName("Unpowered")]
        [RealType("Bool")]
        public bool Unpowered { get; set; }
        
        [RealName("displayNameRecord")]
        [RealType("TweakDBID")]
        public TweakDbId DisplayNameRecord { get; set; }
        
        [RealName("displayName")]
        [RealType("String")]
        public string DisplayName { get; set; }
        
        [RealName("customClearance")]
        [RealType("Int32")]
        public int CustomClearance { get; set; }
        
        [RealName("isEnabled")]
        [RealType("Bool")]
        public bool IsEnabled { get; set; }
        
        [RealName("disableOnUse")]
        [RealType("Bool")]
        public bool DisableOnUse { get; set; }
        
        [RealName("factToEnableName")]
        [RealType("CName")]
        public string FactToEnableName { get; set; }
        
        [RealName("quickHackCost")]
        [RealType("Int32")]
        public int QuickHackCost { get; set; }
        
        [RealName("callbackID")]
        [RealType("Uint32")]
        public uint CallbackID { get; set; }

        public SDeviceActionCustomData()
        {
            On = true;
            Off = true;
        }
    }
}
