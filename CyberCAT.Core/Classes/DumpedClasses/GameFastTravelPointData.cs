using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameFastTravelPointData")]
    public class GameFastTravelPointData : IScriptable
    {
        [RealName("pointRecord")]
        public TweakDbId PointRecord { get; set; }
        
        [RealName("markerRef")]
        public NodeRef MarkerRef { get; set; }
        
        [RealName("requesterID")]
        public EntEntityID RequesterID { get; set; }
        
        [RealName("mappinID")]
        public GameNewMappinID MappinID { get; set; }
    }
}
