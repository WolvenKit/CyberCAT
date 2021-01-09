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
        [RealType("Int32")]
        public int InitialChannel { get; set; }
        
        [RealName("initialGlobalTvChannel")]
        [RealType("TweakDBID")]
        public TweakDbId InitialGlobalTvChannel { get; set; }
        
        [RealName("muteInterface")]
        [RealType("Bool")]
        public bool MuteInterface { get; set; }
        
        [RealName("isInteractive")]
        [RealType("Bool")]
        public bool IsInteractive { get; set; }
        
        [RealName("isGlobalTvOnly")]
        [RealType("Bool")]
        public bool IsGlobalTvOnly { get; set; }
    }
}
