using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ComputerSetup")]
    public class ComputerSetup : TerminalSetup
    {
        [RealName("startingMenu")]
        public DumpedEnums.EComputerMenuType? StartingMenu { get; set; }
        
        [RealName("mailsMenu")]
        [RealType("Bool")]
        public bool MailsMenu { get; set; }
        
        [RealName("filesMenu")]
        [RealType("Bool")]
        public bool FilesMenu { get; set; }
        
        [RealName("systemMenu")]
        [RealType("Bool")]
        public bool SystemMenu { get; set; }
        
        [RealName("internetMenu")]
        [RealType("Bool")]
        public bool InternetMenu { get; set; }
        
        [RealName("newsFeedMenu")]
        [RealType("Bool")]
        public bool NewsFeedMenu { get; set; }
        
        [RealName("mailsStructure")]
        public GamedeviceGenericDataContent[] MailsStructure { get; set; }
        
        [RealName("filesStructure")]
        public GamedeviceGenericDataContent[] FilesStructure { get; set; }
        
        [RealName("newsFeed")]
        public SNewsFeedElementData[] NewsFeed { get; set; }
        
        [RealName("newsFeedInterval")]
        [RealType("Float")]
        public float NewsFeedInterval { get; set; }
        
        [RealName("internetSubnet")]
        public SInternetData InternetSubnet { get; set; }
        
        [RealName("animationState")]
        public DumpedEnums.EComputerAnimationState? AnimationState { get; set; }
    }
}
