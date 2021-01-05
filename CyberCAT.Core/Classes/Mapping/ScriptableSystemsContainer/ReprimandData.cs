using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("ReprimandData")]
    public class ReprimandData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("isActive")]
        [RealType("Bool")]
        public bool IsActive { get; set; }
        
        [RealName("receiver")]
        public EntEntityID Receiver { get; set; }
        
        [RealName("receiverAttitudeGroup")]
        [RealType("CName")]
        public string ReceiverAttitudeGroup { get; set; }
        
        [RealName("reprimandID")]
        [RealType("Int32")]
        public int ReprimandID { get; set; }
        
        [RealName("count")]
        [RealType("Int32")]
        public int Count { get; set; }
    }
}
