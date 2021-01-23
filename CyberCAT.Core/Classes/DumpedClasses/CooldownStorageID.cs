using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CooldownStorageID")]
    public class CooldownStorageID : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("ID")]
        public uint ID { get; set; }
        
        [RealName("isValid")]
        public DumpedEnums.EBOOL? IsValid { get; set; }
    }
}
