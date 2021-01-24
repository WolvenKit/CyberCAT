using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NetworkAreaControllerPS")]
    public class NetworkAreaControllerPS : MasterControllerPS
    {
        [RealName("isActive")]
        public bool IsActive { get; set; }
        
        [RealName("visualizerID")]
        public uint VisualizerID { get; set; }
        
        [RealName("hudActivated")]
        public bool HudActivated { get; set; }
        
        [RealName("currentlyAvailableCharges")]
        public int CurrentlyAvailableCharges { get; set; }
        
        [RealName("maxAvailableCharges")]
        public int MaxAvailableCharges { get; set; }
    }
}
