using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RecipientData")]
    public class RecipientData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("fuseID")]
        public int FuseID { get; set; }
        
        [RealName("entryID")]
        public int EntryID { get; set; }
    }
}
