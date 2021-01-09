using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("NetworkAreaControllerPS")]
    public class NetworkAreaControllerPS : MasterControllerPS
    {
        [RealName("isActive")]
        [RealType("Bool")]
        public bool IsActive { get; set; }
        
        [RealName("visualizerID")]
        [RealType("Uint32")]
        public uint VisualizerID { get; set; }
        
        [RealName("hudActivated")]
        [RealType("Bool")]
        public bool HudActivated { get; set; }
        
        [RealName("currentlyAvailableCharges")]
        [RealType("Int32")]
        public int CurrentlyAvailableCharges { get; set; }
        
        [RealName("maxAvailableCharges")]
        [RealType("Int32")]
        public int MaxAvailableCharges { get; set; }
    }
}
