using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SDocumentAdress")]
    public class SDocumentAdress : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("folderID")]
        public int FolderID { get; set; }
        
        [RealName("documentID")]
        public int DocumentID { get; set; }
    }
}
