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
        public CName AudioEvent { get; set; }
        
        [RealName("looped")]
        public bool Looped { get; set; }
    }
}
