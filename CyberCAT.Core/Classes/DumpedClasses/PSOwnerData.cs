using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PSOwnerData")]
    public class PSOwnerData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("id")]
        public GamePersistentID Id { get; set; }
        
        [RealName("className")]
        public CName ClassName { get; set; }
    }
}
