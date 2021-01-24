using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TVSetup")]
    public class TVSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("channels")]
        public STvChannel[] Channels { get; set; }
        
        [RealName("initialChannel")]
        public int InitialChannel { get; set; }
        
        [RealName("initialGlobalTvChannel")]
        public TweakDbId InitialGlobalTvChannel { get; set; }
        
        [RealName("muteInterface")]
        public bool MuteInterface { get; set; }
        
        [RealName("isInteractive")]
        public bool IsInteractive { get; set; }
        
        [RealName("isGlobalTvOnly")]
        public bool IsGlobalTvOnly { get; set; }
    }
}
