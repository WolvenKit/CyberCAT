using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("StimRequestID")]
    public class StimRequestID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("ID")]
        public uint ID { get; set; }
        
        [RealName("isValid")]
        public bool IsValid { get; set; }
    }
}
