using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDeviceActionCustomData")]
    public class SDeviceActionCustomData : SDeviceActionData
    {
        [RealName("actionID")]
        public CName ActionID { get; set; }
        
        [RealName("On")]
        public bool On { get; set; }
        
        [RealName("Off")]
        public bool Off { get; set; }
        
        [RealName("Unpowered")]
        public bool Unpowered { get; set; }
        
        [RealName("displayNameRecord")]
        public TweakDbId DisplayNameRecord { get; set; }
        
        [RealName("displayName")]
        public string DisplayName { get; set; }
        
        [RealName("customClearance")]
        public int CustomClearance { get; set; }
        
        [RealName("isEnabled")]
        public bool IsEnabled { get; set; }
        
        [RealName("disableOnUse")]
        public bool DisableOnUse { get; set; }
        
        [RealName("factToEnableName")]
        public CName FactToEnableName { get; set; }
        
        [RealName("quickHackCost")]
        public int QuickHackCost { get; set; }
        
        [RealName("callbackID")]
        public uint CallbackID { get; set; }

        public SDeviceActionCustomData()
        {
            On = true;
            Off = true;
        }
    }
}
