
using CyberCAT.Core.Classes.Mapping.Global;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameFastTravelPointData")]
    public class GameFastTravelPointData : IScriptable
    {
        [RealName("pointRecord")]
        [RealType("TweakDBID")]
        public ulong PointRecord { get; set; }
        
        [RealName("markerRef")]
        [RealType("NodeRef")]
        public string MarkerRef { get; set; }
        
        [RealName("requesterID")]
        public EntEntityID RequesterID { get; set; }
        
        [RealName("mappinID")]
        public GameNewMappinID MappinID { get; set; }
    }
}
