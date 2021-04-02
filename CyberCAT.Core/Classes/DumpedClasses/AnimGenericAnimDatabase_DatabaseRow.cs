using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animGenericAnimDatabase_DatabaseRow")]
    public class AnimGenericAnimDatabase_DatabaseRow : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("inputValues")]
        public int[] InputValues { get; set; }
        
        [RealName("animationData")]
        public AnimGenericAnimDatabase_AnimationData AnimationData { get; set; }
    }
}
