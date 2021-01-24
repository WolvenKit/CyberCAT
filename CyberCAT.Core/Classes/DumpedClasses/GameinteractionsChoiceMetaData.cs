using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsChoiceMetaData")]
    public class GameinteractionsChoiceMetaData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tweakDBName")]
        public string TweakDBName { get; set; }
        
        [RealName("tweakDBID")]
        public TweakDbId TweakDBID { get; set; }
        
        [RealName("type")]
        public GameinteractionsChoiceTypeWrapper Type { get; set; }
    }
}
