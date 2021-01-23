using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SharedGameplayPS")]
    public class SharedGameplayPS : GameDeviceComponentPS
    {
        [RealName("deviceState")]
        public DumpedEnums.EDeviceStatus? DeviceState { get; set; }
        
        [RealName("authorizationProperties")]
        public AuthorizationData AuthorizationProperties { get; set; }
        
        [RealName("wasStateCached")]
        public bool WasStateCached { get; set; }
        
        [RealName("wasStateSet")]
        public bool WasStateSet { get; set; }
        
        [RealName("cachedDeviceState")]
        public DumpedEnums.EDeviceStatus? CachedDeviceState { get; set; }
        
        [RealName("revealDevicesGrid")]
        public bool RevealDevicesGrid { get; set; }
        
        [RealName("revealDevicesGridWhenUnpowered")]
        public bool RevealDevicesGridWhenUnpowered { get; set; }
        
        [RealName("wasRevealedInNetworkPing")]
        public bool WasRevealedInNetworkPing { get; set; }
        
        [RealName("hasNetworkBackdoor")]
        public bool HasNetworkBackdoor { get; set; }
    }
}
