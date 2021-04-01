using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("animAnimDatabaseCollection")]
    public class AnimAnimDatabaseCollection : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("animDatabases")]
        public AnimAnimDatabaseCollectionEntry[] AnimDatabases { get; set; }
    }
}
