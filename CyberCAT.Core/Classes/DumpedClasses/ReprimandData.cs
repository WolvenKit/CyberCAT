using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ReprimandData")]
    public class ReprimandData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isActive")]
        public bool IsActive { get; set; }
        
        [RealName("receiver")]
        public EntEntityID Receiver { get; set; }
        
        [RealName("receiverAttitudeGroup")]
        public CName ReceiverAttitudeGroup { get; set; }
        
        [RealName("reprimandID")]
        public int ReprimandID { get; set; }
        
        [RealName("count")]
        public int Count { get; set; }
    }
}
