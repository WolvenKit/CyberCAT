using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDocumentAdress")]
    public class SDocumentAdress : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("folderID")]
        [RealType("Int32")]
        public int FolderID { get; set; }
        
        [RealName("documentID")]
        [RealType("Int32")]
        public int DocumentID { get; set; }
    }
}
