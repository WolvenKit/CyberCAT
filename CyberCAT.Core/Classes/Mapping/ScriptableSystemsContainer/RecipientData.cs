using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("RecipientData")]
    public class RecipientData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("fuseID")]
        [RealType("Int32")]
        public int FuseID { get; set; }
        
        [RealName("entryID")]
        [RealType("Int32")]
        public int EntryID { get; set; }
    }
}
