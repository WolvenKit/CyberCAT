using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameFastTravelPointData")]
    public class GameFastTravelPointData : IScriptable
    {
        [RealName("pointRecord")]
        [RealType("TweakDBID")]
        public TweakDbId PointRecord { get; set; }
        
        [RealName("markerRef")]
        [RealType("NodeRef")]
        public string MarkerRef { get; set; }
        
        [RealName("requesterID")]
        public EntEntityID RequesterID { get; set; }
        
        [RealName("mappinID")]
        public GameNewMappinID MappinID { get; set; }
    }
}
