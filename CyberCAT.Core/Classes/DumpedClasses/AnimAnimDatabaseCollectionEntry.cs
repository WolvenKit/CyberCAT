using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animAnimDatabaseCollectionEntry")]
    public class AnimAnimDatabaseCollectionEntry : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("name")]
        public CName Name { get; set; }
        
        [RealName("animDatabase")]
        public C2dArray AnimDatabase { get; set; }
        
        [RealName("overrideAnimDatabase")]
        public AnimGenericAnimDatabase OverrideAnimDatabase { get; set; }
    }
}
