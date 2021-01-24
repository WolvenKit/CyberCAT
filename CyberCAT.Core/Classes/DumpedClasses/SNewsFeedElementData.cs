using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SNewsFeedElementData")]
    public class SNewsFeedElementData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("banners")]
        public SsimpleBanerData[] Banners { get; set; }
        
        [RealName("currentBanner")]
        public int CurrentBanner { get; set; }
    }
}
