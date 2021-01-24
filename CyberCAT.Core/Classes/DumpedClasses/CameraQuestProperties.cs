using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CameraQuestProperties")]
    public class CameraQuestProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("factOnFeedReceived")]
        public CName FactOnFeedReceived { get; set; }
        
        [RealName("questFactOnDetection")]
        public CName QuestFactOnDetection { get; set; }
        
        [RealName("isInFollowMode")]
        public bool IsInFollowMode { get; set; }
        
        [RealName("followedTargetID")]
        public EntEntityID FollowedTargetID { get; set; }
    }
}
