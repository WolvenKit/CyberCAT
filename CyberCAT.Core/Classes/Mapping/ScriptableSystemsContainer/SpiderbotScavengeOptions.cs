using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SpiderbotScavengeOptions")]
    public class SpiderbotScavengeOptions : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("scavengableBySpiderbot")]
        [RealType("Bool")]
        public bool ScavengableBySpiderbot { get; set; }
    }
}
