using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.Global
{
    [RealName("entEntityID")]
    public class EntEntityID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("hash")]
        [RealType("Uint64")]
        public ulong Hash { get; set; }
        
    }
}
