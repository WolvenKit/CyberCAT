
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SharedGameplayPS")]
    public class SharedGameplayPS : GameDeviceComponentPS
    {
        [RealName("deviceState")]
        public DumpedEnums.EDeviceStatus? DeviceState { get; set; }
        
        [RealName("authorizationProperties")]
        public AuthorizationData AuthorizationProperties { get; set; }
        
        [RealName("wasStateCached")]
        [RealType("Bool")]
        public bool WasStateCached { get; set; }
        
        [RealName("wasStateSet")]
        [RealType("Bool")]
        public bool WasStateSet { get; set; }
        
        [RealName("cachedDeviceState")]
        public DumpedEnums.EDeviceStatus? CachedDeviceState { get; set; }
        
        [RealName("revealDevicesGrid")]
        [RealType("Bool")]
        public bool RevealDevicesGrid { get; set; }
        
        [RealName("revealDevicesGridWhenUnpowered")]
        [RealType("Bool")]
        public bool RevealDevicesGridWhenUnpowered { get; set; }
        
        [RealName("wasRevealedInNetworkPing")]
        [RealType("Bool")]
        public bool WasRevealedInNetworkPing { get; set; }
        
        [RealName("hasNetworkBackdoor")]
        [RealType("Bool")]
        public bool HasNetworkBackdoor { get; set; }
    }
}
