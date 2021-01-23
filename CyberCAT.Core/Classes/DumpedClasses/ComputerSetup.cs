using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ComputerSetup")]
    public class ComputerSetup : TerminalSetup
    {
        [RealName("startingMenu")]
        public DumpedEnums.EComputerMenuType? StartingMenu { get; set; }
        
        [RealName("mailsMenu")]
        public bool MailsMenu { get; set; }
        
        [RealName("filesMenu")]
        public bool FilesMenu { get; set; }
        
        [RealName("systemMenu")]
        public bool SystemMenu { get; set; }
        
        [RealName("internetMenu")]
        public bool InternetMenu { get; set; }
        
        [RealName("newsFeedMenu")]
        public bool NewsFeedMenu { get; set; }
        
        [RealName("mailsStructure")]
        public GamedeviceGenericDataContent[] MailsStructure { get; set; }
        
        [RealName("filesStructure")]
        public GamedeviceGenericDataContent[] FilesStructure { get; set; }
        
        [RealName("newsFeed")]
        public SNewsFeedElementData[] NewsFeed { get; set; }
        
        [RealName("newsFeedInterval")]
        public float NewsFeedInterval { get; set; }
        
        [RealName("internetSubnet")]
        public SInternetData InternetSubnet { get; set; }
        
        [RealName("animationState")]
        public DumpedEnums.EComputerAnimationState? AnimationState { get; set; }

        public ComputerSetup()
        {
            MailsMenu = true;
            FilesMenu = true;
            InternetMenu = true;
            SystemMenu = true;
        }
    }
}
