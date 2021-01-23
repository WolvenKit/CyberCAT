using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SpiderbotScavengeOptions")]
    public class SpiderbotScavengeOptions : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("scavengableBySpiderbot")]
        public bool ScavengableBySpiderbot { get; set; }
    }
}
