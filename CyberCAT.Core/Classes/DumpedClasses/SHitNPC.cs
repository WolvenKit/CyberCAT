using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SHitNPC")]
    public class SHitNPC : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("calls")]
        public int Calls { get; set; }
    }
}
