using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("Bounty")]
    public class Bounty : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("transgressions")]
        public TweakDbId[] Transgressions { get; set; }
        
        [RealName("bountySetter")]
        public TweakDbId BountySetter { get; set; }
        
        [RealName("moneyAmount")]
        public int MoneyAmount { get; set; }
        
        [RealName("streetCredAmount")]
        public int StreetCredAmount { get; set; }
        
        [RealName("awarded")]
        public bool Awarded { get; set; }
        
        [RealName("wantedStars")]
        public int WantedStars { get; set; }
    }
}
