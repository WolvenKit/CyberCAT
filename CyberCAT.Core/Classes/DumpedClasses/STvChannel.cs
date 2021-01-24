using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STvChannel")]
    public class STvChannel : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("channelName")]
        public string ChannelName { get; set; }
        
        [RealName("videoPath")]
        public RedResourceReferenceScriptToken VideoPath { get; set; }
        
        [RealName("messageRecordID")]
        public TweakDbId MessageRecordID { get; set; }
        
        [RealName("audioEvent")]
        public CName AudioEvent { get; set; }
        
        [RealName("looped")]
        public bool Looped { get; set; }
        
        [RealName("sequence")]
        public SequenceVideo[] Sequence { get; set; }
        
        [RealName("channelTweakID")]
        public TweakDbId ChannelTweakID { get; set; }
    }
}
