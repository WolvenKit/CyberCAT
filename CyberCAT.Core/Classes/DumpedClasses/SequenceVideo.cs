using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SequenceVideo")]
    public class SequenceVideo : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("videoPath")]
        public RedResourceReferenceScriptToken VideoPath { get; set; }
        
        [RealName("audioEvent")]
        [RealType("CName")]
        public string AudioEvent { get; set; }
        
        [RealName("looped")]
        [RealType("Bool")]
        public bool Looped { get; set; }
    }
}
