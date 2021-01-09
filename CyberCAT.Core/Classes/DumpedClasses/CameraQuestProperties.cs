using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CameraQuestProperties")]
    public class CameraQuestProperties : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("factOnFeedReceived")]
        [RealType("CName")]
        public string FactOnFeedReceived { get; set; }
        
        [RealName("questFactOnDetection")]
        [RealType("CName")]
        public string QuestFactOnDetection { get; set; }
        
        [RealName("isInFollowMode")]
        [RealType("Bool")]
        public bool IsInFollowMode { get; set; }
        
        [RealName("followedTargetID")]
        public EntEntityID FollowedTargetID { get; set; }
    }
}
