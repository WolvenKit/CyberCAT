using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("STvChannel")]
    public class STvChannel : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("channelName")]
        [RealType("String")]
        public string ChannelName { get; set; }
        
        [RealName("videoPath")]
        public RedResourceReferenceScriptToken VideoPath { get; set; }
        
        [RealName("messageRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId MessageRecordID { get; set; }
        
        [RealName("audioEvent")]
        [RealType("CName")]
        public string AudioEvent { get; set; }
        
        [RealName("looped")]
        [RealType("Bool")]
        public bool Looped { get; set; }
        
        [RealName("sequence")]
        public SequenceVideo[] Sequence { get; set; }
        
        [RealName("channelTweakID")]
        [RealType("TweakDBID")]
        public TweakDbId ChannelTweakID { get; set; }
    }
}
